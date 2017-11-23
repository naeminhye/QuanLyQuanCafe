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
    public partial class POS : Form
    {
        private int tabCount;

        public void showChiTietTT(bool value)
        {
            if (value)
            {
                pnlThanhToan.Visible = false;
                UserControl usercontrol = UserControls.ucCTThanhToan.Instance;
                if (!pnlPOS.Controls.Contains(usercontrol))
                {
                    pnlPOS.Controls.Add(usercontrol);
                    usercontrol.Dock = DockStyle.Fill;
                    usercontrol.BringToFront();
                }
                else usercontrol.BringToFront();
            }
            else
            {
                pnlThanhToan.Visible = true;
                showMenu();
            }
        }
        public POS()
        {
            InitializeComponent();
            showMenu();
            showChiTietTT(false);
            tabCount = tabControlPOS.TabCount;

            UserControl usercontrol = UserControls.ucSoDoBan.Instance;
            if (!khuVuc1.Controls.Contains(usercontrol))
            {
                khuVuc1.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        public void showMenu()
        {
            UserControl usercontrol = UserControls.ucThucDon.Instance;
            if (!pnlPOS.Controls.Contains(usercontrol))
            {
                pnlPOS.Controls.Add(usercontrol);
                usercontrol.Dock = DockStyle.Fill;
                usercontrol.BringToFront();
            }
            else usercontrol.BringToFront();
        }

        private void tsMenuSoDo_Click(object sender, EventArgs e)
        {
            SoDo mSoDo = new SoDo();
            mSoDo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
        }

        private void btnChiTietTT_Click(object sender, EventArgs e)
        {
            showChiTietTT(true);
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            string title = "Khu vực " + (tabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControlPOS.TabPages.Add(myTabPage);
            tabCount = tabCount + 1;
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            tabControlPOS.TabPages.Remove(tabControlPOS.SelectedTab);
        }
    }
}
