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
        public List<DapAn> GetDapAn(int maCauHoi)
        {
            return daAccesss.GetDapAn(maCauHoi);
        }

        public bool IsCorrectAnswer(int maCauHoi, int maCauTraLoi)
        {
            return daAccesss.IsCorrectAnswer(maCauHoi, maCauTraLoi);
        }

        public int? GetCauTraLoiByCauHoi(int maCauHoi, int maKetQua)
        {
            return daAccesss.GetCauTraLoiByCauHoi(maCauHoi, maKetQua);
        }
    }
}