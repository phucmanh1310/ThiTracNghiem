using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DapAnAccesss : DatabaseAccess
    {
        public List<DapAn> GetDapAn(string maCauHoi)
        {
            List<DapAn> ListDapAn = new List<DapAn>();

            string query = "SELECT * FROM DapAn WHERE MaCauHoi = @MaCauHoi";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaCauHoi", maCauHoi);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DapAn dapAn = new DapAn(
                        Convert.ToInt32(reader["MaCauTraLoi"]),
                        reader["NDCauTraLoi"].ToString(),
                        reader["MaCauHoi"].ToString(),
                        Convert.ToBoolean(reader["DungSai"])
                    );
                    ListDapAn.Add(dapAn);
                }

                reader.Close();
            }

            return ListDapAn;
        }
    }
}
