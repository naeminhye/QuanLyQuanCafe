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
    public partial class ucDoanhSo : UserControl
    {
        private static ucDoanhSo _instance;

        public static ucDoanhSo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDoanhSo();
                return _instance;
            }
        }

        public ucDoanhSo()
        {
            InitializeComponent();
        }
    }
}
