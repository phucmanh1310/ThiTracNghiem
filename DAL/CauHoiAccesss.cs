﻿using System;
using System.Collections.Generic;
using System.Data;
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
        public int AddCauHoi(CauHoi cauHoi)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                // Câu lệnh SQL để thêm câu hỏi
                string query = "INSERT INTO CauHoi (NDCauHoi, MaPhan, HinhAnh) OUTPUT INSERTED.MaCauHoi VALUES (@NDCauHoi, @MaPhan, @HinhAnh)";
                SqlCommand command = new SqlCommand(query, connection);

                // Gán các tham số cho câu lệnh SQL
                command.Parameters.AddWithValue("@NDCauHoi", cauHoi.NDCauHoi);
                command.Parameters.AddWithValue("@MaPhan", cauHoi.MaPhan);

                // Xử lý HinhAnh là null hoặc đường dẫn
                if (string.IsNullOrEmpty(cauHoi.HinhAnh))
                {
                    command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    command.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = cauHoi.HinhAnh;
                }

                connection.Open();
                return (int)command.ExecuteScalar(); // Trả về mã câu hỏi vừa được thêm
            }
        }
        // Thêm đáp án vào cơ sở dữ liệu
        public void AddDapAn(DapAn dapAn)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                string query = "INSERT INTO DapAn (NDCauTraLoi, MaCauHoi, DungSai) VALUES (@NDCauTraLoi, @MaCauHoi, @DungSai)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NDCauTraLoi", dapAn.NDCauTraLoi);
                command.Parameters.AddWithValue("@MaCauHoi", dapAn.MaCauHoi);
                command.Parameters.AddWithValue("@DungSai", dapAn.DungSai);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        //Viết phương thức để lấy danh sách câu hỏi theo MaPhan:
        public List<Tuple<string, string, string>> GetCauHoiByMaPhan(int maPhan)
        {
            List<Tuple<string, string, string>> listCauHoi = new List<Tuple<string, string, string>>();

            string query = @"
                SELECT P.TenPhan, CH.NDCauHoi, DA.NDCauTraLoi AS DapAnDung
                FROM CauHoi CH
                JOIN Phan P ON CH.MaPhan = P.MaPhan
                JOIN DapAn DA ON CH.MaCauHoi = DA.MaCauHoi
                WHERE DA.DungSai = 1 AND P.MaPhan = @MaPhan";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhan", maPhan);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Đọc dữ liệu
                    String tenPhan = reader["TenPhan"].ToString(); // Đọc MaPhan là int
                    string ndCauHoi = reader["NDCauHoi"].ToString();
                    string dapAnDung = reader["DapAnDung"].ToString();

                    // Thêm vào danh sách tạm thời
                    listCauHoi.Add(new Tuple<string, string, string>(tenPhan, ndCauHoi, dapAnDung));
                }
                reader.Close();
            }

            return listCauHoi;
        }


    }
}