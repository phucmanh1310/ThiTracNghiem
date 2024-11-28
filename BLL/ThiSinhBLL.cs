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

        public int AddThiSinh(ThiSinh thiSinh, TaiKhoan taiKhoan)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(thiSinh.HoTenThiSinh) || string.IsNullOrWhiteSpace(taiKhoan.Username))
            {
                throw new Exception("Thông tin không được để trống!");
            }

            // Gọi phương thức addThiSinh từ DAL
            return thiSinhAccess.addThiSinh(thiSinh, taiKhoan);
        }
        // Lấy tất cả thí sinh
        public List<ThiSinh> GetAllThiSinh()
        {

            return thiSinhAccess.GetAllThiSinh();
        }
        //lấy họ tên thí sinh
        public String GetHoTenTS(int maThiSinh)
        {
            return thiSinhAccess.GetHoTenThiSinh(maThiSinh);
        }
        public List<ThiSinh> TraCuuThiSinh(String thisinh)
        {
            return thiSinhAccess.TraCuuThiSinh(thisinh);
        }
        public bool DeleteThiSinh (int mathisinh)
        {
            return thiSinhAccess.DeleteThiSinh(mathisinh);        
        }
        public bool UpdateThiSinhAndAccount(int maThiSinh, string hoTenMoi, DateTime ngaySinhMoi, char gioiTinhMoi, string diaChiMoi, string usernameMoi, String passwordMoi)
        {
            return thiSinhAccess.UpdateThiSinhAndAccount(maThiSinh,hoTenMoi, ngaySinhMoi,gioiTinhMoi, diaChiMoi, usernameMoi, passwordMoi);
        }
        public ThiSinh GetThiSinh(string username)
        {
            return thiSinhAccess.GetThiSinh(username);
        }
    }
}
