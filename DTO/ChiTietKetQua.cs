using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKetQua
    {
        public int MaChiTietKetQua { get; set; } // ID duy nhất cho mỗi chi tiết kết quả
        public int MaKetQua { get; set; } // ID của kết quả (FK)
        public int MaCauHoi { get; set; } // ID của câu hỏi (FK)
        public int? MaCauTraLoi { get; set; } // ID của đáp án đã chọn (FK)
    }
}
