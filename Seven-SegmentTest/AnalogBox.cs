using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seven_SegmentTest
{
    public partial class AnalogBox : UserControl
    {
        public AnalogBox()
        {
            InitializeComponent();
        }

        public Color MyCol;
        public int R, G, B;

        public void setCol(Color Col)
        {
            pictureBox1.BackColor = Col;
            MyCol = Col;
            R = MyCol.R;
            G = MyCol.G;
            B = MyCol.B;
        }
    }
}
