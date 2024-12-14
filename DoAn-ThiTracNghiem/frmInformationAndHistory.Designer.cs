namespace DoAn_ThiTracNghiem
{
    partial class frmInformationAndHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            txtDiaChi = new TextBox();
            txtGioiTinh = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            txtNgaySinh = new TextBox();
            radioNu = new RadioButton();
            btnSuaThongTin = new Button();
            radioNam = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            txtHoTen = new TextBox();
            txtMaSo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listViewKetQua = new ListView();
            colMaKetQua = new ColumnHeader();
            colLanThi = new ColumnHeader();
            colKetQuaThi = new ColumnHeader();
            colThoiGian = new ColumnHeader();
            groupBox3 = new GroupBox();
            btnChangePassword = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtCurrentPassword = new TextBox();
            label6 = new Label();
            btnChiTietKetQua = new Button();
            btnQuayLai = new Button();
            colTrangThai = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(radioNu);
            groupBox1.Controls.Add(btnSuaThongTin);
            groupBox1.Controls.Add(radioNam);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.RoyalBlue;
            groupBox1.Location = new Point(20, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(958, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.RoyalBlue;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(797, 69);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 28);
            btnLuu.TabIndex = 24;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(132, 99);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(234, 21);
            txtDiaChi.TabIndex = 23;
            txtDiaChi.Text = "Địa chỉ";
            txtDiaChi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGioiTinh.Location = new Point(557, 38);
            txtGioiTinh.Margin = new Padding(2);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(224, 21);
            txtGioiTinh.TabIndex = 22;
            txtGioiTinh.Text = "Giới tính";
            txtGioiTinh.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpNgaySinh.Location = new Point(557, 64);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(224, 24);
            dtpNgaySinh.TabIndex = 21;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNgaySinh.Location = new Point(557, 65);
            txtNgaySinh.Margin = new Padding(2);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(179, 21);
            txtNgaySinh.TabIndex = 20;
            txtNgaySinh.Text = "Ngày sinh";
            txtNgaySinh.TextAlign = HorizontalAlignment.Center;
            // 
            // radioNu
            // 
            radioNu.AutoSize = true;
            radioNu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioNu.Location = new Point(660, 38);
            radioNu.Margin = new Padding(2);
            radioNu.Name = "radioNu";
            radioNu.Size = new Size(41, 19);
            radioNu.TabIndex = 17;
            radioNu.TabStop = true;
            radioNu.Text = "Nữ";
            radioNu.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.RoyalBlue;
            btnSuaThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaThongTin.ForeColor = Color.White;
            btnSuaThongTin.Location = new Point(797, 38);
            btnSuaThongTin.Margin = new Padding(2);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(125, 28);
            btnSuaThongTin.TabIndex = 15;
            btnSuaThongTin.Text = "SỬA THÔNG TIN";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // radioNam
            // 
            radioNam.AutoSize = true;
            radioNam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioNam.Location = new Point(557, 38);
            radioNam.Margin = new Padding(2);
            radioNam.Name = "radioNam";
            radioNam.Size = new Size(51, 19);
            radioNam.TabIndex = 10;
            radioNam.TabStop = true;
            radioNam.Text = "Nam";
            radioNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(479, 67);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(479, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(132, 67);
            txtHoTen.Margin = new Padding(2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 21);
            txtHoTen.TabIndex = 4;
            txtHoTen.Text = "Họ tên";
            txtHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaSo
            // 
            txtMaSo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSo.Location = new Point(132, 35);
            txtMaSo.Margin = new Padding(2);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(232, 21);
            txtMaSo.TabIndex = 3;
            txtMaSo.Text = "Mã số ";
            txtMaSo.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewKetQua);
            groupBox2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.RoyalBlue;
            groupBox2.Location = new Point(20, 279);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(958, 212);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "LỊCH SỬ CÁC LẦN THI";
            // 
            // listViewKetQua
            // 
            listViewKetQua.Columns.AddRange(new ColumnHeader[] { colMaKetQua, colLanThi, colKetQuaThi, colThoiGian, colTrangThai });
            listViewKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listViewKetQua.Location = new Point(4, 36);
            listViewKetQua.Margin = new Padding(3, 2, 3, 2);
            listViewKetQua.Name = "listViewKetQua";
            listViewKetQua.Size = new Size(950, 173);
            listViewKetQua.TabIndex = 0;
            listViewKetQua.UseCompatibleStateImageBehavior = false;
            listViewKetQua.View = View.Details;
            // 
            // colMaKetQua
            // 
            colMaKetQua.Text = "Mã kết quả";
            colMaKetQua.Width = 200;
            // 
            // colLanThi
            // 
            colLanThi.Text = "Lần thi";
            colLanThi.Width = 200;
            // 
            // colKetQuaThi
            // 
            colKetQuaThi.Text = "Kết quả thi";
            colKetQuaThi.Width = 200;
            // 
            // colThoiGian
            // 
            colThoiGian.Text = "Thời gian";
            colThoiGian.Width = 200;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnChangePassword);
            groupBox3.Controls.Add(txtConfirmPassword);
            groupBox3.Controls.Add(txtNewPassword);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtCurrentPassword);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.RoyalBlue;
            groupBox3.Location = new Point(20, 152);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(958, 117);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.RoyalBlue;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(797, 55);
            btnChangePassword.Margin = new Padding(2);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(125, 28);
            btnChangePassword.TabIndex = 16;
            btnChangePassword.Text = "ĐỔI MẬT KHẨU";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(614, 76);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(167, 23);
            txtConfirmPassword.TabIndex = 20;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(614, 35);
            txtNewPassword.Margin = new Padding(2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(167, 23);
            txtNewPassword.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(479, 82);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 18;
            label8.Text = "Xác nhận mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(479, 41);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 16;
            label7.Text = "Mật khẩu mới";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(132, 55);
            txtCurrentPassword.Margin = new Padding(2);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(167, 23);
            txtCurrentPassword.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 50);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 16;
            label6.Text = "Mật khẩu \r\nhiện tại";
            // 
            // btnChiTietKetQua
            // 
            btnChiTietKetQua.BackColor = Color.RoyalBlue;
            btnChiTietKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChiTietKetQua.ForeColor = Color.White;
            btnChiTietKetQua.Location = new Point(409, 497);
            btnChiTietKetQua.Margin = new Padding(2);
            btnChiTietKetQua.Name = "btnChiTietKetQua";
            btnChiTietKetQua.Size = new Size(200, 28);
            btnChiTietKetQua.TabIndex = 21;
            btnChiTietKetQua.Text = "XEM CHI TIẾT BÀI LÀM";
            btnChiTietKetQua.UseVisualStyleBackColor = false;
            btnChiTietKetQua.Click += btnChiTietKetQua_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(874, 502);
            btnQuayLai.Margin = new Padding(3, 2, 3, 2);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(82, 22);
            btnQuayLai.TabIndex = 22;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // colTrangThai
            // 
            colTrangThai.Text = "Trạng thái";
            colTrangThai.Width = 150;
            // 
            // frmInformationAndHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 533);
            Controls.Add(btnQuayLai);
            Controls.Add(btnChiTietKetQua);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmInformationAndHistory";
            Text = "frmInformationAndHistory";
            Load += frmInformationAndHistory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtHoTen;
        private TextBox txtMaSo;
        private TextBox txtGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private Label label5;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioNam;
        private Button btnSuaThongTin;
        private Label label6;
        private TextBox txtCurrentPassword;
        private Label label8;
        private Label label7;
        private Button btnChangePassword;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtNgaySinh;
        private RadioButton radioNu;
        private TextBox txtDiaChi;
        private ListView listViewKetQua;
        private ColumnHeader colLanThi;
        private ColumnHeader colKetQuaThi;
        private ColumnHeader colThoiGian;
        private ColumnHeader colMaKetQua;
        private Button btnChiTietKetQua;
        private Button btnLuu;
        private Button btnQuayLai;
        private ColumnHeader colTrangThai;
    }
}