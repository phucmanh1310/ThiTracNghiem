using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TienTrinhBLL
    {
        TienTrinhAccess tienTrinhAccess = new TienTrinhAccess();

        public void LuuTienTrinh(TienTrinh tienTrinh)
        {
            tienTrinhAccess.LuuTienTrinh(tienTrinh);
        }

        public TienTrinh GetTienTrinh(int maThiSinh)
        {
            return tienTrinhAccess.GetTienTrinh(maThiSinh);
        }

        public void XoaTienTrinh(int maThiSinh)
        {
            tienTrinhAccess.XoaTienTrinh(maThiSinh);
        }

        public List<int> LayDanhSachMaCauHoi(int maThiSinh)
        {
            return tienTrinhAccess.LayDanhSachMaCauHoi(maThiSinh);
        }
    }
}
