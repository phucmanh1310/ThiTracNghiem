namespace DoAn_ThiTracNghiem
{
    partial class frmAdmin
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(372, 65);
            label1.Name = "label1";
            label1.Size = new Size(780, 86);
            label1.TabIndex = 0;
            label1.Text = "LỰA CHỌN CHỨC NĂNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.question_answer;
            pictureBox1.Location = new Point(142, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 513);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.history;
            pictureBox2.Location = new Point(768, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(564, 513);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(296, 709);
            label2.Name = "label2";
            label2.Size = new Size(291, 50);
            label2.TabIndex = 3;
            label2.Text = "THÊM CÂU HỎI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(768, 709);
            label3.Name = "label3";
            label3.Size = new Size(564, 50);
            label3.TabIndex = 4;
            label3.Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            label3.Click += this.label3_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 809);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmAdmin";
            Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}