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
    public partial class ucSoDoBan : UserControl
    {
        private static ucSoDoBan _instance;

        public static ucSoDoBan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSoDoBan();
                return _instance;
            }
        }

        public ucSoDoBan()
        {
            InitializeComponent();
        }
    }
}
