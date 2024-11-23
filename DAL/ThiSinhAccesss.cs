using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThiSinhAccesss : DatabaseAccess
    {
        public bool addThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
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
    }
}
