using System.Windows.Forms;

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
            lblThongTin = new Label();
            pictureBox1 = new PictureBox();
            lblLuyenThi = new Label();
            ((System.ComponentModel.ISupportInitialize)picExamination).BeginInit();
            grpBoxFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picExamination
            // 
            picExamination.Cursor = Cursors.Hand;
            picExamination.ErrorImage = null;
            picExamination.Image = (Image)resources.GetObject("picExamination.Image");
            picExamination.Location = new Point(76, 127);
            picExamination.Margin = new Padding(3, 2, 3, 2);
            picExamination.Name = "picExamination";
            picExamination.Size = new Size(220, 165);
            picExamination.SizeMode = PictureBoxSizeMode.Zoom;
            picExamination.TabIndex = 0;
            picExamination.TabStop = false;
            picExamination.Click += picExamination_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(192, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // grpBoxFeature
            // 
            grpBoxFeature.Controls.Add(lblThongTin);
            grpBoxFeature.Controls.Add(pictureBox1);
            grpBoxFeature.Controls.Add(lblLuyenThi);
            grpBoxFeature.Controls.Add(picExamination);
            grpBoxFeature.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBoxFeature.ForeColor = Color.CornflowerBlue;
            grpBoxFeature.Location = new Point(10, 68);
            grpBoxFeature.Margin = new Padding(3, 2, 3, 2);
            grpBoxFeature.Name = "grpBoxFeature";
            grpBoxFeature.Padding = new Padding(3, 2, 3, 2);
            grpBoxFeature.Size = new Size(739, 451);
            grpBoxFeature.TabIndex = 1;
            grpBoxFeature.TabStop = false;
            grpBoxFeature.Text = "Giao diện thí sinh";
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTin.ForeColor = SystemColors.ActiveCaptionText;
            lblThongTin.Location = new Point(412, 303);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(264, 25);
            lblThongTin.TabIndex = 3;
            lblThongTin.Text = "THÔNG TIN VÀ LỊCH SỬ THI";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(449, 127);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLuyenThi
            // 
            lblLuyenThi.AutoSize = true;
            lblLuyenThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuyenThi.ForeColor = SystemColors.ActiveCaptionText;
            lblLuyenThi.Location = new Point(125, 302);
            lblLuyenThi.Name = "lblLuyenThi";
            lblLuyenThi.Size = new Size(126, 25);
            lblLuyenThi.TabIndex = 1;
            lblLuyenThi.Text = "LÀM BÀI THI";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 527);
            Controls.Add(grpBoxFeature);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)picExamination).EndInit();
            grpBoxFeature.ResumeLayout(false);
            grpBoxFeature.PerformLayout();
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