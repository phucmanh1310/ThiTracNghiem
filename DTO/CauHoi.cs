using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoi
    {
        public int MaCauHoi { get; set; }
        public string NDCauHoi { get; set; }
        public short MaPhan { get; set; }
        public string? HinhAnh { get; set; } // Giá trị có thể null
        public List<DapAn> dapAns { get; set; } = new List<DapAn>();
        public bool IsAnswered { get; set; } // Thêm thuộc tính trạng thái câu hỏi đã trả lời hay chưa

        // Constructor giữ nguyên
        public CauHoi(int maCauHoi, string ndCauHoi, short maPhan, string hinhAnh = null)
        {
            MaCauHoi = maCauHoi;
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
            IsAnswered = false; // Mặc định câu hỏi chưa được trả lời
        }

        public CauHoi(string ndCauHoi, short maPhan, string hinhAnh = null)
        {
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
            IsAnswered = false; // Mặc định câu hỏi chưa được trả lời
        }

        public CauHoi(string ndCauHoi, string hinhAnh = null)
        {
            NDCauHoi = ndCauHoi;
            HinhAnh = hinhAnh;
            IsAnswered = false; // Mặc định câu hỏi chưa được trả lời
        }

    }


}