using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Bitmap p = new Bitmap(1, 1);
            p.SetPixel(0, 0, Color.Black);
            g.DrawImageUnscaled(p, 100, 100);
            g.FillEllipse(Brushes.Black, 100, 100,100,100);
        }
    }
}
