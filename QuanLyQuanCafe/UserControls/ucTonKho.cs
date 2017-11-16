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
    public partial class ucTonKho : UserControl
    {
        private static ucTonKho _instance;

        public static ucTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTonKho();
                return _instance;
            }
        }

        public ucTonKho()
        {
            InitializeComponent();
        }
    }
}
