using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
                                MaChiTietKetQua = reader.GetInt32("MaChiTietKetQua"),
                                MaCauHoi = reader.GetInt32("MaCauHoi"),
                                MaCauTraLoi = reader.IsDBNull("MaCauTraLoi") ? (int?)null : reader.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return chiTietKetQuas;
        }

    }
}
