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
    public partial class ucTongQuan : UserControl
    {
        private static ucTongQuan _instance;

        public static ucTongQuan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTongQuan();
                return _instance;
            }
        }

        public ucTongQuan()
        {
            InitializeComponent();
        }

        private void ucTongQuan_Load(object sender, EventArgs e)
        {

        }
    }
}
