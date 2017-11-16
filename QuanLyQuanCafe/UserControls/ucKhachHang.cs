using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.UserControls
{
    public partial class ucKhachHang : UserControl
    {
        private static ucKhachHang _instance;

        public static ucKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKhachHang();
                return _instance;
            }
        }

        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            TaoKH kh = new TaoKH();
            kh.ShowDialog();
        }
    }
}
