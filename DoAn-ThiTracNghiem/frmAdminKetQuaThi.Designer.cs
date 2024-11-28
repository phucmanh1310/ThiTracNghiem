namespace DoAn_ThiTracNghiem
{
    partial class frmAdminKetQuaThi
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
            txtHoTen = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            cmbLanThi = new ComboBox();
            lblKetQua = new Label();
            label3 = new Label();
            txtKetQua = new TextBox();
            label2 = new Label();
            txtMaTS = new TextBox();
            label9 = new Label();
            txtThoiGian = new TextBox();
            label8 = new Label();
            txtSTT = new TextBox();
            btnBack = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(267, 87);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(282, 30);
            txtHoTen.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 94);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 10;
            label1.Text = "Họ và tên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(325, 26);
            label5.Name = "label5";
            label5.Size = new Size(334, 41);
            label5.TabIndex = 14;
            label5.Text = "KẾT QUẢ THI CHI TIẾT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 142);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 15;
            label6.Text = "Lần dự thi :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbLanThi);
            groupBox3.Controls.Add(lblKetQua);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtKetQua);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtMaTS);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtThoiGian);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtSTT);
            groupBox3.Controls.Add(btnBack);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtHoTen);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(977, 356);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // cmbLanThi
            // 
            cmbLanThi.FormattingEnabled = true;
            cmbLanThi.Location = new Point(680, 139);
            cmbLanThi.Name = "cmbLanThi";
            cmbLanThi.Size = new Size(151, 31);
            cmbLanThi.TabIndex = 28;
            cmbLanThi.SelectedIndexChanged += cmbLanThi_SelectedIndexChanged;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(581, 249);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(0, 38);
            lblKetQua.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 194);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 26;
            label3.Text = "Kết quả :";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(680, 191);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(282, 30);
            txtKetQua.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 142);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 24;
            label2.Text = "Mã số thí sinh :";
            // 
            // txtMaTS
            // 
            txtMaTS.Location = new Point(300, 135);
            txtMaTS.Name = "txtMaTS";
            txtMaTS.Size = new Size(249, 30);
            txtMaTS.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(168, 191);
            label9.Name = "label9";
            label9.Size = new Size(151, 23);
            label9.TabIndex = 22;
            label9.Text = "Thời gian làm bài :";
            // 
            // txtThoiGian
            // 
            txtThoiGian.Location = new Point(325, 188);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(226, 30);
            txtThoiGian.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(581, 94);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 20;
            label8.Text = "Số thứ tự :";
            // 
            // txtSTT
            // 
            txtSTT.Location = new Point(680, 87);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(282, 30);
            txtSTT.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(16, 115);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 50);
            btnBack.TabIndex = 18;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmAdminKetQuaThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 389);
            Controls.Add(groupBox3);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminKetQuaThi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            Load += frnAdminKetQuaThi_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCapNhat;
        private TextBox txtHoTen;
        private Label label1;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnBack;
        private Label label8;
        private TextBox txtSTT;
        private Label label9;
        private TextBox txtThoiGian;
        private Label label2;
        private TextBox txtMaTS;
        private Label label3;
        private TextBox txtKetQua;
        private Label lblKetQua;
        private ComboBox cmbLanThi;
    }
}