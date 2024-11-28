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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_ThiTracNghiem
{
    public partial class frmExamination : Form
    {
        private int timeleft;
        private string username;
        ThiSinhBLL thiSinhBBL = new ThiSinhBLL();
        CauHoiBBL cauHoiBBL = new CauHoiBBL();
        DapAnBBL dapAnBBL = new DapAnBBL();
        private int cauHoiHienTai = 0;



        public frmExamination(string username)
        {
            InitializeComponent();
            this.username = username;
            HienThiCauHoi();
        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            timeleft = 15 * 60;
            lableTime.Text = FormatTime(timeleft);
            timer1.Start();

            ThiSinh thiSinh = thiSinhBBL.GetThiSinh(username);
            txtMaSo.Text = thiSinh.MaThiSinh.ToString();
            txtHoTen.Text = thiSinh.HoTenThiSinh;




        }

        private void HienThiCauHoi()
        {
            List<CauHoi> listCauHoi = cauHoiBBL.GetCauHoi();
            if (listCauHoi.Count == 0) return;

            CauHoi cauHoi = listCauHoi[cauHoiHienTai];
            lbCauHoi.Text = $"Câu {cauHoiHienTai + 1}: {cauHoi.NDCauHoi}";
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                lableTime.Text = FormatTime(timeleft);
            }
            else
            {
                timer1.Stop();
            }
        }

        private string FormatTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            return $"{minutes:D2}:{remainingSeconds:D2}";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            cauHoiHienTai--;
            HienThiCauHoi();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cauHoiHienTai++;
            HienThiCauHoi();
        }
    }
}
