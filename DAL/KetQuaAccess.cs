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
            String query = "SELECT MaKetQua,ThoiGian, LanThi, KetQuaThi FROM KetQua WHERE MaThiSinh = @MaThiSinh";
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
                            MaKetQua = reader.GetInt32("MaKetQua"),
                            ThoiGian = reader.GetInt32("ThoiGian"),
                            LanThi = reader.GetInt32("LanThi"),
                            KetQuaThi = reader.GetString("KetQuaThi")
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

        public bool LuuKetQua(KetQua ketQua, Dictionary<int, int?> DapAnDaChon)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();

                    // Kiểm tra câu điểm liệt (Mã phần 6)
                    bool isDiemLiệtSai = false;
                    int? dapAnDiemLiet = DapAnDaChon.FirstOrDefault(x => x.Key == 6).Value;

                    if (dapAnDiemLiet.HasValue)
                    {
                        // Kiểm tra đáp án của câu điểm liệt (Câu điểm liệt có DungSai = 1 là đáp án đúng)
                        DapAnAccesss dapAnAccess = new DapAnAccesss();
                        bool isCorrect = dapAnAccess.IsCorrectAnswer(6, dapAnDiemLiet.Value);

                        if (!isCorrect)
                        {
                            isDiemLiệtSai = true; // Nếu sai câu điểm liệt, đánh dấu kết quả là không đạt
                        }
                    }

                    // Nếu câu điểm liệt sai, cập nhật kết quả thi là "không đạt"
                    string ketQuaThi = isDiemLiệtSai ? "Không đạt" : ketQua.KetQuaThi;

                    // Lệnh SQL để lưu kết quả vào bảng KetQua
                    string query = @"
                               INSERT INTO KetQua (LanThi, KetQuaThi, MaThiSinh, ThoiGian)
                               OUTPUT INSERTED.MaKetQua
                               VALUES (@LanThi, @KetQuaThi, @MaThiSinh, @ThoiGian)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LanThi", ketQua.LanThi);
                    cmd.Parameters.AddWithValue("@KetQuaThi", ketQuaThi); // Nếu câu điểm liệt sai, kết quả là "Không đạt"
                    cmd.Parameters.AddWithValue("@MaThiSinh", ketQua.MaThiSinh);
                    cmd.Parameters.AddWithValue("@ThoiGian", ketQua.ThoiGian);

                    int maKetQua = (int)cmd.ExecuteScalar();

                    foreach (var dapan in DapAnDaChon)
                    {
                        string insert = "INSERT INTO ChiTietKetQua(MaKetQua, MaCauHoi, MaCauTraLoi) VALUES (@MaKetQua, @MaCauHoi, @MaCauTraLoi)";
                        SqlCommand command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue("@MaKetQua", maKetQua);
                        command.Parameters.AddWithValue("@MaCauHoi", dapan.Key);
                        command.Parameters.AddWithValue("@MaCauTraLoi", dapan.Value ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }




        public int GetLanThi(int maThiSinh)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MAX(LanThi) FROM KetQua WHERE MaThiSinh = @MaThiSinh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThiSinh", maThiSinh);
                        var result = cmd.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }


    }
}
