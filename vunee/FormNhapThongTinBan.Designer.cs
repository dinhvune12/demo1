namespace WindowsFormsApp10
{
    partial class FormNhapThongTinBan
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.pictureBoxBan = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(178, 36);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(342, 23);
            this.txtSoLuong.TabIndex = 0;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(178, 108);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(342, 23);
            this.txtHang.TabIndex = 1;
            // 
            // pictureBoxBan
            // 
            this.pictureBoxBan.Location = new System.Drawing.Point(768, 12);
            this.pictureBoxBan.Name = "pictureBoxBan";
            this.pictureBoxBan.Size = new System.Drawing.Size(311, 280);
            this.pictureBoxBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBan.TabIndex = 2;
            this.pictureBoxBan.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(577, 36);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(147, 95);
            this.btnChonAnh.TabIndex = 3;
            this.btnChonAnh.Text = "Ảnh của bàn";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(483, 488);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(262, 115);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Thêm";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số lượng người có thế chứa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hãng sản xuất";
            // 
            // FormNhapThongTinBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.pictureBoxBan);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.txtSoLuong);
            this.Name = "FormNhapThongTinBan";
            this.Load += new System.EventHandler(this.FormNhapThongTinBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.PictureBox pictureBoxBan;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}