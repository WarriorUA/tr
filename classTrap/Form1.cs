using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classTrap
{
    public partial class Form1 : Form
    {
        int num = 1;
        Chetur chetur = new Chetur();
        Trap trap = new Trap();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            num = 1;
            chetur.setPoints();
            chetur.points[0].X = int.Parse(textBoxXA.Text);
            chetur.points[0].Y = int.Parse(textBoxYA.Text);
            chetur.points[1].X = int.Parse(textBoxXB.Text);
            chetur.points[1].Y = int.Parse(textBoxYB.Text);
            chetur.points[2].X = int.Parse(textBoxXC.Text);
            chetur.points[2].Y = int.Parse(textBoxYC.Text);
            chetur.points[3].X = int.Parse(textBoxXD.Text);
            chetur.points[3].Y = int.Parse(textBoxYD.Text);
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            chetur.Draw(pictureBoxPaintong, es);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            //chetur.far = 0;
            //trap.far = 0;
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            switch (num)
            {
                case 1:
                    {
                        chetur.RotatePaint(pictureBoxPaintong, es);
                        break;
                    }
                case 2:
                {
                    chetur.RotatePouring(pictureBoxPaintong,es);
                        break;
                }
                case 3:
                {
                    trap.Rotate(pictureBoxPaintong,es);
                        break;
                }
            }
        }

        private void buttonTrap_Click(object sender, EventArgs e)
        {
            num = 3;
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            trap.setPoints();
            trap.Paint(pictureBoxPaintong, es);
        }

        private void buttonPouring_Click(object sender, EventArgs e)
        {
            num = 2;
            chetur.setPoints();
            chetur.points[0].X = int.Parse(textBoxXA.Text);
            chetur.points[0].Y = int.Parse(textBoxYA.Text);
            chetur.points[1].X = int.Parse(textBoxXB.Text);
            chetur.points[1].Y = int.Parse(textBoxYB.Text);
            chetur.points[2].X = int.Parse(textBoxXC.Text);
            chetur.points[2].Y = int.Parse(textBoxYC.Text);
            chetur.points[3].X = int.Parse(textBoxXD.Text);
            chetur.points[3].Y = int.Parse(textBoxYD.Text);
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            chetur.Pouring(pictureBoxPaintong, es);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            chetur.Clear(pictureBoxPaintong, es);
        }
    }
}
