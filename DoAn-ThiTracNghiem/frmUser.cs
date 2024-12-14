using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_ThiTracNghiem
{
    public partial class frmUser : Form
    {
        private string username;

        public frmUser(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void picExamination_Click(object sender, EventArgs e)
        {
            frmExamination examination = new frmExamination(username);
            this.Hide();
            examination.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInformationAndHistory frm = new frmInformationAndHistory(username);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát quyền admin ?! ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}