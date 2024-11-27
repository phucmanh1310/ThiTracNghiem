using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            // Lấy chuỗi kết nối từ app.config
            string connectionString = ConfigurationManager.ConnectionStrings["ThiTracNghiemConnectionString"].ConnectionString;

            // Tạo đối tượng kết nối
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }

    public class DatabaseAccess
    {
        public static (bool isValid, bool isAdmin, string username) CheckLogin(TaiKhoan taikhoan)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Username, IsAdmin FROM TaiKhoan WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", taikhoan.Username);
                    cmd.Parameters.AddWithValue("@Password", taikhoan.Password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string username = reader.GetString(0);
                                bool isAdmin = reader.GetBoolean(1); // Đúng vị trí IsAdmin
                                return (true, isAdmin, username);    // Trả về thông tin đăng nhập
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
            return (false, false, null); // Không tìm thấy tài khoản
        }

        public static int AddThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlTransaction transaction = null; // Tạo transaction để đảm bảo tính toàn vẹn dữ liệu
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // 1. Thêm tài khoản vào bảng TaiKhoan
                    string queryTaiKhoan = @"
            INSERT INTO TaiKhoan (Username, Password, IsAdmin)
            VALUES (@Username, @Password, @IsAdmin)";
                    SqlCommand cmdTaiKhoan = new SqlCommand(queryTaiKhoan, conn, transaction);
                    cmdTaiKhoan.Parameters.AddWithValue("@Username", taiKhoan.Username);
                    cmdTaiKhoan.Parameters.AddWithValue("@Password", taiKhoan.Password);
                    cmdTaiKhoan.Parameters.AddWithValue("@IsAdmin", taiKhoan.IsAdmin);
                    cmdTaiKhoan.ExecuteNonQuery();

                    // 2. Thêm thông tin thí sinh vào bảng ThiSinh
                    string queryThiSinh = @"
            INSERT INTO ThiSinh (HoTenThiSinh, NgaySinh, GioiTinh, DiaChi, Username)
            VALUES (@HoTenThiSinh, @NgaySinh, @GioiTinh, @DiaChi, @Username);
            SELECT SCOPE_IDENTITY();"; // Lấy ID tự động tạo ra

                    SqlCommand cmdThiSinh = new SqlCommand(queryThiSinh, conn, transaction);
                    cmdThiSinh.Parameters.AddWithValue("@HoTenThiSinh", thiSinh.HoTenThiSinh);
                    cmdThiSinh.Parameters.AddWithValue("@NgaySinh", thiSinh.NgaySinh.ToString("yyyy-MM-dd"));
                    cmdThiSinh.Parameters.AddWithValue("@GioiTinh", thiSinh.GioiTinh);
                    cmdThiSinh.Parameters.AddWithValue("@DiaChi", thiSinh.DiaChi);
                    cmdThiSinh.Parameters.AddWithValue("@Username", taiKhoan.Username);

                    // Commit transaction
                    transaction.Commit();
                    object result = cmdThiSinh.ExecuteScalar(); // Lấy ID tự động tạo
                    return result != null ? Convert.ToInt32(result) : -1;

                }
                catch (Exception ex)
                {
                    transaction?.Rollback(); // Rollback nếu có lỗi
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    return -1;
                }
            }
        }




    }
}
