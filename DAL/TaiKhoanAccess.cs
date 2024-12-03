using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess :DatabaseAccess
    {
        public (bool isValid, bool isAdmin, string username) checkLogin(TaiKhoan taikhoan)
        {
            return DatabaseAccess.CheckLogin(taikhoan);
        }
        // Phương thức kiểm tra tên đăng nhập
        public bool IsUsernameExist(string username)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = (int)cmd.ExecuteScalar(); // Trả về số lượng username
                    return count > 0; // Nếu > 0, username đã tồn tại
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                    throw;
                }
            }
        }

        public bool KiemTraMatKhau(string username, string password)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open ();
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                
                int result = (int)cmd.ExecuteScalar();
                return result > 0;
            }
        }

        public bool CapNhatMatKhau(string username, string newPassword)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "UPDATE TaiKhoan SET Password = @NewPassword WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
