namespace QuanLyQuanCafe.UserControls
{
    partial class ucTonKho
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
            this.tabControlTK = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControlTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTK
            // 
            this.tabControlTK.Controls.Add(this.tabPage1);
            this.tabControlTK.Controls.Add(this.tabPage2);
            this.tabControlTK.Controls.Add(this.tabPage3);
            this.tabControlTK.Controls.Add(this.tabPage4);
            this.tabControlTK.ItemSize = new System.Drawing.Size(58, 30);
            this.tabControlTK.Location = new System.Drawing.Point(16, 15);
            this.tabControlTK.Name = "tabControlTK";
            this.tabControlTK.SelectedIndex = 0;
            this.tabControlTK.Size = new System.Drawing.Size(1109, 568);
            this.tabControlTK.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tồn Kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1101, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập Xuất Tồn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1101, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kiểm Kê";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1101, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lịch Sử Định Lượng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ucTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTK);
            this.Name = "ucTonKho";
            this.Size = new System.Drawing.Size(1141, 598);
            this.tabControlTK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTK;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
