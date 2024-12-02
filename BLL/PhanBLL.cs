using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhanBLL
    {
        PhanDAL phanDAL = new PhanDAL();
        public List<Phan> GetAllLoaiCauHoi()
        {
            return phanDAL.GetAllLoaiCauHoi();
        }

        // Thêm loại câu hỏi
        public bool AddLoaiCauHoi(string tenLoaiCauHoi)
        {
            if (string.IsNullOrWhiteSpace(tenLoaiCauHoi))
                throw new ArgumentException("Tên loại câu hỏi không được để trống.");

            return phanDAL.AddLoaiCauHoi(tenLoaiCauHoi);
        }
    }
}
