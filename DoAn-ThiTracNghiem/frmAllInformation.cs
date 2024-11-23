using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;
using System.Data.SqlClient;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAllInformation : Form
    {
        public frmAllInformation()
        {
            InitializeComponent();
        }

        private void frmAllInformation_Load(object sender, EventArgs e)
        {
            ShowAllInformation();
        }
        private void ShowAllInformation()
        {
            lvInformation.Columns.Clear();
            // Add columns to the ListView
            lvInformation.Columns.Add("Mã Thí Sinh", 100);
            lvInformation.Columns.Add("Họ và Tên", 250);
            lvInformation.Columns.Add("Ngày Sinh", 200);
            lvInformation.Columns.Add("Giới Tính", 100);
            lvInformation.Columns.Add("Địa Chỉ", 200);
            lvInformation.Columns.Add("Tên Đăng Nhập", 150);
            lvInformation.Columns.Add("Mật Khẩu", 100);

            // Lấy danh sách thí sinh từ BLL
            ThiSinhBLL thiSinhBLL = new ThiSinhBLL();
            List<ThiSinh> list = thiSinhBLL.GetAllThiSinh();

            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thí sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (var ts in list)
            {
                ListViewItem item = new ListViewItem(ts.MaThiSinh.ToString());
                item.SubItems.Add(ts.HoTenThiSinh);
                item.SubItems.Add(ts.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(ts.GioiTinh == 'M' ? "Nam" : "Nữ");
                item.SubItems.Add(ts.DiaChi);
                item.SubItems.Add(ts.Username);
                // Truy xuất mật khẩu cho từng thí sinh
                string password = GetPasswordByUsername(ts.Username);
                // Chuyển mật khẩu thành dạng ẩn
                string hiddenPassword = new string('*', password.Length);
                // Thêm mật khẩu ẩn vào ListView
                item.SubItems.Add(hiddenPassword);


                lvInformation.Items.Add(item);

            }
        }
        //Xem password của thí sinh bằng sự kiện click vào 
        public string GetPasswordByUsername(string username)
        {
            string password = null;
            string query = "SELECT password FROM TaiKhoan WHERE username = @username";

            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    password = reader["password"].ToString();
                }
            }
            return password;
        }

        private void lvInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInformation.SelectedItems.Count > 0)
            {
                // Lấy username của thí sinh được chọn
                string username = lvInformation.SelectedItems[0].SubItems[5].Text; // Cột chứa username

                // Truy vấn mật khẩu
                string password = GetPasswordByUsername(username);

                // Hiển thị mật khẩu (hoặc xử lý theo yêu cầu)
                MessageBox.Show($"Mật khẩu của tài khoản {username} là: {password}", "Thông tin mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearchInfo_Click(object sender, EventArgs e)
        {
            String SinhVienCanTim = txtSearchInfo.Text.Trim();       
            if (string.IsNullOrEmpty(SinhVienCanTim))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thí sinh cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThiSinhBLL thiSinhBLL = new ThiSinhBLL();
            try
            {
                List<ThiSinh> dsThiSinh = thiSinhBLL.TraCuuThiSinh(SinhVienCanTim);
                if (dsThiSinh.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Hiển thị danh sách thí sinh tìm thấy
                lvInformation.Items.Clear();
                foreach (var ts in dsThiSinh)
                {
                    ListViewItem item = new ListViewItem(ts.MaThiSinh.ToString());
                    item.SubItems.Add(ts.HoTenThiSinh);
                    item.SubItems.Add(ts.NgaySinh.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(ts.GioiTinh == 'M' ? "Nam" : "Nữ");
                    item.SubItems.Add(ts.DiaChi);
                    item.SubItems.Add(ts.Username);

                    // Lấy mật khẩu ẩn
                    string password = GetPasswordByUsername(ts.Username);
                    string hiddenPassword = new string('*', password.Length);
                    item.SubItems.Add(hiddenPassword);

                    lvInformation.Items.Add(item);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshInfo_Click(object sender, EventArgs e)
        {
            lvInformation.Clear();
            ShowAllInformation();
            txtSearchInfo.Clear();
            
        }
    }
}
