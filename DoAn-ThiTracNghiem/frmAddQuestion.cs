using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAddQuestion : Form
    {
        private readonly CauHoiBBL questionBLL;
        private readonly PhanBLL phanBLL;
        public frmAddQuestion()
        {
            InitializeComponent();
            questionBLL = new CauHoiBBL();
            phanBLL = new PhanBLL();
        }
        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            LoadLoaiCauHoi();
            int maPhan = GetSelectedMaPhan();
            if (maPhan != -1)
            {
                LoadCauHoiToListView(maPhan);
            }
            else
            {
                MessageBox.Show("Không thể lấy mã phần được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadCauHoiToListView(int maPhan)
        {
            List<Tuple<string, string, string>> listCauHoi = questionBLL.GetCauHoiByMaPhan(maPhan);

            // Xóa dữ liệu cũ
            lvCauHoi.Items.Clear();
            if (lvCauHoi.Columns.Count == 0)
            {
                lvCauHoi.Columns.Add("Mã phần", 100); // Adjust column headers if necessary
                lvCauHoi.Columns.Add("Câu hỏi", 300);
                lvCauHoi.Columns.Add("Đáp án đúng", 200);
            }

            // Duyệt qua danh sách và thêm vào ListView
            foreach (var cauHoi in listCauHoi)
            {
                ListViewItem item = new ListViewItem(cauHoi.Item1); 
                item.SubItems.Add(cauHoi.Item2); // Nội dung câu hỏi
                item.SubItems.Add(cauHoi.Item3); // Câu trả lời đúng

                lvCauHoi.Items.Add(item);
            }
        }

        private void LoadLoaiCauHoi()
        {
            try
            {
                var loaiCauHoiList = phanBLL.GetAllLoaiCauHoi();

                if (loaiCauHoiList == null || loaiCauHoiList.Count == 0)
                {
                    MessageBox.Show("Không có loại câu hỏi để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cbbLoaiCauHoi.DataSource = loaiCauHoiList;
                cbbLoaiCauHoi.DisplayMember = "TenPhan"; // Display name
                cbbLoaiCauHoi.ValueMember = "MaPhan";   // Value (used to fetch data)

                // Chọn giá trị mặc định
                if (cbbLoaiCauHoi.Items.Count > 0)
                {
                    cbbLoaiCauHoi.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải loại câu hỏi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            string newLoaiCauHoi = txtThemLoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(newLoaiCauHoi))
            {
                MessageBox.Show("Vui lòng nhập tên phần mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isAdded = phanBLL.AddLoaiCauHoi(newLoaiCauHoi);

                if (isAdded)
                {
                    MessageBox.Show("Thêm loại câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiCauHoi();  // Load lại danh sách sau khi thêm
                    txtThemLoai.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm loại câu hỏi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

            // Lấy nội dung từ giao diện
            string ndCauHoi = txtQuestion.Text.Trim();
            if (string.IsNullOrEmpty(ndCauHoi))
            {
                MessageBox.Show("Vui lòng nhập nội dung câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ComboBox loại câu hỏi
            if (cbbLoaiCauHoi.SelectedIndex == -1 || cbbLoaiCauHoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phần từ ComboBox
            short maPhan;
            if (!short.TryParse(cbbLoaiCauHoi.SelectedValue.ToString(), out maPhan))
            {
                MessageBox.Show("Mã phần không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Xử lý hình ảnh nếu có
            Byte[] hinhAnh = null;
            if (picImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    hinhAnh = ms.ToArray();
                }
            }
            // Tạo đối tượng câu hỏi với HinhAnh là null nếu không có ảnh
            CauHoi cauHoi = new CauHoi(null, ndCauHoi, maPhan, hinhAnh);


            // Tạo danh sách đáp án
            List<DapAn> dapAns = new List<DapAn>
            {
                new DapAn(0, txtAnswer1.Text.Trim(), null, cbxAnswer1.Checked),
                new DapAn(0, txtAnswer2.Text.Trim(), null, cbxAnswer2.Checked),
                new DapAn(0, txtAnswer3.Text.Trim(), null, cbxAnswer3.Checked),
                new DapAn(0, txtAnswer4.Text.Trim(), null, cbxAnswer4.Checked)
            };

            // Kiểm tra đáp án hợp lệ
            if (dapAns.Any(da => string.IsNullOrWhiteSpace(da.NDCauTraLoi)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các đáp án.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dapAns.Any(da => da.DungSai))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một đáp án đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BLL để xử lý
            try
            {
                questionBLL.AddQuestionAndAnswers(cauHoi, dapAns);
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giao diện
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm câu hỏi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtQuestion.Clear();
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();
            cbxAnswer1.Checked = false;
            cbxAnswer2.Checked = false;
            cbxAnswer3.Checked = false;
            cbxAnswer4.Checked = false;
            picImage.Image = null;
            if (cbbLoaiCauHoi.Items.Count > 0)
                cbbLoaiCauHoi.SelectedIndex = 0;
        }
        private void picImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picImage.Image = Image.FromFile(openFileDialog.FileName);
                    picImage.Tag = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Hàm lấy maPhan từ ComboBox
        private int GetSelectedMaPhan()
        {
            String querry = "SELECT MaPhan \r\nFROM Phan \r\nWHERE TenPhan LIKE N'%@TenPhan%';";
            String tenPhan = cbbLoaiCauHoi.SelectedIndex.ToString();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@TenPhan", tenPhan);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())  // Kiểm tra nếu có dữ liệu trả về
                {
                    return reader.GetInt32(0);  // Lấy giá trị MaPhan (cột đầu tiên)
                }
                else
                {
                    // Nếu không lấy được mã phần, trả về -1
                    return -1;
                }
            }

               
        }

        private void cbbLoaiCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiCauHoi.SelectedIndex != -1) // Ensure selection is valid
            {
                int maPhan = GetSelectedMaPhan();
                if (maPhan != -1)
                {
                    LoadCauHoiToListView(maPhan); // Refresh the question list
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã phần từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



    }
}
