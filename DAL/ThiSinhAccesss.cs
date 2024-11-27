using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DTO;

namespace DAL
{
    public class ThiSinhAccesss : DatabaseAccess
    {
        public int addThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
        {
            // Gọi phương thức AddThiSinh với cả hai tham số
            return DatabaseAccess.AddThiSinh(thiSinh, taiKhoan);
        }
        //lấy danh sách thí sinh
        public List<ThiSinh> GetAllThiSinh()
        {
            List<ThiSinh> list = new List<ThiSinh>();
            string query = "SELECT MaThiSinh, HoTenThiSinh, NgaySinh, GioiTinh, DiaChi, username FROM ThiSinh";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ThiSinh thiSinh = new ThiSinh
                    {
                        MaThiSinh = int.Parse(reader["MaThiSinh"].ToString()),
                        HoTenThiSinh = reader["HoTenThiSinh"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = Convert.ToChar(reader["GioiTinh"]),
                        DiaChi = reader["DiaChi"].ToString(),
                        Username = reader["Username"].ToString(),

                    };
                    list.Add(thiSinh);

                }

                conn.Close();
            }
            return list;
        }
        //-------------------------------
        public List<ThiSinh> TraCuuThiSinh(String hoTenThiSinh)
        {
            List<ThiSinh> List = new List<ThiSinh>();
            string query = "SELECT MaThiSinh, HoTenThiSinh, NgaySinh, GioiTinh, DiaChi, username " +
                  "FROM ThiSinh WHERE LOWER(HoTenThiSinh) LIKE LOWER(@hoTenThiSinh)";// hàm like cho phép tìm gần đúng 
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);            
                cmd.Parameters.AddWithValue("@hoTenThiSinh", $"%{hoTenThiSinh}%"); // Tìm kiếm theo chuỗi nhập dùng %kytu%                                                                                  
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ThiSinh thiSinh = new ThiSinh
                    {
                        MaThiSinh = int.Parse(reader["MaThiSinh"].ToString()),
                        HoTenThiSinh = reader["HoTenThiSinh"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = Convert.ToChar(reader["GioiTinh"]),
                        DiaChi = reader["DiaChi"].ToString(),
                        Username = reader["Username"].ToString(),

                    };
                    List.Add(thiSinh);
                }
            }
            return List;
        }
        //----------------------------
        public bool DeleteThiSinh(int maThiSinh)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Lấy username từ bảng ThiSinh
                    string getUsernameQuery = "SELECT username FROM ThiSinh WHERE MaThiSinh = @maThiSinh";
                    SqlCommand getUsernameCmd = new SqlCommand(getUsernameQuery, conn, transaction);
                    getUsernameCmd.Parameters.AddWithValue("@maThiSinh", maThiSinh);
                    string username = (string)getUsernameCmd.ExecuteScalar();

                    // Xóa thí sinh
                    string deleteThiSinhQuery = "DELETE FROM ThiSinh WHERE MaThiSinh = @maThiSinh";
                    SqlCommand deleteThiSinhCmd = new SqlCommand(deleteThiSinhQuery, conn, transaction);
                    deleteThiSinhCmd.Parameters.AddWithValue("@maThiSinh", maThiSinh);
                    deleteThiSinhCmd.ExecuteNonQuery();

                    // Xóa tài khoản
                    if (!string.IsNullOrEmpty(username))
                    {
                        string deleteTaiKhoanQuery = "DELETE FROM TaiKhoan WHERE username = @username";
                        SqlCommand deleteTaiKhoanCmd = new SqlCommand(deleteTaiKhoanQuery, conn, transaction);
                        deleteTaiKhoanCmd.Parameters.AddWithValue("@username", username);
                        deleteTaiKhoanCmd.ExecuteNonQuery();
                    }

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
        //---cập nhật thí sinh và tài khoản thí sinh --------
        public bool UpdateThiSinhAndAccount(int maThiSinh, string hoTen, DateTime ngaySinh, char gioiTinh, string diaChi, string username, string password)
        {
            try
            {
                // Cập nhật thông tin trong bảng TaiKhoan
                string updateTaiKhoanQuery = "UPDATE TaiKhoan SET Password = @Password WHERE Username = @Username";
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    SqlCommand cmd = new SqlCommand(updateTaiKhoanQuery, conn);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Cập nhật thông tin trong bảng ThiSinh
                string updateThiSinhQuery = "UPDATE ThiSinh SET HoTenThiSinh = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi WHERE MaThiSinh = @MaThiSinh";
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    SqlCommand cmd = new SqlCommand(updateThiSinhQuery, conn);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có bản ghi bị thay đổi
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin thí sinh và tài khoản: " + ex.Message);
            }
        }



    }
}
