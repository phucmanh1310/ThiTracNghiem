using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class KetQuaAccess : DatabaseAccess
    {
        public List<KetQua> getKetQuaThi(int maThiSinh)
        {
            List<KetQua> ketQuaList = new List<KetQua>();
            String query = "SELECT STT,ThoiGian, LanThi, KetQua FROM KetQua WHERE MaThiSinh = @MaThiSinh";
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {                 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        KetQua ketqua = new KetQua
                        {
                            STT = reader.GetInt32(0),
                            ThoiGian = reader.GetInt32(1),  // ThoiGian là cột đầu tiên trong query
                            LanThi = reader.GetInt32(2),       // LanThi là cột thứ hai
                            KetQuaThi = reader.GetString(3)     // KetQua là cột thứ ba
                        };
                        ketQuaList.Add(ketqua);
                    }
                    return ketQuaList;
                }
                catch (Exception ex)
                {
                    throw new Exception("Không tìm thấy kết quả thi của thí sinh: " + ex.Message);
                }
            }
        }
    }
}
