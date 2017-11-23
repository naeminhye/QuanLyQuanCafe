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
        private List<Control> controlList;
        //private int tableMax = 20;
        private int tableCount; // So ban cua KV
        private int selectedTable;

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
            tableCount = 1;
            selectedTable = 0;
            controlList = GetControlHierarchy(this).ToList();
            refresh();
        }

        private IEnumerable<Control> GetControlHierarchy(Control root)
        {
            var queue = new Queue<Control>();

            queue.Enqueue(root);

            do
            {
                var control = queue.Dequeue();

                yield return control;

                foreach (var child in control.Controls.OfType<Control>())
                    queue.Enqueue(child);

            } while (queue.Count > 0);

        }

        public void refresh()
        {
            for (var i = 0; i < controlList.Count; i++)
            {
                if (controlList[i].GetType().Name == "Panel")
                {
                    var tableNumber = controlList[i].TabIndex;
                    if(tableNumber == selectedTable)
                    {
                        controlList[i].BackColor = Color.DarkOrange;
                    }
                    else controlList[i].BackColor = Color.DodgerBlue;
                    
                    if (tableNumber <= tableCount)
                    {
                        controlList[i].Visible = true;
                        var panelList = GetControlHierarchy(controlList[i]).ToList();
                        foreach (var child in panelList)
                        {
                            if (child.GetType().Name == "Label")
                            {
                                child.Text = tableNumber.ToString();
                            }
                        }
                    }
                    else controlList[i].Visible = false;
                }
            }
        }

        private void btnKV1Ban1_Click(object sender, EventArgs e)
        {
            //((POS)(this.ParentForm)).showChiTietTT(true);
        }

        private void pnlBan_DoubleClick(object sender, EventArgs e)
        {
            ((POS)(this.ParentForm)).showChiTietTT(true);
        }

        private void pnlBan_Click(object sender, EventArgs e, Control table)
        {
            selectedTable = table.TabIndex;
            refresh();
        }

        private void nudTableCount_ValueChanged(object sender, EventArgs e)
        {
            tableCount = Decimal.ToInt32(nudTableCount.Value);
            refresh();
        }
    }
}
