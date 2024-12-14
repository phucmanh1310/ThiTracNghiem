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
            string query = "SELECT MaKetQua, ThoiGian, LanThi, KetQuaThi, TrangThai FROM KetQua WHERE MaThiSinh = @MaThiSinh";

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
                            MaKetQua = reader.GetInt32(reader.GetOrdinal("MaKetQua")),
                            ThoiGian = reader.GetInt32(reader.GetOrdinal("ThoiGian")),
                            LanThi = reader.GetInt32(reader.GetOrdinal("LanThi")),
                            KetQuaThi = reader.GetString(reader.GetOrdinal("KetQuaThi")),
                            TrangThai = reader.GetString(reader.GetOrdinal("TrangThai")) // Trạng thái đạt/không đạt
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
                    bool isDiemLietSai = false;
                    int soCauDung = 0; // Số câu đúng, bao gồm cả các câu không bị điểm liệt
                    int? dapAnDiemLiet = DapAnDaChon.FirstOrDefault(x => x.Key == 6).Value;

                    if (dapAnDiemLiet.HasValue)
                    {
                        // Kiểm tra đáp án của câu điểm liệt
                        DapAnAccesss dapAnAccess = new DapAnAccesss();
                        bool isCorrect = dapAnAccess.IsCorrectAnswer(6, dapAnDiemLiet.Value);

                        if (!isCorrect)
                        {
                            isDiemLietSai = true; // Sai câu điểm liệt
                        }
                    }

                    // Tính số câu đúng cho tất cả câu hỏi (bao gồm cả khi sai câu điểm liệt)
                    foreach (var dapan in DapAnDaChon)
                    {
                        bool dapAnDung = dapan.Value.HasValue && new DapAnAccesss().IsCorrectAnswer(dapan.Key, dapan.Value.Value);
                        if (dapAnDung)
                        {
                            soCauDung++;
                        }
                    }

                    // Xác định kết quả thi
                    string ketQuaThi = $"{soCauDung}/25"; // Lưu tổng số câu đúng
                    string trangThai = isDiemLietSai ? "Không đạt" : (soCauDung >= 21 ? "Đạt" : "Không đạt");

                    // Lệnh SQL để lưu kết quả vào bảng KetQua
                    string query = @"
                INSERT INTO KetQua (LanThi, KetQuaThi, MaThiSinh, ThoiGian, TrangThai)
                OUTPUT INSERTED.MaKetQua
                VALUES (@LanThi, @KetQuaThi, @MaThiSinh, @ThoiGian, @TrangThai)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LanThi", ketQua.LanThi);
                    cmd.Parameters.AddWithValue("@KetQuaThi", ketQuaThi); // Lưu số câu đúng
                    cmd.Parameters.AddWithValue("@MaThiSinh", ketQua.MaThiSinh);
                    cmd.Parameters.AddWithValue("@ThoiGian", ketQua.ThoiGian);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai); // Lưu trạng thái "Đạt" hoặc "Không đạt"

                    int maKetQua = (int)cmd.ExecuteScalar(); // Lấy mã kết quả vừa thêm

                    // Lưu chi tiết các đáp án
                    foreach (var dapan in DapAnDaChon)
                    {
                        string insert = "INSERT INTO ChiTietKetQua (MaKetQua, MaCauHoi, MaCauTraLoi) VALUES (@MaKetQua, @MaCauHoi, @MaCauTraLoi)";
                        SqlCommand command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue("@MaKetQua", maKetQua);
                        command.Parameters.AddWithValue("@MaCauHoi", dapan.Key);
                        command.Parameters.AddWithValue("@MaCauTraLoi", dapan.Value ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }

                    return trangThai == "Đạt"; // Trả về true nếu kết quả là "Đạt"
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi lưu kết quả: {ex.Message}"); // Log lỗi ra console
                    return false; // Lưu thất bại
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
