using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess :DatabaseAccess
    {
        public (bool isValid, bool isAdmin, string username) checkLogin(TaiKhoan taikhoan)
        {
            return DatabaseAccess.CheckLogin(taikhoan);
        }

    }
}
