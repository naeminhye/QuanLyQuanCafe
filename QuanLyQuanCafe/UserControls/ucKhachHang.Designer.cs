namespace QuanLyQuanCafe.UserControls
{
    partial class ucKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaoKH = new System.Windows.Forms.Button();
            this.tabControlKH = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlKH.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoKH.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTaoKH.FlatAppearance.BorderSize = 0;
            this.btnTaoKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoKH.ForeColor = System.Drawing.Color.White;
            this.btnTaoKH.Location = new System.Drawing.Point(975, 6);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(120, 36);
            this.btnTaoKH.TabIndex = 25;
            this.btnTaoKH.Text = "Tạo Thành Viên";
            this.btnTaoKH.UseVisualStyleBackColor = false;
            this.btnTaoKH.Click += new System.EventHandler(this.btnTaoKH_Click);
            // 
            // tabControlKH
            // 
            this.tabControlKH.Controls.Add(this.tabPage1);
            this.tabControlKH.Controls.Add(this.tabPage2);
            this.tabControlKH.ItemSize = new System.Drawing.Size(58, 30);
            this.tabControlKH.Location = new System.Drawing.Point(17, 16);
            this.tabControlKH.Name = "tabControlKH";
            this.tabControlKH.SelectedIndex = 0;
            this.tabControlKH.Size = new System.Drawing.Size(1109, 568);
            this.tabControlKH.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTaoKH);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thành Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhà Cung Cấp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlKH);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1141, 598);
            this.tabControlKH.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoKH;
        private System.Windows.Forms.TabControl tabControlKH;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
