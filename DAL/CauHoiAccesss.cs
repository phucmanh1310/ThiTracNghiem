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
        public List<CauHoi> GetCauHoi() {  
            List<CauHoi> listCauHoi = new List<CauHoi>();

            string query = "SELECT * FROM CauHoi";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) { 
                    CauHoi cauHoi = new CauHoi(
                            reader["MaCauHoi"].ToString(),
                            reader["NDCauHoi"].ToString(),
                            Convert.ToInt16(reader["MaPhan"]),
                            reader["HinhAnh"].ToString()
                        );

                    listCauHoi.Add( cauHoi );
                }
                reader.Close();
            }
            return listCauHoi;
        }

    }
}
