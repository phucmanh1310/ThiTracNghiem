namespace DoAn_ThiTracNghiem
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            picExamination = new PictureBox();
            lblTitle = new Label();
            grpBoxFeature = new GroupBox();
            lblTaiLieu = new Label();
            picDocument = new PictureBox();
            lblThongTin = new Label();
            pictureBox1 = new PictureBox();
            lblLuyenThi = new Label();
            ((System.ComponentModel.ISupportInitialize)picExamination).BeginInit();
            grpBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picExamination
            // 
            picExamination.Cursor = Cursors.Hand;
            picExamination.ErrorImage = null;
            picExamination.Image = (Image)resources.GetObject("picExamination.Image");
            picExamination.Location = new Point(308, 45);
            picExamination.Name = "picExamination";
            picExamination.Size = new Size(252, 220);
            picExamination.SizeMode = PictureBoxSizeMode.Zoom;
            picExamination.TabIndex = 0;
            picExamination.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(220, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // grpBoxFeature
            // 
            grpBoxFeature.Controls.Add(lblTaiLieu);
            grpBoxFeature.Controls.Add(picDocument);
            grpBoxFeature.Controls.Add(lblThongTin);
            grpBoxFeature.Controls.Add(pictureBox1);
            grpBoxFeature.Controls.Add(lblLuyenThi);
            grpBoxFeature.Controls.Add(picExamination);
            grpBoxFeature.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxFeature.ForeColor = Color.CornflowerBlue;
            grpBoxFeature.Location = new Point(12, 90);
            grpBoxFeature.Name = "grpBoxFeature";
            grpBoxFeature.Size = new Size(845, 601);
            grpBoxFeature.TabIndex = 1;
            grpBoxFeature.TabStop = false;
            grpBoxFeature.Text = "Giao diện thí sinh";
            // 
            // lblTaiLieu
            // 
            lblTaiLieu.AutoSize = true;
            lblTaiLieu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaiLieu.ForeColor = SystemColors.ActiveCaptionText;
            lblTaiLieu.Location = new Point(74, 536);
            lblTaiLieu.Name = "lblTaiLieu";
            lblTaiLieu.Size = new Size(250, 31);
            lblTaiLieu.TabIndex = 5;
            lblTaiLieu.Text = "TÀI LIỆU THAM KHẢO";
            // 
            // picDocument
            // 
            picDocument.Cursor = Cursors.Hand;
            picDocument.ErrorImage = null;
            picDocument.Image = (Image)resources.GetObject("picDocument.Image");
            picDocument.Location = new Point(72, 302);
            picDocument.Name = "picDocument";
            picDocument.Size = new Size(252, 220);
            picDocument.SizeMode = PictureBoxSizeMode.Zoom;
            picDocument.TabIndex = 4;
            picDocument.TabStop = false;
            picDocument.Click += picDocument_Click;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTin.ForeColor = SystemColors.ActiveCaptionText;
            lblThongTin.Location = new Point(510, 536);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(314, 31);
            lblThongTin.TabIndex = 3;
            lblThongTin.Text = "THÔNG TIN VÀ LỊCH SỬ THI";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 302);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblLuyenThi
            // 
            lblLuyenThi.AutoSize = true;
            lblLuyenThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuyenThi.ForeColor = SystemColors.ActiveCaptionText;
            lblLuyenThi.Location = new Point(365, 279);
            lblLuyenThi.Name = "lblLuyenThi";
            lblLuyenThi.Size = new Size(152, 31);
            lblLuyenThi.TabIndex = 1;
            lblLuyenThi.Text = "LÀM BÀI THI";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 703);
            Controls.Add(grpBoxFeature);
            Controls.Add(lblTitle);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)picExamination).EndInit();
            grpBoxFeature.ResumeLayout(false);
            grpBoxFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDocument).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picExamination;
        private Label lblTitle;
        private GroupBox grpBoxFeature;
        private Label lblLuyenThi;
        private Label lblTaiLieu;
        private PictureBox picDocument;
        private Label lblThongTin;
        private PictureBox pictureBox1;
    }
}