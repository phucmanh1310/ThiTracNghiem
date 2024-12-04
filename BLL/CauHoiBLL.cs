﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CauHoiBLL
    {
        CauHoiAccesss chAccess = new CauHoiAccesss();

        // Lấy danh sách câu hỏi
        public List<CauHoi> GetCauHoi()
        {
            return chAccess.GetCauHoi();
        }
        // Thêm câu hỏi và đáp án
        public void AddQuestionAndAnswers(CauHoi cauHoi, List<DapAn> dapAns)
        {
            int maCauHoi = chAccess.AddCauHoi(cauHoi);

            foreach (var dapAn in dapAns)
            {
                dapAn.MaCauHoi = maCauHoi.ToString();
                chAccess.AddDapAn(dapAn);
            }
        }
        public List<Tuple<string,int, string, string>> GetCauHoiByMaPhan(int maPhan)
        {
            return chAccess.GetCauHoiByMaPhan(maPhan);
        }
        public CauHoi GetCauHoiChiTietById(int maCauHoi)
        {
            return chAccess.GetCauHoiChiTietById(maCauHoi);
        }
    }

}