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
                            reader["MaCauHoi"].ToString(),
                            bool.Parse(reader["DungSai"].ToString())
                        );
                        danhSachDapAn.Add(dapAn);
                    }
                }
            }
            return danhSachDapAn;
        }
    }
}