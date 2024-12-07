using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DoAn_ThiTracNghiem
{
    public partial class FormChiTietKetQua : Form
    {
        private int CauHoiHienTai = 0;
        CauHoiBLL chBLL = new CauHoiBLL();
        private List<CauHoi> listCauHoi;
        ChiTietKetQuaBLL ctkqBLL = new ChiTietKetQuaBLL();
        private List<ChiTietKetQua> listChiTiet;


        public FormChiTietKetQua(int maKetQua)
        {
            //InitializeComponent();
            //listChiTiet = ctkqBLL.GetChiTietKetQua(maKetQua);
            //listCauHoi = chBLL.GetCauHoiChiTietById(maCauHoi);

            //HienThiCauHoi();
        }

        private void FormChiTietKetQua_Load(object sender, EventArgs e)
        {
            var cauHoiHienTai = listChiTiet;
        }

        
    }
}
