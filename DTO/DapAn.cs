﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DapAn
    {
        public int MaCauTraLoi { get; set; }
        public string NDCauTraLoi { get; set; }
        public string MaCauHoi { get; set; }
        public bool DungSai { get; set; }

        public DapAn(int maCauTraLoi, string ndCauTraLoi, string maCauHoi, bool dungSai)
        {
            MaCauTraLoi = maCauTraLoi;
            NDCauTraLoi = ndCauTraLoi;
            MaCauHoi = maCauHoi;
            DungSai = dungSai;
        }
    }
}