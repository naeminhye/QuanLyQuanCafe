using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            UserControl usercontrol = UserControls.ucTongQuan.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            POS mPOS = new POS();
            mPOS.Show();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucTongQuan.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucDonHang.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucNhapKho.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucHangHoa.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucKhachHang.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucTonKho.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnDoanhSo_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucDoanhSo.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucThuChi.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnLoiNhuan_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucLoiNhuan.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            UserControl usercontrol = UserControls.ucThietLap.Instance;
            if (!dashboardPanel.Controls.Contains(usercontrol))
            {
                dashboardPanel.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }
        
    }
}
