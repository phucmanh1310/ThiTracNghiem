using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class KetQuaBLL
    {
        private KetQuaAccess ketQuaDAL;

        public KetQuaBLL()
        {
            ketQuaDAL = new KetQuaAccess();
        }

        public List<KetQua> LayKetQuaChiTiet(int maThiSinh)
        {
            // Nếu cần xử lý thêm logic, thực hiện ở đây
            return ketQuaDAL.getKetQuaThi(maThiSinh);
        }

        public bool LuuKetQua(KetQua ketQua)
        {
            return ketQuaDAL.LuuKetQua(ketQua);
        }

        public int GetLanThi(int maThiSinh)
        {
            return ketQuaDAL.GetLanThi(maThiSinh);
        }
    }
}
