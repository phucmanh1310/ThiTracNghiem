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
        public Byte[]? HinhAnh { get; set; } // Giá trị có thể null

        public CauHoi(string maCauHoi, string ndCauHoi, short maPhan, Byte[] hinhAnh)
        {
            MaCauHoi = maCauHoi;
            NDCauHoi = ndCauHoi;
            MaPhan = maPhan;
            HinhAnh = hinhAnh;
        }
        public CauHoi(int maPhanDB,String ndCauHoi,String dapAnDung)
        {
            
        }

    }
}