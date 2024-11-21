using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThiSinh
    {
        public int MaThiSinh { get; set; } // Public để BLL/DAL có thể gán giá trị sau
        public string HoTenThiSinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public char GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Username { get; set; }

        // Constructor mặc định
        public ThiSinh() { }

        // Constructor đầy đủ (nếu cần)
        public ThiSinh(int maThiSinh, string hoTenThiSinh, DateTime ngaySinh, char gioiTinh, string diaChi, string username)
        {
            MaThiSinh = maThiSinh;
            HoTenThiSinh = hoTenThiSinh;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            Username = username;
        }
    }
}
