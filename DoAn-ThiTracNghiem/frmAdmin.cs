using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void picThemCauHoi_Click(object sender, EventArgs e)
        {
            frmAddQuestion frm = new frmAddQuestion();
            frm.ShowDialog();
        }

        private void picThongTinThiSinh_Click(object sender, EventArgs e)
        {
            frmAllInformation frm = new frmAllInformation();
            frm.ShowDialog();
        
        }
    }
}
