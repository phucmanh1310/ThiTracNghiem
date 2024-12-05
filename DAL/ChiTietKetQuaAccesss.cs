using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietKetQuaAccesss
    {
        public List<ChiTietKetQua> GetChiTietKetQua(int maKetQua)
        {
            var chiTietKetQuas = new List<ChiTietKetQua>();

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM ChiTietKetQua WHERE MaKetQua = @MaKetQua";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKetQua", maKetQua);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chiTietKetQuas.Add(new ChiTietKetQua
                            {
                                MaChiTietKetQua = reader.GetInt32(0),
                                MaKetQua = reader.GetInt32(1),
                                MaCauHoi = reader.GetInt32(2),
                                MaCauTraLoi = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return chiTietKetQuas;
        }
    }
}
