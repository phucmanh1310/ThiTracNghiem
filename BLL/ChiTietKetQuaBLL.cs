using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietKetQuaBLL
    {
        ChiTietKetQuaAccesss ctkqAccesss = new ChiTietKetQuaAccesss();

        public List<ChiTietKetQua> GetChiTietKetQua(int maKetQua)
        {
            return ctkqAccesss.GetChiTietKetQua(maKetQua);
        }
    }
}
