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
    public partial class ucDonHang : UserControl
    {
        private static ucDonHang _instance;

        public static ucDonHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDonHang();
                return _instance;
            }
        }

        public ucDonHang()
        {
            InitializeComponent();
        }

        private void ucDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
