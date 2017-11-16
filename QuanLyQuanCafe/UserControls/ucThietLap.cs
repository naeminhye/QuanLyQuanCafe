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
    public partial class ucThietLap : UserControl
    {
        private static ucThietLap _instance;

        public static ucThietLap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThietLap();
                return _instance;
            }
        }

        public ucThietLap()
        {
            InitializeComponent();
        }
    }
}
