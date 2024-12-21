namespace WindowsFormsApp10
{
    partial class tinhtrangban
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
            this.btnBan1 = new System.Windows.Forms.Button();
            this.btnBan2 = new System.Windows.Forms.Button();
            this.btnBan3 = new System.Windows.Forms.Button();
            this.cbBan1 = new System.Windows.Forms.CheckBox();
            this.cbBan2 = new System.Windows.Forms.CheckBox();
            this.cbBan3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBan1
            // 
            this.btnBan1.Location = new System.Drawing.Point(191, 104);
            this.btnBan1.Name = "btnBan1";
            this.btnBan1.Size = new System.Drawing.Size(138, 71);
            this.btnBan1.TabIndex = 0;
            this.btnBan1.Text = "Table 1";
            this.btnBan1.UseVisualStyleBackColor = true;
            this.btnBan1.Click += new System.EventHandler(this.btnBan1_Click);
            // 
            // btnBan2
            // 
            this.btnBan2.Location = new System.Drawing.Point(191, 246);
            this.btnBan2.Name = "btnBan2";
            this.btnBan2.Size = new System.Drawing.Size(138, 71);
            this.btnBan2.TabIndex = 1;
            this.btnBan2.Text = "Table 2";
            this.btnBan2.UseVisualStyleBackColor = true;
            this.btnBan2.Click += new System.EventHandler(this.btnBan2_Click);
            // 
            // btnBan3
            // 
            this.btnBan3.Location = new System.Drawing.Point(191, 395);
            this.btnBan3.Name = "btnBan3";
            this.btnBan3.Size = new System.Drawing.Size(138, 71);
            this.btnBan3.TabIndex = 2;
            this.btnBan3.Text = "Table 3";
            this.btnBan3.UseVisualStyleBackColor = true;
            this.btnBan3.Click += new System.EventHandler(this.btnBan3_Click);
            // 
            // cbBan1
            // 
            this.cbBan1.AutoSize = true;
            this.cbBan1.Location = new System.Drawing.Point(371, 130);
            this.cbBan1.Name = "cbBan1";
            this.cbBan1.Size = new System.Drawing.Size(74, 20);
            this.cbBan1.TabIndex = 3;
            this.cbBan1.Text = "Đặt bàn";
            this.cbBan1.UseVisualStyleBackColor = true;
            this.cbBan1.CheckedChanged += new System.EventHandler(this.cbBan1_CheckedChanged);
            // 
            // cbBan2
            // 
            this.cbBan2.AutoSize = true;
            this.cbBan2.Location = new System.Drawing.Point(371, 272);
            this.cbBan2.Name = "cbBan2";
            this.cbBan2.Size = new System.Drawing.Size(74, 20);
            this.cbBan2.TabIndex = 4;
            this.cbBan2.Text = "Đặt bàn";
            this.cbBan2.UseVisualStyleBackColor = true;
            this.cbBan2.CheckedChanged += new System.EventHandler(this.cbBan2_CheckedChanged);
            // 
            // cbBan3
            // 
            this.cbBan3.AutoSize = true;
            this.cbBan3.Location = new System.Drawing.Point(371, 421);
            this.cbBan3.Name = "cbBan3";
            this.cbBan3.Size = new System.Drawing.Size(74, 20);
            this.cbBan3.TabIndex = 5;
            this.cbBan3.Text = "Đặt bàn";
            this.cbBan3.UseVisualStyleBackColor = true;
            this.cbBan3.CheckedChanged += new System.EventHandler(this.cbBan3_CheckedChanged);
            // 
            // tinhtrangban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 673);
            this.Controls.Add(this.cbBan3);
            this.Controls.Add(this.cbBan2);
            this.Controls.Add(this.cbBan1);
            this.Controls.Add(this.btnBan3);
            this.Controls.Add(this.btnBan2);
            this.Controls.Add(this.btnBan1);
            this.Name = "tinhtrangban";
            this.Text = "Tình Trạng Bàn";
            this.Load += new System.EventHandler(this.tinhtrangban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBan1;
        private System.Windows.Forms.Button btnBan2;
        private System.Windows.Forms.Button btnBan3;
        private System.Windows.Forms.CheckBox cbBan1;
        private System.Windows.Forms.CheckBox cbBan2;
        private System.Windows.Forms.CheckBox cbBan3;
    }
}