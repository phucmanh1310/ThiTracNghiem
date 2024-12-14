using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DapAnAccesss : DatabaseAccess
    {
        public List<DapAn> GetDapAn(int maCauHoi)
        {
            List<DapAn> danhSachDapAn = new List<DapAn>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM DapAn WHERE MaCauHoi = @MaCauHoi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DapAn dapAn = new DapAn(
                            int.Parse(reader["MaCauTraLoi"].ToString()),
                            reader["NDCauTraLoi"].ToString(),
                            int.Parse(reader["MaCauHoi"].ToString()),
                            bool.Parse(reader["DungSai"].ToString())
                        );
                        danhSachDapAn.Add(dapAn);
                    }
                }
            }
            return danhSachDapAn;
        }

        public bool IsCorrectAnswer(int maCauHoi, int maCauTraLoi)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();

                    // Truy vấn kiểm tra đáp án
                    string query = "SELECT DungSai FROM DapAn WHERE MaCauHoi = @MaCauHoi AND MaCauTraLoi = @MaCauTraLoi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);
                        cmd.Parameters.AddWithValue("@MaCauTraLoi", maCauTraLoi);

                        var result = cmd.ExecuteScalar();
                        return result != null && Convert.ToBoolean(result); // Trả về true nếu đúng
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false; // Trả về false nếu xảy ra lỗi
                }
            }
        }

        public int? GetCauTraLoiByCauHoi(int maCauHoi, int maKetQua)
        {
            int? result = null; // Giá trị mặc định nếu không tìm thấy hoặc kết quả là null
            string query = "SELECT MaCauTraLoi FROM ChiTietKetQua WHERE MaCauHoi = @maCauHoi AND MaKetQua = @maKetQua";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số @maCauHoi và @maKetQua
                    cmd.Parameters.Add("@maCauHoi", SqlDbType.Int).Value = maCauHoi;
                    cmd.Parameters.Add("@maKetQua", SqlDbType.Int).Value = maKetQua;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Kiểm tra xem cột đầu tiên có phải là NULL hay không
                            if (!reader.IsDBNull(0))
                            {
                                result = reader.GetInt32(0); // Lấy giá trị MaCauTraLoi
                            }
                        }
                    }
                }
            }
            return result;
        }


    }
}