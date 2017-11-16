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
    public partial class ucThucDon : UserControl
    {
        private static ucThucDon _instance;

        public static ucThucDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThucDon();
                return _instance;
            }
        }

        public ucThucDon()
        {
            InitializeComponent();
        }
    }
}
