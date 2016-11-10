using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontMananger.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
            tblPnlBody.CellPaint += TableLayoutPanel1_CellPaint;
        }

        private void TableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Purple, e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds);
            }
            if (e.Column == 2 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.LimeGreen, e.CellBounds);
            }
        }
    }
}
