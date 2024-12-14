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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAn_ThiTracNghiem
{
    public partial class frmAddQuestion : Form
    {
        private readonly CauHoiBLL CauHoiBLL;
        private readonly PhanBLL phanBLL;
        private readonly DapAnBBL dapAnBLL;
        public frmAddQuestion()
        {
            InitializeComponent();
            CauHoiBLL = new CauHoiBLL();
            phanBLL = new PhanBLL();
            dapAnBLL = new DapAnBBL();
        }
        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            LoadLoaiCauHoi();
            LoadLoaiCauHoi_Sua();
        }
        private void LoadCauHoiToListView(int maPhan)
        {
            List<Tuple<string, int, string, string>> listCauHoi = CauHoiBLL.GetCauHoiByMaPhan(maPhan);

            // Xóa dữ liệu cũ
            lvCauHoi.Items.Clear();
            if (lvCauHoi.Columns.Count == 0)
            {
                lvCauHoi.Columns.Add("Mã phần", 80);
                lvCauHoi.Columns.Add("Mã câu hỏi", 80);
                lvCauHoi.Columns.Add("Câu hỏi", 200);
                lvCauHoi.Columns.Add("Đáp án đúng", 150);
            }

            // Duyệt qua danh sách và thêm vào ListView
            foreach (var cauHoi in listCauHoi)
            {
                ListViewItem item = new ListViewItem(cauHoi.Item1);
                item.SubItems.Add(cauHoi.Item2.ToString()); // Nội dung câu hỏi
                item.SubItems.Add(cauHoi.Item3); // Nội dung câu hỏi
                item.SubItems.Add(cauHoi.Item4); // Câu trả lời đúng

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
                //cbb hiển thị loại câu hỏi dùng hiện danh sách câu hỏi
                cbbLoaiCauHoi.DataSource = loaiCauHoiList;
                cbbLoaiCauHoi.DisplayMember = "TenPhan"; // Hiển thị tên loại
                cbbLoaiCauHoi.ValueMember = "MaPhan";   // Giá trị dùng cho việc truy vấn
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
        private void LoadLoaiCauHoi_Sua()
        {
            try
            {
                var loaiCauHoiList = phanBLL.GetAllLoaiCauHoi();

                if (loaiCauHoiList == null || loaiCauHoiList.Count == 0)
                {
                    MessageBox.Show("Không có loại câu hỏi để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // cbb để sửa
                cbbLoaiCauHoi_Sua.DataSource = loaiCauHoiList;
                cbbLoaiCauHoi_Sua.DisplayMember = "TenPhan"; // Hiển thị tên loại
                cbbLoaiCauHoi_Sua.ValueMember = "MaPhan";   // Giá trị dùng cho việc truy vấn

                // Chọn giá trị mặc định
                if (cbbLoaiCauHoi_Sua.Items.Count > 0)
                {
                    cbbLoaiCauHoi_Sua.SelectedIndex = 0;
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

            // Lấy mã phần từ ComboBox
            short maPhan;
            if (!short.TryParse(cbbLoaiCauHoi_Sua.SelectedValue.ToString(), out maPhan))
            {
                MessageBox.Show("Mã phần không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đường dẫn thư mục cố định
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\images");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath); // Tạo thư mục nếu chưa tồn tại
            }

            // Xử lý hình ảnh nếu có
            string imagePath = null;
            if (picImage.Image != null)
            {
                string fileName = Path.GetFileName(picImage.Tag.ToString());
                imagePath = Path.Combine(folderPath, fileName);

                // Sao chép hình ảnh vào thư mục cố định
                picImage.Image.Save(imagePath);

                // Lưu đường dẫn tương đối
                imagePath = Path.Combine("images", fileName);
            }

            // Tạo đối tượng câu hỏi
            CauHoi cauHoi = new CauHoi(ndCauHoi, maPhan, imagePath);

            // Tạo danh sách đáp án
            List<DapAn> dapAns = new List<DapAn>
                {
                    new DapAn(0, txtAnswer1.Text.Trim(), null, cbxAnswer1.Checked),
                    new DapAn(0, txtAnswer2.Text.Trim(), null, cbxAnswer2.Checked),
                    new DapAn(0, txtAnswer3.Text.Trim(), null, cbxAnswer3.Checked),
                    new DapAn(0, txtAnswer4.Text.Trim(), null, cbxAnswer4.Checked)
                };

            // Kiểm tra đáp án hợp lệ
            if (!dapAns.Any(da => da.DungSai))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một đáp án đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BLL để xử lý
            try
            {
                CauHoiBLL.AddQuestionAndAnswers(cauHoi, dapAns);
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


        private void cbbLoaiCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiCauHoi.SelectedIndex != -1) // Đảm bảo có lựa chọn hợp lệ
            {
                // Lấy đối tượng Phan từ SelectedItem
                Phan selectedPhan = cbbLoaiCauHoi.SelectedItem as Phan;
                // Cập nhật cbbLoaiCauHoi_Sua với giá trị tương ứng
                cbbLoaiCauHoi_Sua.SelectedValue = cbbLoaiCauHoi.SelectedValue;

                if (selectedPhan != null)
                {
                    // Lấy MaPhan từ đối tượng Phan
                    int maPhan = selectedPhan.MaPhan;
                    LoadCauHoiToListView(maPhan); // Tải câu hỏi theo MaPhan
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã phần từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lvCauHoi_ItemSelectionChanged(object sender, EventArgs e)
        {
            if (lvCauHoi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvCauHoi.SelectedItems[0];
                // Lấy mã câu hỏi từ cột thứ hai
                int maCauHoi = int.Parse((selectedItem.SubItems[1]).Text);

                try
                {
                    // Lấy thông tin câu hỏi từ database dựa trên mã câu hỏi
                    var chiTietCauHoi = CauHoiBLL.GetCauHoiChiTietById(maCauHoi);
                    // In ra thông tin câu hỏi
                    txtQuestion.Text = chiTietCauHoi.NDCauHoi;

                    // Hiển thị hình ảnh (nếu có)
                    if (!string.IsNullOrEmpty(chiTietCauHoi.HinhAnh))
                    {
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", chiTietCauHoi.HinhAnh);

                        if (File.Exists(imagePath))
                        {
                            picImage.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picImage.Image = null;
                        }
                    }
                    else
                    {
                        picImage.Image = null;
                    }

                    // Lấy danh sách đáp án
                    List<DapAn> dapAnList = dapAnBLL.GetDapAn(maCauHoi);

                    // Hiển thị đáp án vào các ô txtAnswer1 - txtAnswer4
                    txtAnswer1.Text = dapAnList.Count > 0 ? dapAnList[0].NDCauTraLoi : "";
                    txtAnswer2.Text = dapAnList.Count > 1 ? dapAnList[1].NDCauTraLoi : "";
                    txtAnswer3.Text = dapAnList.Count > 2 ? dapAnList[2].NDCauTraLoi : "";
                    txtAnswer4.Text = dapAnList.Count > 3 ? dapAnList[3].NDCauTraLoi : "";

                    // Kiểm tra và đổi màu checkbox nếu đáp án đúng
                    cbxAnswer1.BackColor = dapAnList.Count > 0 && dapAnList[0].DungSai ? Color.Green : Color.Transparent;
                    cbxAnswer2.BackColor = dapAnList.Count > 1 && dapAnList[1].DungSai ? Color.Green : Color.Transparent;
                    cbxAnswer3.BackColor = dapAnList.Count > 2 && dapAnList[2].DungSai ? Color.Green : Color.Transparent;
                    cbxAnswer4.BackColor = dapAnList.Count > 3 && dapAnList[3].DungSai ? Color.Green : Color.Transparent;

                    // Ẩn nút thêm câu hỏi
                    btnAddQuestion.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //f5 lại tất cả sự kiện

        private void ResetForm_in()
        {
            // Xóa nội dung trong các TextBox
            txtQuestion.Clear();
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();

            // Xóa hình ảnh trong PictureBox
            picImage.Image = null;

            // Hủy chọn các CheckBox
            cbxAnswer1.Checked = false;
            cbxAnswer2.Checked = false;
            cbxAnswer3.Checked = false;
            cbxAnswer4.Checked = false;

            // Đặt lại màu nền của các TextBox về mặc định
            txtAnswer1.BackColor = Color.White;
            txtAnswer2.BackColor = Color.White;
            txtAnswer3.BackColor = Color.White;
            txtAnswer4.BackColor = Color.White;

            // Đặt lại màu nền của các CheckBox về mặc định (nếu có thay đổi)
            cbxAnswer1.BackColor = Color.Transparent;
            cbxAnswer2.BackColor = Color.Transparent;
            cbxAnswer3.BackColor = Color.Transparent;
            cbxAnswer4.BackColor = Color.Transparent;

            // Hiển thị lại nút thêm câu hỏi
            btnAddQuestion.Visible = true;
        }


        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            ResetForm_in();
        }
        //sửa dữ liệu
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvCauHoi.SelectedItems.Count > 0)
            {
                try
                {
                    // Lấy mã câu hỏi được chọn
                    ListViewItem selectedItem = lvCauHoi.SelectedItems[0];
                    int maCauHoi = int.Parse(selectedItem.SubItems[1].Text);

                    // Lấy thông tin từ giao diện
                    string ndCauHoi = txtQuestion.Text.Trim();
                    int maPhan = (int)cbbLoaiCauHoi_Sua.SelectedValue;

                    // Đảm bảo đường dẫn hình ảnh không bị null
                    string hinhAnh = picImage.Tag != null ? picImage.Tag.ToString() : null;

                    List<DapAn> danhSachDapAn = new List<DapAn>
            {
                new DapAn { NDCauTraLoi = txtAnswer1.Text.Trim(), DungSai = cbxAnswer1.Checked },
                new DapAn { NDCauTraLoi = txtAnswer2.Text.Trim(), DungSai = cbxAnswer2.Checked },
                new DapAn { NDCauTraLoi = txtAnswer3.Text.Trim(), DungSai = cbxAnswer3.Checked },
                new DapAn { NDCauTraLoi = txtAnswer4.Text.Trim(), DungSai = cbxAnswer4.Checked },
            };

                    // Kiểm tra đáp án đúng
                    if (!cbxAnswer1.Checked && !cbxAnswer2.Checked && !cbxAnswer3.Checked && !cbxAnswer4.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất một đáp án đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Gọi BLL để cập nhật
                    if (CauHoiBLL.CapNhatCauHoiVaDapAn(maCauHoi, maPhan, ndCauHoi, hinhAnh, danhSachDapAn))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCauHoiToListView(maPhan);
                        ResetForm_in();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại! Hãy kiểm tra lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một câu hỏi để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //xóa dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvCauHoi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvCauHoi.SelectedItems[0];
                int maCauHoi = int.Parse(selectedItem.SubItems[1].Text);  // Giả sử MaCauTraLoi nằm ở cột 0
                if (CauHoiBLL.XoaDapAn(maCauHoi))
                {
                    MessageBox.Show("Đã xóa câu trả lời thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một câu hỏi để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ResetForm_in();
        }

   
    }
}