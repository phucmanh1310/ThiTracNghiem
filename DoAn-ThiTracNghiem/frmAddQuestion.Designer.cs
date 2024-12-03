namespace DoAn_ThiTracNghiem
{
    partial class frmAddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuestion));
            txtQuestion = new TextBox();
            lblQuestion = new Label();
            lblAnswer1 = new Label();
            txtAnswer1 = new TextBox();
            btnAddQuestion = new Button();
            lblAnswer2 = new Label();
            txtAnswer2 = new TextBox();
            lblAnswer3 = new Label();
            txtAnswer3 = new TextBox();
            lblAnswer4 = new Label();
            txtAnswer4 = new TextBox();
            cbxAnswer1 = new CheckBox();
            cbxAnswer2 = new CheckBox();
            cbxAnswer3 = new CheckBox();
            cbxAnswer4 = new CheckBox();
            picImage = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnThemLoai = new Button();
            txtThemLoai = new TextBox();
            label1 = new Label();
            cbbLoaiCauHoi = new ComboBox();
            openFileDialog = new OpenFileDialog();
            lvCauHoi = new ListView();
            TenPhan = new ColumnHeader();
            maCauHoi = new ColumnHeader();
            NoiDung = new ColumnHeader();
            DapAn = new ColumnHeader();
            label2 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.ForeColor = SystemColors.GrayText;
            txtQuestion.Location = new Point(509, 186);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(484, 259);
            txtQuestion.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Cursor = Cursors.IBeam;
            lblQuestion.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.MidnightBlue;
            lblQuestion.Location = new Point(509, 155);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(97, 28);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Câu Hỏi :";
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer1.ForeColor = Color.MidnightBlue;
            lblAnswer1.Location = new Point(496, 448);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new Size(82, 23);
            lblAnswer1.TabIndex = 3;
            lblAnswer1.Text = "Đáp án 1";
            // 
            // txtAnswer1
            // 
            txtAnswer1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer1.ForeColor = SystemColors.GrayText;
            txtAnswer1.Location = new Point(496, 463);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new Size(754, 36);
            txtAnswer1.TabIndex = 2;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.RoyalBlue;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(566, 692);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(211, 40);
            btnAddQuestion.TabIndex = 5;
            btnAddQuestion.Text = "THÊM CÂU HỎI";
            btnAddQuestion.UseVisualStyleBackColor = false;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // lblAnswer2
            // 
            lblAnswer2.AutoSize = true;
            lblAnswer2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer2.ForeColor = Color.MidnightBlue;
            lblAnswer2.Location = new Point(496, 501);
            lblAnswer2.Name = "lblAnswer2";
            lblAnswer2.Size = new Size(82, 23);
            lblAnswer2.TabIndex = 7;
            lblAnswer2.Text = "Đáp án 2";
            // 
            // txtAnswer2
            // 
            txtAnswer2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer2.ForeColor = SystemColors.GrayText;
            txtAnswer2.Location = new Point(499, 521);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new Size(751, 36);
            txtAnswer2.TabIndex = 6;
            // 
            // lblAnswer3
            // 
            lblAnswer3.AutoSize = true;
            lblAnswer3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer3.ForeColor = Color.MidnightBlue;
            lblAnswer3.Location = new Point(496, 564);
            lblAnswer3.Name = "lblAnswer3";
            lblAnswer3.Size = new Size(82, 23);
            lblAnswer3.TabIndex = 11;
            lblAnswer3.Text = "Đáp án 3";
            // 
            // txtAnswer3
            // 
            txtAnswer3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer3.ForeColor = SystemColors.GrayText;
            txtAnswer3.Location = new Point(499, 584);
            txtAnswer3.Name = "txtAnswer3";
            txtAnswer3.Size = new Size(751, 36);
            txtAnswer3.TabIndex = 10;
            // 
            // lblAnswer4
            // 
            lblAnswer4.AutoSize = true;
            lblAnswer4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer4.ForeColor = Color.MidnightBlue;
            lblAnswer4.Location = new Point(496, 627);
            lblAnswer4.Name = "lblAnswer4";
            lblAnswer4.Size = new Size(82, 23);
            lblAnswer4.TabIndex = 13;
            lblAnswer4.Text = "Đáp án 4";
            // 
            // txtAnswer4
            // 
            txtAnswer4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer4.ForeColor = SystemColors.GrayText;
            txtAnswer4.Location = new Point(499, 647);
            txtAnswer4.Name = "txtAnswer4";
            txtAnswer4.Size = new Size(751, 36);
            txtAnswer4.TabIndex = 12;
            // 
            // cbxAnswer1
            // 
            cbxAnswer1.AutoSize = true;
            cbxAnswer1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnswer1.ForeColor = Color.RoyalBlue;
            cbxAnswer1.Location = new Point(1261, 463);
            cbxAnswer1.Name = "cbxAnswer1";
            cbxAnswer1.Size = new Size(87, 34);
            cbxAnswer1.TabIndex = 14;
            cbxAnswer1.Text = "Đúng";
            cbxAnswer1.UseVisualStyleBackColor = true;
            // 
            // cbxAnswer2
            // 
            cbxAnswer2.AutoSize = true;
            cbxAnswer2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnswer2.ForeColor = Color.RoyalBlue;
            cbxAnswer2.Location = new Point(1261, 523);
            cbxAnswer2.Name = "cbxAnswer2";
            cbxAnswer2.Size = new Size(87, 34);
            cbxAnswer2.TabIndex = 15;
            cbxAnswer2.Text = "Đúng";
            cbxAnswer2.UseVisualStyleBackColor = true;
            // 
            // cbxAnswer3
            // 
            cbxAnswer3.AutoSize = true;
            cbxAnswer3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnswer3.ForeColor = Color.RoyalBlue;
            cbxAnswer3.Location = new Point(1261, 586);
            cbxAnswer3.Name = "cbxAnswer3";
            cbxAnswer3.Size = new Size(87, 34);
            cbxAnswer3.TabIndex = 16;
            cbxAnswer3.Text = "Đúng";
            cbxAnswer3.UseVisualStyleBackColor = true;
            // 
            // cbxAnswer4
            // 
            cbxAnswer4.AutoSize = true;
            cbxAnswer4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnswer4.ForeColor = Color.RoyalBlue;
            cbxAnswer4.Location = new Point(1261, 649);
            cbxAnswer4.Name = "cbxAnswer4";
            cbxAnswer4.Size = new Size(87, 34);
            cbxAnswer4.TabIndex = 17;
            cbxAnswer4.Text = "Đúng";
            cbxAnswer4.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(1011, 186);
            picImage.Name = "picImage";
            picImage.Size = new Size(338, 259);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 18;
            picImage.TabStop = false;
            picImage.Tag = "not_opened";
            picImage.Click += picImage_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThemLoai);
            groupBox1.Controls.Add(txtThemLoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbLoaiCauHoi);
            groupBox1.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(509, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 119);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại Câu Hỏi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(297, 88);
            label3.Name = "label3";
            label3.Size = new Size(300, 31);
            label3.TabIndex = 26;
            label3.Text = "CHI TIẾT DỮ LIỆU CÂU HỎI";
            // 
            // btnThemLoai
            // 
            btnThemLoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemLoai.Location = new Point(731, 75);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(86, 33);
            btnThemLoai.TabIndex = 25;
            btnThemLoai.Text = "Thêm";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // txtThemLoai
            // 
            txtThemLoai.Location = new Point(502, 35);
            txtThemLoai.Name = "txtThemLoai";
            txtThemLoai.Size = new Size(315, 34);
            txtThemLoai.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(457, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 23;
            label1.Text = "Thêm loại mới :\r\n";
            // 
            // cbbLoaiCauHoi
            // 
            cbbLoaiCauHoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbLoaiCauHoi.FormattingEnabled = true;
            cbbLoaiCauHoi.Location = new Point(73, 33);
            cbbLoaiCauHoi.Name = "cbbLoaiCauHoi";
            cbbLoaiCauHoi.Size = new Size(343, 36);
            cbbLoaiCauHoi.TabIndex = 0;
            cbbLoaiCauHoi.SelectedIndexChanged += cbbLoaiCauHoi_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // lvCauHoi
            // 
            lvCauHoi.Columns.AddRange(new ColumnHeader[] { TenPhan, maCauHoi, NoiDung, DapAn });
            lvCauHoi.Location = new Point(9, 9);
            lvCauHoi.Name = "lvCauHoi";
            lvCauHoi.Size = new Size(481, 694);
            lvCauHoi.TabIndex = 23;
            lvCauHoi.UseCompatibleStateImageBehavior = false;
            lvCauHoi.View = View.Details;
            lvCauHoi.ItemSelectionChanged += lvCauHoi_ItemSelectionChanged;

            // 
            // TenPhan
            // 
            TenPhan.Text = "Loại Câu Hỏi";
            TenPhan.Width = 100;
            // 
            // maCauHoi
            // 
            maCauHoi.Text = "Mã Câu Hỏi";
            maCauHoi.Width = 90;
            // 
            // NoiDung
            // 
            NoiDung.Text = "Nội Dung";
            NoiDung.Width = 190;
            // 
            // DapAn
            // 
            DapAn.Text = "Đáp án đúng";
            DapAn.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(1011, 155);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 24;
            label2.Text = "Hình ảnh :";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SandyBrown;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(806, 692);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(209, 40);
            btnSua.TabIndex = 25;
            btnSua.Text = "SỬA CÂU HỎI";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1041, 692);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(209, 40);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "XÓA CÂU HỎI";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackgroundImage = (Image)resources.GetObject("btnTaiLai.BackgroundImage");
            btnTaiLai.BackgroundImageLayout = ImageLayout.Zoom;
            btnTaiLai.Location = new Point(1291, 701);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(44, 29);
            btnTaiLai.TabIndex = 27;
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // frmAddQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 744);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(label2);
            Controls.Add(lvCauHoi);
            Controls.Add(groupBox1);
            Controls.Add(picImage);
            Controls.Add(cbxAnswer4);
            Controls.Add(cbxAnswer3);
            Controls.Add(cbxAnswer2);
            Controls.Add(cbxAnswer1);
            Controls.Add(lblAnswer4);
            Controls.Add(txtAnswer4);
            Controls.Add(lblAnswer3);
            Controls.Add(txtAnswer3);
            Controls.Add(lblAnswer2);
            Controls.Add(txtAnswer2);
            Controls.Add(btnAddQuestion);
            Controls.Add(lblAnswer1);
            Controls.Add(txtAnswer1);
            Controls.Add(lblQuestion);
            Controls.Add(txtQuestion);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HighlightText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÊM CÂU HỎI";
            Load += frmAddQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox cbxAnswer1;
        private System.Windows.Forms.CheckBox cbxAnswer2;
        private System.Windows.Forms.CheckBox cbxAnswer3;
        private System.Windows.Forms.CheckBox cbxAnswer4;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        protected internal Label lblQuestion;
        private ComboBox cbbLoaiCauHoi;
        private TextBox txtThemLoai;
        protected internal Label label1;
        private Button btnThemLoai;
        private ListView lvCauHoi;
        protected internal Label label2;
        private Button btnSua;
        private Button btnXoa;
        private ColumnHeader TenPhan;
        private ColumnHeader NoiDung;
        private ColumnHeader DapAn;
        protected internal Label label3;
        private ColumnHeader maCauHoi;
        private Button btnTaiLai;
    }
}