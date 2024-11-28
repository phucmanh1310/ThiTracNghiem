using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoi
    {
        public string MaCauHoi { get; set; } 
        public string NDCauHoi { get; set; }
        public short MaPhan { get; set; }
        public string? HinhAnh { get; set; } // Giá trị có thể null

        public CauHoi(string maCauHoi, string ndCauHoi, short maPhan, string hinhAnh = null)
        {
            MaCauHoi = maCauHoi;
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
        }

    }
}
