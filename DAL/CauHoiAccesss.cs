using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CauHoiAccesss : DatabaseAccess
    {
        public List<CauHoi> GetCauHoi()
        {
            List<CauHoi> danhSachCauHoi = new List<CauHoi>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT * FROM CauHoi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CauHoi cauHoi = new CauHoi(
                            reader["MaCauHoi"].ToString(),
                            reader["NDCauHoi"].ToString(),
                            short.Parse(reader["MaPhan"].ToString()),
                            reader["HinhAnh"] == DBNull.Value ? null : reader["HinhAnh"].ToString()
                        );
                        danhSachCauHoi.Add(cauHoi);
                    }
                }
            }
            return danhSachCauHoi;
        }

    }
}