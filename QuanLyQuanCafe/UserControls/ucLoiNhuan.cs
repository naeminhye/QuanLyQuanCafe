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
    public partial class ucLoiNhuan : UserControl
    {
        private static ucLoiNhuan _instance;

        public static ucLoiNhuan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoiNhuan();
                return _instance;
            }
        }

        public ucLoiNhuan()
        {
            InitializeComponent();
        }
    }
}
