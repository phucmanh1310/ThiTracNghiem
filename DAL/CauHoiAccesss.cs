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
            List<CauHoi> listCauHoi = new List<CauHoi>();

            string query = "SELECT * FROM CauHoi";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
<<<<<<< Updated upstream
                    // Chuyển đổi cột MaPhan sang short
                    short maPhan = Convert.ToInt16(reader["MaPhan"]);

                    // Lấy hình ảnh nếu có (byte[])
                    byte[] imageBytes = reader["HinhAnh"] as byte[];

                    // Khởi tạo đối tượng CauHoi
                    CauHoi cauHoi = new CauHoi(
                        reader["MaCauHoi"].ToString(),
                        reader["NDCauHoi"].ToString(),
                        maPhan,
                        imageBytes
                    );

                    listCauHoi.Add(cauHoi);
=======
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string hinhAnh = reader["HinhAnh"] == DBNull.Value ? null : reader["HinhAnh"].ToString();
                        if (!string.IsNullOrEmpty(hinhAnh))
                        {
                            // Sử dụng Directory.GetCurrentDirectory hoặc AppContext.BaseDirectory
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
>>>>>>> Stashed changes
                }
                reader.Close();
            }
            return listCauHoi;
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

                // Xử lý trường hợp nếu HinhAnh là null
                if (cauHoi.HinhAnh == null)
                {
                    command.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                else
                {
<<<<<<< Updated upstream
                    command.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = cauHoi.HinhAnh;
=======
                    // Chỉ lưu đường dẫn tương đối
                    string startupPath = AppContext.BaseDirectory;
                    string relativePath = cauHoi.HinhAnh.Replace(startupPath + "\\", "");
                    command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = relativePath;
>>>>>>> Stashed changes
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
        public List<Tuple<string, string, string>> GetCauHoiByMaPhan(int maPhan)
        {
            List<Tuple<string, string, string>> listCauHoi = new List<Tuple<string, string, string>>();

            string query = @"
                SELECT P.TenPhan, CH.NDCauHoi, DA.NDCauTraLoi AS DapAnDung
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
                    String tenPhan = reader["TenPhan"].ToString(); // Đọc MaPhan là int
                    string ndCauHoi = reader["NDCauHoi"].ToString();
                    string dapAnDung = reader["DapAnDung"].ToString();

                    // Thêm vào danh sách tạm thời
                    listCauHoi.Add(new Tuple<string, string, string>(tenPhan, ndCauHoi, dapAnDung));
                }
                reader.Close();
            }

            return listCauHoi;
        }


    }
}