using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThiSinhBLL
    {
        ThiSinhAccesss thiSinhAccess = new ThiSinhAccesss();

        public bool AddThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(thiSinh.HoTenThiSinh) || string.IsNullOrWhiteSpace(taiKhoan.Username))
            {
                throw new Exception("Thông tin không được để trống!");
            }

            // Gọi phương thức addThiSinh từ DAL
            return thiSinhAccess.addThiSinh(thiSinh, taiKhoan);
        }
    }
}
