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

        public CauHoi() { } // Constructor mặc định

        public CauHoi(int maCauHoi, string ndCauHoi, short maPhan, string hinhAnh = null)
        {
            MaCauHoi = maCauHoi;
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
        }

        public CauHoi(string ndCauHoi, short maPhan, string hinhAnh = null)
        {
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
        }

        public CauHoi(string ndCauHoi, string hinhAnh = null)
        {
            NDCauHoi = ndCauHoi;
            HinhAnh = hinhAnh;
        }
    }

}