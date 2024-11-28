using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CauHoiBBL
    {
        CauHoiAccesss chAccess = new CauHoiAccesss();

        public List<CauHoi> GetCauHoi() { 
            return chAccess.GetCauHoi();
        }


    }
}
