using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class PhanDAL
    {
        public List<Phan> GetAllLoaiCauHoi()
        {
            List<Phan> loaiCauHoiList = new List<Phan>();
            string query = "SELECT MaPhan, TenPhan FROM Phan";  // Cần đảm bảo câu lệnh SQL đúng tên bảng và cột

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maPhan = Convert.ToInt32(reader["MaPhan"]);
                        string tenPhan = reader["TenPhan"].ToString();
                        loaiCauHoiList.Add(new Phan(maPhan, tenPhan));
                    }
                }
            }
            return loaiCauHoiList;
        }

        public bool AddLoaiCauHoi(string tenLoaiCauHoi)
        {
            string query = "INSERT INTO Phan (TenPhan) VALUES (@TenPhan)";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenPhan", tenLoaiCauHoi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
