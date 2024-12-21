namespace WindowsFormsApp10
{
    partial class phanhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(phanhoi));
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cmbMucDoHaiLong = new System.Windows.Forms.ComboBox();
            this.btnThemPhanHoi = new System.Windows.Forms.Button();
            this.dgvPhanHoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(249, 491);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(213, 23);
            this.txtNoiDung.TabIndex = 0;
            // 
            // cmbMucDoHaiLong
            // 
            this.cmbMucDoHaiLong.FormattingEnabled = true;
            this.cmbMucDoHaiLong.Items.AddRange(new object[] {
            "Tốt",
            "Bình thường",
            "Kém"});
            this.cmbMucDoHaiLong.Location = new System.Drawing.Point(495, 490);
            this.cmbMucDoHaiLong.Name = "cmbMucDoHaiLong";
            this.cmbMucDoHaiLong.Size = new System.Drawing.Size(121, 24);
            this.cmbMucDoHaiLong.TabIndex = 1;
            // 
            // btnThemPhanHoi
            // 
            this.btnThemPhanHoi.Location = new System.Drawing.Point(650, 490);
            this.btnThemPhanHoi.Name = "btnThemPhanHoi";
            this.btnThemPhanHoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhanHoi.TabIndex = 2;
            this.btnThemPhanHoi.Text = "Nộp";
            this.btnThemPhanHoi.UseVisualStyleBackColor = true;
            this.btnThemPhanHoi.Click += new System.EventHandler(this.btnThemPhanHoi_Click);
            // 
            // dgvPhanHoi
            // 
            this.dgvPhanHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanHoi.Location = new System.Drawing.Point(8, 102);
            this.dgvPhanHoi.Name = "dgvPhanHoi";
            this.dgvPhanHoi.RowHeadersWidth = 51;
            this.dgvPhanHoi.RowTemplate.Height = 24;
            this.dgvPhanHoi.Size = new System.Drawing.Size(1136, 326);
            this.dgvPhanHoi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phản hôi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đánh giá mức độ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mời nhập phản hồi vào ";
            // 
            // phanhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 697);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhanHoi);
            this.Controls.Add(this.btnThemPhanHoi);
            this.Controls.Add(this.cmbMucDoHaiLong);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "phanhoi";
            this.Text = "Phản Hồi";
            this.Load += new System.EventHandler(this.phanhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cmbMucDoHaiLong;
        private System.Windows.Forms.Button btnThemPhanHoi;
        private System.Windows.Forms.DataGridView dgvPhanHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}