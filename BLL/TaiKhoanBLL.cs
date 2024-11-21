using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public (bool isValid, bool isAdmin, string username) checkLogin(TaiKhoan taikhoan)
        {
            // Kiểm tra nghiệp vụ
            if (string.IsNullOrWhiteSpace(taikhoan.Username))
            {
                throw new Exception("Tên đăng nhập không được để trống");
            }
            if (string.IsNullOrWhiteSpace(taikhoan.Password))
            {
                throw new Exception("Mật khẩu không được để trống");
            }
            return tkAccess.checkLogin(taikhoan);
        }
        // Phương thức kiểm tra tính hợp lệ của tên đăng nhập
        public bool CheckUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Tên đăng nhập không được để trống!");
            }

            return !tkAccess.IsUsernameExist(username); // Hợp lệ nếu tên đăng nhập chưa tồn tại
        }

    }
}
