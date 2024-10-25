namespace DoAn_ThiTracNghiem
{
    partial class frmAllInformation
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
            label1 = new Label();
            txtSearchResult = new TextBox();
            btnRefreshResult = new Button();
            btnSearchResult = new Button();
            dataHistory = new DataGridView();
            groupBox2 = new GroupBox();
            lblSex = new Label();
            btnRefreshInfo = new Button();
            btnSearchInfo = new Button();
            txtSearchInfo = new TextBox();
            dataInformation = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataHistory).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataInformation).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSearchResult);
            groupBox1.Controls.Add(btnRefreshResult);
            groupBox1.Controls.Add(btnSearchResult);
            groupBox1.Controls.Add(dataHistory);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(16, 431);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1035, 385);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "CÁC KẾT QUẢ THI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(257, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 7;
            label1.Text = "Tìm kiếm thông tin kết quả :";
            label1.Click += label1_Click;
            // 
            // txtSearchResult
            // 
            txtSearchResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchResult.Location = new Point(507, 48);
            txtSearchResult.Margin = new Padding(4, 5, 4, 5);
            txtSearchResult.Name = "txtSearchResult";
            txtSearchResult.Size = new Size(341, 29);
            txtSearchResult.TabIndex = 5;
            // 
            // btnRefreshResult
            // 
            btnRefreshResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshResult.ForeColor = Color.MediumAquamarine;
            btnRefreshResult.Location = new Point(983, 42);
            btnRefreshResult.Margin = new Padding(4, 5, 4, 5);
            btnRefreshResult.Name = "btnRefreshResult";
            btnRefreshResult.Size = new Size(37, 42);
            btnRefreshResult.TabIndex = 4;
            btnRefreshResult.UseVisualStyleBackColor = true;
            // 
            // btnSearchResult
            // 
            btnSearchResult.BackColor = SystemColors.MenuHighlight;
            btnSearchResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchResult.ForeColor = Color.GhostWhite;
            btnSearchResult.Location = new Point(856, 42);
            btnSearchResult.Margin = new Padding(4, 5, 4, 5);
            btnSearchResult.Name = "btnSearchResult";
            btnSearchResult.Size = new Size(119, 41);
            btnSearchResult.TabIndex = 3;
            btnSearchResult.Text = "Tìm kiếm";
            btnSearchResult.UseVisualStyleBackColor = false;
            // 
            // dataHistory
            // 
            dataHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataHistory.Location = new Point(8, 94);
            dataHistory.Margin = new Padding(4, 5, 4, 5);
            dataHistory.Name = "dataHistory";
            dataHistory.ReadOnly = true;
            dataHistory.RowHeadersWidth = 51;
            dataHistory.Size = new Size(1015, 291);
            dataHistory.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSex);
            groupBox2.Controls.Add(btnRefreshInfo);
            groupBox2.Controls.Add(btnSearchInfo);
            groupBox2.Controls.Add(txtSearchInfo);
            groupBox2.Controls.Add(dataInformation);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(16, 19);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1035, 402);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN NGƯỜI DÙNG";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSex.ForeColor = Color.RoyalBlue;
            lblSex.Location = new Point(224, 65);
            lblSex.Margin = new Padding(4, 0, 4, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(276, 23);
            lblSex.TabIndex = 6;
            lblSex.Text = "Tìm kiếm thông tin người dùng :";
            // 
            // btnRefreshInfo
            // 
            btnRefreshInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInfo.ForeColor = Color.MediumAquamarine;
            btnRefreshInfo.Location = new Point(983, 58);
            btnRefreshInfo.Margin = new Padding(4, 5, 4, 5);
            btnRefreshInfo.Name = "btnRefreshInfo";
            btnRefreshInfo.Size = new Size(37, 42);
            btnRefreshInfo.TabIndex = 3;
            btnRefreshInfo.UseVisualStyleBackColor = true;
            // 
            // btnSearchInfo
            // 
            btnSearchInfo.BackColor = SystemColors.MenuHighlight;
            btnSearchInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchInfo.ForeColor = Color.GhostWhite;
            btnSearchInfo.Location = new Point(856, 58);
            btnSearchInfo.Margin = new Padding(4, 5, 4, 5);
            btnSearchInfo.Name = "btnSearchInfo";
            btnSearchInfo.Size = new Size(119, 41);
            btnSearchInfo.TabIndex = 2;
            btnSearchInfo.Text = "Tìm kiếm";
            btnSearchInfo.UseVisualStyleBackColor = false;
            // 
            // txtSearchInfo
            // 
            txtSearchInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInfo.Location = new Point(507, 62);
            txtSearchInfo.Margin = new Padding(4, 5, 4, 5);
            txtSearchInfo.Name = "txtSearchInfo";
            txtSearchInfo.Size = new Size(341, 29);
            txtSearchInfo.TabIndex = 1;
            // 
            // dataInformation
            // 
            dataInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInformation.Location = new Point(8, 108);
            dataInformation.Margin = new Padding(4, 5, 4, 5);
            dataInformation.Name = "dataInformation";
            dataInformation.ReadOnly = true;
            dataInformation.RowHeadersWidth = 51;
            dataInformation.Size = new Size(1015, 286);
            dataInformation.TabIndex = 0;
            // 
            // frmAllInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 834);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAllInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CÁC THÔNG TIN NGƯỜI DÙNG";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataHistory).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataInformation;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.Button btnSearchInfo;
        private System.Windows.Forms.TextBox txtSearchInfo;
        private System.Windows.Forms.Button btnRefreshResult;
        private System.Windows.Forms.Button btnRefreshInfo;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSex;
    }
}