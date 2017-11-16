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
    public partial class ucCTThanhToan : UserControl
    {
        private static ucCTThanhToan _instance;

        public static ucCTThanhToan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCTThanhToan();
                return _instance;
            }
        }

        public ucCTThanhToan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((POS)(this.ParentForm)).showChiTietTT(false);
        }
    }
}
