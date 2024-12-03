using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKetQua
    {
        public int MaKetQua { get; set; }        // Mã kết quả
        public string MaCauHoi { get; set; }    // Mã câu hỏi (nchar(3))
        public int? MaCauTraLoi { get; set; }   // Mã câu trả lời (nullable)
        
        public ChiTietKetQua(int maKetQua, string maCauHoi, int? maCauTraLoi, int thoiGianConLai, int maThiSinh, bool trangThai)
        {
            MaKetQua = maKetQua;
            MaCauHoi = maCauHoi;
            MaCauTraLoi = maCauTraLoi;
        }
    }
}
