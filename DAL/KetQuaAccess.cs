using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class KetQuaAccess : DatabaseAccess
    {
        public List<KetQua> getKetQuaThi(int maThiSinh)
        {
            List<KetQua> ketQuaList = new List<KetQua>();
            String query = "SELECT MaKetQua,ThoiGian, LanThi, KetQua FROM KetQua WHERE MaThiSinh = @MaThiSinh";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {                 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        KetQua ketqua = new KetQua
                        {
                            MaKetQua = reader.GetInt32(0),
                            ThoiGian = reader.GetInt32(1),  // ThoiGian là cột đầu tiên trong query
                            LanThi = reader.GetInt32(2),       // LanThi là cột thứ hai
                            KetQuaThi = reader.GetString(3)     // KetQua là cột thứ ba
                        };
                        ketQuaList.Add(ketqua);
                    }
                    return ketQuaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("Không tìm thấy kết quả thi của thí sinh: " + ex.Message);
                }
            }
        }

        public bool LuuKetQua(KetQua ketQua, Dictionary<int, int?> DapAnDaChon)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    

                    // Lệnh SQL để lưu kết quả vào bảng KetQua
                    string query = "INSERT INTO KetQua (LanThi, KetQuaThi, MaThiSinh, ThoiGian) " +
                                   "VALUES (@LanThi, @KetQuaThi, @MaThiSinh, @ThoiGian)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LanThi", ketQua.LanThi);
                    cmd.Parameters.AddWithValue("@KetQuaThi", ketQua.KetQuaThi);
                    cmd.Parameters.AddWithValue("@MaThiSinh", ketQua.MaThiSinh);
                    cmd.Parameters.AddWithValue("@ThoiGian", ketQua.ThoiGian);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        return false;
                    }

                    
                    int MaKetQua = (int)cmd.ExecuteScalar();

                    // Thêm dữ liệu vào bảng ChiTietKetQua
                    foreach (var dapAnDaChon in DapAnDaChon)
                    {
                        string insert = "INSERT INTO ChiTietKetQua (MaKetQua, MaCauHoi, MaCauTraLoi) " +
                                        "VALUES (@MaKetQua, @MaCauHoi, @MaCauTraLoi)";
                        SqlCommand command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue("@MaKetQua", MaKetQua);
                        command.Parameters.AddWithValue("@MaCauHoi", dapAnDaChon.Key);
                        command.Parameters.AddWithValue("@MaCauTraLoi", dapAnDaChon.Value);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }



        //public bool LuuKetQua(KetQua ketQua)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = SqlConnectionData.Connect())
        //        {
        //            conn.Open();

        //            // Lệnh SQL để lưu kết quả vào bảng
        //            string query = "INSERT INTO KetQua (LanThi, KetQuaThi, MaThiSinh, ThoiGian) " +
        //                           "VALUES (@LanThi, @KetQuaThi, @MaThiSinh, @ThoiGian)";

        //            // Tạo đối tượng Command
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                // Thêm các tham số vào câu lệnh SQL
        //                cmd.Parameters.AddWithValue("@LanThi", ketQua.LanThi);
        //                cmd.Parameters.AddWithValue("@KetQuaThi", ketQua.KetQuaThi);
        //                cmd.Parameters.AddWithValue("@MaThiSinh", ketQua.MaThiSinh);
        //                cmd.Parameters.AddWithValue("@ThoiGian", ketQua.ThoiGian);

        //                // Thực thi lệnh SQL
        //                int rowsAffected = cmd.ExecuteNonQuery();

        //                // Kiểm tra số dòng bị ảnh hưởng để biết thành công hay không
        //                return rowsAffected > 0;


        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log lỗi (nếu cần thiết)
        //        Console.WriteLine($"Error: {ex.Message}");

        //        // Trả về false nếu có lỗi xảy ra
        //        return false;
        //    }
        //}

        public int GetLanThi(int maThiSinh)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MAX(LanThi) FROM KetQua WHERE MaThiSinh = @MaThiSinh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                        var result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }


    }
}
