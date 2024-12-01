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
    public partial class frmInformationAndHistory : Form
    {
        private string username;
        TaiKhoanBLL tkBBL = new TaiKhoanBLL();
        ThiSinhBLL tsBBL = new ThiSinhBLL();


        public frmInformationAndHistory(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }

        private void frmInformationAndHistory_Load(object sender, EventArgs e)
        {
            radioNam.Visible = false;
            radioNu.Visible = false;    
            dtpNgaySinh.Visible = false;

            ThiSinh thiSinh = tsBBL.GetThiSinh(username);
            txtMaSo.Text = thiSinh.MaThiSinh.ToString();
            txtHoTen.Text = thiSinh.HoTenThiSinh ?? ""; // Tránh lỗi nếu HoTenThiSinh là null
            txtDiaChi.Text = thiSinh.DiaChi ?? ""; // Tránh lỗi nếu DiaChi là null
            txtGioiTinh.Text = thiSinh.GioiTinh.ToString() == "M" ? "Nam" : "Nữ";
            txtNgaySinh.Text = thiSinh.NgaySinh.ToString("dd/MM/yyyy");


        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
