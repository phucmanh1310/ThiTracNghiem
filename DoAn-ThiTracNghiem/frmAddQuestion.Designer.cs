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
            txtQuestion = new TextBox();
            lblQuestion = new Label();
            lblAnswer1 = new Label();
            txtAnswer1 = new TextBox();
            lblTitle = new Label();
            btnAddQuestion = new Button();
            lblAnswer2 = new Label();
            txtAnswer2 = new TextBox();
            lblAnswer3 = new Label();
            txtAnswer3 = new TextBox();
            lblAnswer4 = new Label();
            txtAnswer4 = new TextBox();
            cbxAnwer1 = new CheckBox();
            cbxAnwer2 = new CheckBox();
            cbxAnwer3 = new CheckBox();
            cbxAnwer4 = new CheckBox();
            picImage = new PictureBox();
            groupBox1 = new GroupBox();
            rdoQuestionType3 = new RadioButton();
            rdoQuestionType2 = new RadioButton();
            rdoQuestionType1 = new RadioButton();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuestion.ForeColor = SystemColors.GrayText;
            txtQuestion.Location = new Point(29, 96);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(569, 36);
            txtQuestion.TabIndex = 0;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Cursor = Cursors.IBeam;
            lblQuestion.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.MidnightBlue;
            lblQuestion.Location = new Point(35, 68);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(97, 28);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Câu Hỏi :";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer1.ForeColor = Color.MidnightBlue;
            lblAnswer1.Location = new Point(29, 362);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new Size(82, 23);
            lblAnswer1.TabIndex = 3;
            lblAnswer1.Text = "Đáp án 1";
            // 
            // txtAnswer1
            // 
            txtAnswer1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer1.ForeColor = SystemColors.GrayText;
            txtAnswer1.Location = new Point(32, 382);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new Size(492, 36);
            txtAnswer1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 23.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(165, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 54);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "THÊM CÂU HỎI";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.BackColor = Color.RoyalBlue;
            btnAddQuestion.FlatAppearance.BorderSize = 0;
            btnAddQuestion.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddQuestion.ForeColor = Color.White;
            btnAddQuestion.Location = new Point(178, 629);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(250, 40);
            btnAddQuestion.TabIndex = 5;
            btnAddQuestion.Text = "THÊM CÂU HỎI";
            btnAddQuestion.UseVisualStyleBackColor = false;
            // 
            // lblAnswer2
            // 
            lblAnswer2.AutoSize = true;
            lblAnswer2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer2.ForeColor = Color.MidnightBlue;
            lblAnswer2.Location = new Point(29, 422);
            lblAnswer2.Name = "lblAnswer2";
            lblAnswer2.Size = new Size(82, 23);
            lblAnswer2.TabIndex = 7;
            lblAnswer2.Text = "Đáp án 2";
            // 
            // txtAnswer2
            // 
            txtAnswer2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer2.ForeColor = SystemColors.GrayText;
            txtAnswer2.Location = new Point(32, 442);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new Size(492, 36);
            txtAnswer2.TabIndex = 6;
            // 
            // lblAnswer3
            // 
            lblAnswer3.AutoSize = true;
            lblAnswer3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer3.ForeColor = Color.MidnightBlue;
            lblAnswer3.Location = new Point(29, 485);
            lblAnswer3.Name = "lblAnswer3";
            lblAnswer3.Size = new Size(82, 23);
            lblAnswer3.TabIndex = 11;
            lblAnswer3.Text = "Đáp án 3";
            // 
            // txtAnswer3
            // 
            txtAnswer3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer3.ForeColor = SystemColors.GrayText;
            txtAnswer3.Location = new Point(32, 505);
            txtAnswer3.Name = "txtAnswer3";
            txtAnswer3.Size = new Size(492, 36);
            txtAnswer3.TabIndex = 10;
            txtAnswer3.TextChanged += txtAnswer3_TextChanged;
            // 
            // lblAnswer4
            // 
            lblAnswer4.AutoSize = true;
            lblAnswer4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer4.ForeColor = Color.MidnightBlue;
            lblAnswer4.Location = new Point(29, 548);
            lblAnswer4.Name = "lblAnswer4";
            lblAnswer4.Size = new Size(82, 23);
            lblAnswer4.TabIndex = 13;
            lblAnswer4.Text = "Đáp án 4";
            // 
            // txtAnswer4
            // 
            txtAnswer4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer4.ForeColor = SystemColors.GrayText;
            txtAnswer4.Location = new Point(32, 568);
            txtAnswer4.Name = "txtAnswer4";
            txtAnswer4.Size = new Size(492, 36);
            txtAnswer4.TabIndex = 12;
            // 
            // cbxAnwer1
            // 
            cbxAnwer1.AutoSize = true;
            cbxAnwer1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnwer1.ForeColor = Color.RoyalBlue;
            cbxAnwer1.Location = new Point(530, 384);
            cbxAnwer1.Name = "cbxAnwer1";
            cbxAnwer1.Size = new Size(87, 34);
            cbxAnwer1.TabIndex = 14;
            cbxAnwer1.Text = "Đúng";
            cbxAnwer1.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer2
            // 
            cbxAnwer2.AutoSize = true;
            cbxAnwer2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnwer2.ForeColor = Color.RoyalBlue;
            cbxAnwer2.Location = new Point(530, 444);
            cbxAnwer2.Name = "cbxAnwer2";
            cbxAnwer2.Size = new Size(87, 34);
            cbxAnwer2.TabIndex = 15;
            cbxAnwer2.Text = "Đúng";
            cbxAnwer2.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer3
            // 
            cbxAnwer3.AutoSize = true;
            cbxAnwer3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnwer3.ForeColor = Color.RoyalBlue;
            cbxAnwer3.Location = new Point(530, 507);
            cbxAnwer3.Name = "cbxAnwer3";
            cbxAnwer3.Size = new Size(87, 34);
            cbxAnwer3.TabIndex = 16;
            cbxAnwer3.Text = "Đúng";
            cbxAnwer3.UseVisualStyleBackColor = true;
            // 
            // cbxAnwer4
            // 
            cbxAnwer4.AutoSize = true;
            cbxAnwer4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAnwer4.ForeColor = Color.RoyalBlue;
            cbxAnwer4.Location = new Point(530, 570);
            cbxAnwer4.Name = "cbxAnwer4";
            cbxAnwer4.Size = new Size(87, 34);
            cbxAnwer4.TabIndex = 17;
            cbxAnwer4.Text = "Đúng";
            cbxAnwer4.UseVisualStyleBackColor = true;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(264, 169);
            picImage.Name = "picImage";
            picImage.Size = new Size(337, 185);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 18;
            picImage.TabStop = false;
            picImage.Tag = "not_opened";
            picImage.Click += picImage_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(rdoQuestionType3);
            groupBox1.Controls.Add(rdoQuestionType2);
            groupBox1.Controls.Add(rdoQuestionType1);
            groupBox1.Font = new Font("Segoe UI", 11.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(29, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 200);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại Câu Hỏi :";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoQuestionType3
            // 
            rdoQuestionType3.AutoSize = true;
            rdoQuestionType3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoQuestionType3.ForeColor = Color.RoyalBlue;
            rdoQuestionType3.Location = new Point(6, 135);
            rdoQuestionType3.Name = "rdoQuestionType3";
            rdoQuestionType3.Size = new Size(104, 34);
            rdoQuestionType3.TabIndex = 24;
            rdoQuestionType3.TabStop = true;
            rdoQuestionType3.Text = "Sa hình";
            rdoQuestionType3.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType2
            // 
            rdoQuestionType2.AutoSize = true;
            rdoQuestionType2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoQuestionType2.ForeColor = Color.RoyalBlue;
            rdoQuestionType2.Location = new Point(6, 87);
            rdoQuestionType2.Name = "rdoQuestionType2";
            rdoQuestionType2.Size = new Size(119, 34);
            rdoQuestionType2.TabIndex = 23;
            rdoQuestionType2.TabStop = true;
            rdoQuestionType2.Text = "Biển báo";
            rdoQuestionType2.UseVisualStyleBackColor = true;
            // 
            // rdoQuestionType1
            // 
            rdoQuestionType1.AutoSize = true;
            rdoQuestionType1.BackColor = SystemColors.Control;
            rdoQuestionType1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoQuestionType1.ForeColor = Color.RoyalBlue;
            rdoQuestionType1.Location = new Point(6, 42);
            rdoQuestionType1.Name = "rdoQuestionType1";
            rdoQuestionType1.Size = new Size(243, 34);
            rdoQuestionType1.TabIndex = 22;
            rdoQuestionType1.TabStop = true;
            rdoQuestionType1.Text = "Giao thông đường bộ";
            rdoQuestionType1.UseVisualStyleBackColor = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // frmAddQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 681);
            Controls.Add(groupBox1);
            Controls.Add(picImage);
            Controls.Add(cbxAnwer4);
            Controls.Add(cbxAnwer3);
            Controls.Add(cbxAnwer2);
            Controls.Add(cbxAnwer1);
            Controls.Add(lblAnswer4);
            Controls.Add(txtAnswer4);
            Controls.Add(lblAnswer3);
            Controls.Add(txtAnswer3);
            Controls.Add(lblAnswer2);
            Controls.Add(txtAnswer2);
            Controls.Add(btnAddQuestion);
            Controls.Add(lblTitle);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox cbxAnwer1;
        private System.Windows.Forms.CheckBox cbxAnwer2;
        private System.Windows.Forms.CheckBox cbxAnwer3;
        private System.Windows.Forms.CheckBox cbxAnwer4;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoQuestionType3;
        private System.Windows.Forms.RadioButton rdoQuestionType2;
        private System.Windows.Forms.RadioButton rdoQuestionType1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        protected internal Label lblQuestion;
    }
}