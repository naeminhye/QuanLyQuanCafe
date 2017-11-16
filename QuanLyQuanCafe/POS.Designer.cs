namespace QuanLyQuanCafe
{
    partial class POS
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xinChàoMinhHiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBCCuoiNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSoDo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuThietLap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlPOS = new System.Windows.Forms.TabControl();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoBep = new System.Windows.Forms.Button();
            this.btnChiTietTT = new System.Windows.Forms.Button();
            this.btnAddTab = new System.Windows.Forms.Button();
            this.btnRemoveTab = new System.Windows.Forms.Button();
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.btnSDB_TD = new System.Windows.Forms.Button();
            this.btnDangSD = new System.Windows.Forms.Button();
            this.btnConTrong = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControlPOS.SuspendLayout();
            this.pnlThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 35);
            this.textBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinChàoMinhHiếuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1060, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(281, 57);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xinChàoMinhHiếuToolStripMenuItem
            // 
            this.xinChàoMinhHiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuBCCuoiNgay,
            this.tsMenuSoDo,
            this.tsMenuDichVu,
            this.tsMenuThietLap,
            this.tsMenuQuanLy,
            this.toolStripSeparator1,
            this.tsMenuDangXuat});
            this.xinChàoMinhHiếuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xinChàoMinhHiếuToolStripMenuItem.Name = "xinChàoMinhHiếuToolStripMenuItem";
            this.xinChàoMinhHiếuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xinChàoMinhHiếuToolStripMenuItem.Size = new System.Drawing.Size(160, 53);
            this.xinChàoMinhHiếuToolStripMenuItem.Text = "Xin chào, Minh Hiếu";
            // 
            // tsMenuBCCuoiNgay
            // 
            this.tsMenuBCCuoiNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuBCCuoiNgay.Name = "tsMenuBCCuoiNgay";
            this.tsMenuBCCuoiNgay.Size = new System.Drawing.Size(208, 24);
            this.tsMenuBCCuoiNgay.Text = "Báo cáo cuối ngày";
            // 
            // tsMenuSoDo
            // 
            this.tsMenuSoDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuSoDo.Name = "tsMenuSoDo";
            this.tsMenuSoDo.Size = new System.Drawing.Size(208, 24);
            this.tsMenuSoDo.Text = "Sơ đồ bàn/phòng";
            this.tsMenuSoDo.Click += new System.EventHandler(this.tsMenuSoDo_Click);
            // 
            // tsMenuDichVu
            // 
            this.tsMenuDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuDichVu.Name = "tsMenuDichVu";
            this.tsMenuDichVu.Size = new System.Drawing.Size(208, 24);
            this.tsMenuDichVu.Text = "Dịch vụ tính theo giờ";
            // 
            // tsMenuThietLap
            // 
            this.tsMenuThietLap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuThietLap.Name = "tsMenuThietLap";
            this.tsMenuThietLap.Size = new System.Drawing.Size(208, 24);
            this.tsMenuThietLap.Text = "Thiết lập";
            // 
            // tsMenuQuanLy
            // 
            this.tsMenuQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuQuanLy.Name = "tsMenuQuanLy";
            this.tsMenuQuanLy.Size = new System.Drawing.Size(208, 24);
            this.tsMenuQuanLy.Text = "Quản lý";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // tsMenuDangXuat
            // 
            this.tsMenuDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsMenuDangXuat.Name = "tsMenuDangXuat";
            this.tsMenuDangXuat.Size = new System.Drawing.Size(208, 24);
            this.tsMenuDangXuat.Text = "Đăng xuất";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 491);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "#1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlPOS
            // 
            this.tabControlPOS.Controls.Add(this.tabPage1);
            this.tabControlPOS.ItemSize = new System.Drawing.Size(72, 38);
            this.tabControlPOS.Location = new System.Drawing.Point(12, 69);
            this.tabControlPOS.Name = "tabControlPOS";
            this.tabControlPOS.SelectedIndex = 0;
            this.tabControlPOS.Size = new System.Drawing.Size(623, 537);
            this.tabControlPOS.TabIndex = 16;
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlThanhToan.Controls.Add(this.lblThanhToan);
            this.pnlThanhToan.Controls.Add(this.label1);
            this.pnlThanhToan.Controls.Add(this.btnBaoBep);
            this.pnlThanhToan.Controls.Add(this.btnChiTietTT);
            this.pnlThanhToan.Location = new System.Drawing.Point(12, 612);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(623, 65);
            this.pnlThanhToan.TabIndex = 17;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.ForeColor = System.Drawing.Color.White;
            this.lblThanhToan.Location = new System.Drawing.Point(429, 18);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblThanhToan.Size = new System.Drawing.Size(25, 26);
            this.lblThanhToan.TabIndex = 21;
            this.lblThanhToan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thanh Toán";
            // 
            // btnBaoBep
            // 
            this.btnBaoBep.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBaoBep.FlatAppearance.BorderSize = 0;
            this.btnBaoBep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoBep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoBep.ForeColor = System.Drawing.Color.White;
            this.btnBaoBep.Location = new System.Drawing.Point(479, 0);
            this.btnBaoBep.Name = "btnBaoBep";
            this.btnBaoBep.Size = new System.Drawing.Size(72, 65);
            this.btnBaoBep.TabIndex = 18;
            this.btnBaoBep.Text = "Báo bếp";
            this.btnBaoBep.UseVisualStyleBackColor = false;
            // 
            // btnChiTietTT
            // 
            this.btnChiTietTT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChiTietTT.FlatAppearance.BorderSize = 0;
            this.btnChiTietTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietTT.ForeColor = System.Drawing.Color.White;
            this.btnChiTietTT.Location = new System.Drawing.Point(551, 0);
            this.btnChiTietTT.Name = "btnChiTietTT";
            this.btnChiTietTT.Size = new System.Drawing.Size(72, 65);
            this.btnChiTietTT.TabIndex = 19;
            this.btnChiTietTT.Text = "Chi tiết";
            this.btnChiTietTT.UseVisualStyleBackColor = false;
            this.btnChiTietTT.Click += new System.EventHandler(this.btnChiTietTT_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.BackColor = System.Drawing.Color.White;
            this.btnAddTab.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTab.ForeColor = System.Drawing.Color.Black;
            this.btnAddTab.Location = new System.Drawing.Point(594, 70);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(36, 36);
            this.btnAddTab.TabIndex = 18;
            this.btnAddTab.Text = "+";
            this.btnAddTab.UseVisualStyleBackColor = false;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.BackColor = System.Drawing.Color.White;
            this.btnRemoveTab.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTab.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTab.Location = new System.Drawing.Point(553, 70);
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveTab.TabIndex = 19;
            this.btnRemoveTab.Text = "-";
            this.btnRemoveTab.UseVisualStyleBackColor = false;
            this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
            // 
            // pnlPOS
            // 
            this.pnlPOS.Location = new System.Drawing.Point(641, 111);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(697, 566);
            this.pnlPOS.TabIndex = 20;
            // 
            // btnSDB_TD
            // 
            this.btnSDB_TD.BackColor = System.Drawing.Color.White;
            this.btnSDB_TD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSDB_TD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSDB_TD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDB_TD.ForeColor = System.Drawing.Color.Black;
            this.btnSDB_TD.Location = new System.Drawing.Point(1219, 69);
            this.btnSDB_TD.Name = "btnSDB_TD";
            this.btnSDB_TD.Size = new System.Drawing.Size(119, 36);
            this.btnSDB_TD.TabIndex = 21;
            this.btnSDB_TD.Text = "Xem sơ đồ bàn";
            this.btnSDB_TD.UseVisualStyleBackColor = false;
            this.btnSDB_TD.Click += new System.EventHandler(this.btnSDB_TD_Click);
            // 
            // btnDangSD
            // 
            this.btnDangSD.BackColor = System.Drawing.Color.White;
            this.btnDangSD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDangSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangSD.ForeColor = System.Drawing.Color.Black;
            this.btnDangSD.Location = new System.Drawing.Point(641, 69);
            this.btnDangSD.Name = "btnDangSD";
            this.btnDangSD.Size = new System.Drawing.Size(120, 36);
            this.btnDangSD.TabIndex = 22;
            this.btnDangSD.Text = "Đang sử dụng";
            this.btnDangSD.UseVisualStyleBackColor = false;
            // 
            // btnConTrong
            // 
            this.btnConTrong.BackColor = System.Drawing.Color.White;
            this.btnConTrong.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConTrong.ForeColor = System.Drawing.Color.Black;
            this.btnConTrong.Location = new System.Drawing.Point(767, 69);
            this.btnConTrong.Name = "btnConTrong";
            this.btnConTrong.Size = new System.Drawing.Size(93, 36);
            this.btnConTrong.TabIndex = 23;
            this.btnConTrong.Text = "Còn trống";
            this.btnConTrong.UseVisualStyleBackColor = false;
            this.btnConTrong.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(511, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 36);
            this.button6.TabIndex = 24;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnConTrong);
            this.Controls.Add(this.btnDangSD);
            this.Controls.Add(this.btnSDB_TD);
            this.Controls.Add(this.pnlPOS);
            this.Controls.Add(this.btnRemoveTab);
            this.Controls.Add(this.btnAddTab);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.tabControlPOS);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Name = "POS";
            this.Text = "POS Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlPOS.ResumeLayout(false);
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xinChàoMinhHiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBCCuoiNgay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSoDo;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDichVu;
        private System.Windows.Forms.ToolStripMenuItem tsMenuThietLap;
        private System.Windows.Forms.ToolStripMenuItem tsMenuQuanLy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlPOS;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoBep;
        private System.Windows.Forms.Button btnChiTietTT;
        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.Button btnRemoveTab;
        private System.Windows.Forms.Panel pnlPOS;
        private System.Windows.Forms.Button btnSDB_TD;
        private System.Windows.Forms.Button btnDangSD;
        private System.Windows.Forms.Button btnConTrong;
        private System.Windows.Forms.Button button6;
    }
}