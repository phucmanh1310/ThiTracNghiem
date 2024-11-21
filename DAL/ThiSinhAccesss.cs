using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThiSinhAccesss : DatabaseAccess
    {
        public bool addThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
        {
            // Gọi phương thức AddThiSinh với cả hai tham số
            return DatabaseAccess.AddThiSinh(thiSinh, taiKhoan);
        }
    }
}
