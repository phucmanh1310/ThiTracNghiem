using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;

namespace DAL
{
    public class TienTrinhAccess : DatabaseAccess
    {
        public void LuuTienTrinh(TienTrinh tienTrinh)
        {
            string query = "INSERT INTO TienTrinh (MaThiSinh, DapAnDC, ThoiGianConLai)" +
                           " VALUES (@MaThiSinh, @DapAnDC, @ThoiGianConLai)";

            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThiSinh", tienTrinh.MaThiSinh);
                        cmd.Parameters.AddWithValue("@DapAnDC", tienTrinh.DapAnDC);
                        cmd.Parameters.AddWithValue("@ThoiGianConLai", tienTrinh.ThoiGianConLai);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi và xử lý tùy ý, ví dụ:
                Console.WriteLine($"Lỗi khi lưu tiến trình: {ex.Message}");
                throw; // Ném lỗi ra ngoài nếu cần
            }
        }

        public TienTrinh GetTienTrinh(int maThiSinh)
        {
            string query = "SELECT MaThiSinh, DapAnDC, ThoiGianConLai FROM TienTrinh WHERE MaThiSinh = @MaThiSinh";

            TienTrinh tienTrinh = null;

            try
            {
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Kiểm tra nếu có dòng dữ liệu trả về
                            {
                                tienTrinh = new TienTrinh
                                {
                                    MaThiSinh = reader.GetInt32(reader.GetOrdinal("MaThiSinh")),
                                    DapAnDC = reader.GetString(reader.GetOrdinal("DapAnDC")),
                                    ThoiGianConLai = reader.GetInt32(reader.GetOrdinal("ThoiGianConLai"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi và xử lý tùy ý, ví dụ:
                Console.WriteLine($"Lỗi khi lấy tiến trình: {ex.Message}");
                throw; // Ném lỗi ra ngoài nếu cần
            }

            return tienTrinh;
        }

        public void XoaTienTrinh(int maThiSinh)
        {
            string query = "DELETE FROM TienTrinh WHERE MaThiSinh = @MaThiSinh";

            try
            {
                // Kết nối và thực thi lệnh xóa
                using (SqlConnection conn = SqlConnectionData.Connect())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                        cmd.ExecuteNonQuery(); // Thực thi lệnh xóa
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi và xử lý tùy ý
                Console.WriteLine($"Lỗi khi xóa tiến trình: {ex.Message}");
                throw; // Ném lỗi ra ngoài nếu cần
            }
        }

    }
}
