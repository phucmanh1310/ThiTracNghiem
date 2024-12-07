using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace DAL
{
    public class CauHoiAccesss : DatabaseAccess
    {
        public List<CauHoi> GetCauHoi()
        {
            List<CauHoi> danhSachCauHoi = new List<CauHoi>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = @"
                SELECT TOP (@SoLuong) * FROM CauHoi 
                WHERE MaPhan = @MaPhan 
                ORDER BY NEWID()";

                // Cấu trúc đề thi
                var deThiCauTruc = new Dictionary<int, int>
                {
                    { 1, 8 }, // Mã phần 1: 8 câu
                    { 6, 1 }, // Mã phần 6: 1 câu (câu điểm liệt)
                    { 2, 1 }, // Mã phần 2: 1 câu
                    { 3, 1 }, // Mã phần 3: 1 câu
                    { 4, 7 }, // Mã phần 4: 7 câu
                    { 5, 7 }  // Mã phần 5: 7 câu
                };

                foreach (var item in deThiCauTruc)
                {
                    int maPhan = item.Key;
                    int soLuong = item.Value;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhan", maPhan);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hinhAnh = reader["HinhAnh"] == DBNull.Value ? null : reader["HinhAnh"].ToString();
                                if (!string.IsNullOrEmpty(hinhAnh))
                                {
                                    hinhAnh = Path.Combine(AppContext.BaseDirectory, hinhAnh);
                                }

                                CauHoi cauHoi = new CauHoi(
                                    Convert.ToInt32(reader["MaCauHoi"]),
                                    reader["NDCauHoi"].ToString(),
                                    short.Parse(reader["MaPhan"].ToString()),
                                    hinhAnh
                                );
                                danhSachCauHoi.Add(cauHoi);
                            }
                        }
                    }
                }
            }
            return danhSachCauHoi;
        }

        

        public int AddCauHoi(CauHoi cauHoi)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                // Câu lệnh SQL để thêm câu hỏi
                string query = "INSERT INTO CauHoi (NDCauHoi, MaPhan, HinhAnh) OUTPUT INSERTED.MaCauHoi VALUES (@NDCauHoi, @MaPhan, @HinhAnh)";
                SqlCommand command = new SqlCommand(query, connection);

                // Gán các tham số cho câu lệnh SQL
                command.Parameters.AddWithValue("@NDCauHoi", cauHoi.NDCauHoi);
                command.Parameters.AddWithValue("@MaPhan", cauHoi.MaPhan);

                // Xử lý HinhAnh là null hoặc đường dẫn
                if (string.IsNullOrEmpty(cauHoi.HinhAnh))
                {
                    command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    // Chỉ lưu đường dẫn tương đối
                    string startupPath = AppContext.BaseDirectory;
                    string relativePath = cauHoi.HinhAnh.Replace(startupPath + "\\", "");
                    command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = relativePath;
                }


                connection.Open();
                return (int)command.ExecuteScalar(); // Trả về mã câu hỏi vừa được thêm
            }
        }
        // Thêm đáp án vào cơ sở dữ liệu
        public void AddDapAn(DapAn dapAn)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                string query = "INSERT INTO DapAn (NDCauTraLoi, MaCauHoi, DungSai) VALUES (@NDCauTraLoi, @MaCauHoi, @DungSai)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NDCauTraLoi", dapAn.NDCauTraLoi);
                command.Parameters.AddWithValue("@MaCauHoi", dapAn.MaCauHoi);
                command.Parameters.AddWithValue("@DungSai", dapAn.DungSai);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Viết phương thức để lấy danh sách câu hỏi theo MaPhan:
        public List<Tuple<string,int, string, string>> GetCauHoiByMaPhan(int maPhan)
        {
            List<Tuple<string, int, string, string>> listCauHoi = new List<Tuple<string, int, string, string>>();

            string query = @"
                SELECT P.TenPhan, CH.MaCauHoi ,CH.NDCauHoi, DA.NDCauTraLoi AS DapAnDung
                FROM CauHoi CH
                JOIN Phan P ON CH.MaPhan = P.MaPhan
                JOIN DapAn DA ON CH.MaCauHoi = DA.MaCauHoi
                WHERE DA.DungSai = 1 AND P.MaPhan = @MaPhan";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhan", maPhan);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Đọc dữ liệu
                    String tenPhan = reader["TenPhan"].ToString();
                    int maCauHoi = Convert.ToInt32(reader["MaCauHoi"]);
                    string ndCauHoi = reader["NDCauHoi"].ToString();
                    string dapAnDung = reader["DapAnDung"].ToString();

                    // Thêm vào danh sách tạm thời
                    listCauHoi.Add(new Tuple<string, int, string, string>(tenPhan, maCauHoi, ndCauHoi, dapAnDung));
                }
                reader.Close();
            }

            return listCauHoi;
        }
        //phương thức lấy thông tin câu hỏi bằng mã câu hỏi
        public CauHoi GetCauHoiChiTietById(int maCauHoi)
        {
            CauHoi cauhoi = null;
            string query = "Select NDCauHoi, HinhAnh from CauHoi where MaCauHoi = @maCauHoi";
            using (SqlConnection con = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@maCauHoi", SqlDbType.Int).Value = maCauHoi;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string ndCauHoi = reader["NDCauHoi"].ToString();
                    string hinhAnh = reader["HinhAnh"].ToString();

                    cauhoi = new CauHoi(ndCauHoi, hinhAnh);
                }
            }
            return cauhoi;
        }
        public bool XoaDapAn(int maCauHoi)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Xóa đáp án trước
                    string deleteDapAn = "DELETE FROM DapAn WHERE MaCauHoi = @maCauHoi";
                    SqlCommand deleteDapAnCmd = new SqlCommand(deleteDapAn, conn, transaction);
                    deleteDapAnCmd.Parameters.AddWithValue("@maCauHoi", maCauHoi);
                    deleteDapAnCmd.ExecuteNonQuery();

                    // Sau đó xóa câu hỏi
                    string deleteCauHoi = "DELETE FROM CauHoi WHERE MaCauHoi = @maCauHoi";
                    SqlCommand deleteCauHoiCmd = new SqlCommand(deleteCauHoi, conn, transaction);
                    deleteCauHoiCmd.Parameters.AddWithValue("@maCauHoi", maCauHoi);
                    deleteCauHoiCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
     

        public bool UpdateCauHoiAndDapAn(int maCauHoi, int maPhan, string ndCauHoi, string hinhAnh, List<DapAn> danhSachDapAn)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Cập nhật câu hỏi
                    string queryCauHoi = @"
                    UPDATE CauHoi
                    SET NDCauHoi = @NDCauHoi, MaPhan = @MaPhan, HinhAnh = @HinhAnh
                    WHERE MaCauHoi = @MaCauHoi";

                    SqlCommand cmdCauHoi = new SqlCommand(queryCauHoi, conn, transaction);
                    cmdCauHoi.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
                    cmdCauHoi.Parameters.AddWithValue("@NDCauHoi", ndCauHoi);
                    cmdCauHoi.Parameters.AddWithValue("@MaPhan", maPhan);
                    cmdCauHoi.Parameters.AddWithValue("@HinhAnh", (object)hinhAnh ?? DBNull.Value);

                    cmdCauHoi.ExecuteNonQuery();

                    // Xóa đáp án cũ
                    string queryXoaDapAn = "DELETE FROM DapAn WHERE MaCauHoi = @MaCauHoi";
                    SqlCommand cmdXoaDapAn = new SqlCommand(queryXoaDapAn, conn, transaction);
                    cmdXoaDapAn.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
                    cmdXoaDapAn.ExecuteNonQuery();

                    // Thêm các đáp án mới
                    foreach (var dapAn in danhSachDapAn)
                    {
                        string queryDapAn = @"
                    INSERT INTO DapAn (MaCauHoi, NDCauTraLoi, DungSai)
                    VALUES (@MaCauHoi, @NDCauTraLoi, @DungSai)";

                        SqlCommand cmdDapAn = new SqlCommand(queryDapAn, conn, transaction);
                        cmdDapAn.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
                        cmdDapAn.Parameters.AddWithValue("@NDCauTraLoi", dapAn.NDCauTraLoi);
                        cmdDapAn.Parameters.AddWithValue("@DungSai", dapAn.DungSai ? 1 : 0);

                        cmdDapAn.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // Rollback transaction nếu có lỗi
                    transaction.Rollback();
                    throw;
                }
            }
        }


    }
}