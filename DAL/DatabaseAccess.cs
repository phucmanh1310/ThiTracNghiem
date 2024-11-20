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

    }
}
