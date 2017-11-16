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
    public partial class ucNhapKho : UserControl
    {
        private static ucNhapKho _instance;

        public static ucNhapKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNhapKho();
                return _instance;
            }
        }

        public ucNhapKho()
        {
            InitializeComponent();
        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            TaoPhieuNhapKho childform = new TaoPhieuNhapKho();
            childform.ShowDialog();
        }
    }
}
