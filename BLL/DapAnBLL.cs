using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DapAnBBL
    {
        DapAnAccesss daAccesss = new DapAnAccesss();
        public List<DapAn> GetDapAn(string maCauHoi)
        {
            return daAccesss.GetDapAn(maCauHoi);
        }
    }
}