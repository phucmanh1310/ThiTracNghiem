using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienTrinh
    {
        public int MaThiSinh { get; set; }

        public string DapAnDC { get; set; }  // Đáp án đã chọn dưới dạng JSON
        public int ThoiGianConLai { get; set; }  // Thời gian còn lại (tính bằng giây)
        
    }
}
