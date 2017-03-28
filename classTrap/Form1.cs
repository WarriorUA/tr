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
        public bool flag = false;
        int num = 1;
        ClassPoint point = new ClassPoint();
        Chetur chetur = new Chetur();
        Trap trap = new Trap();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            flag = false;
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
            point = chetur;
            point.Draw(pictureBoxPaintong, es);
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
                    point = chetur;
                        point.RotatePaint(pictureBoxPaintong, es);
                        break;
                    }
                case 2:
                {
                    point = chetur;
                    point.RotatePouring(pictureBoxPaintong,es);
                        break;
                }
                case 3:
                {
                    point = trap;
                    point.RotatePaint(pictureBoxPaintong,es);
                        break;
                }
                case 4:
                {
                    point = trap;
                        point.RotatePouring(pictureBoxPaintong,es);
                        break;
                }
            }
        }

        private void buttonTrap_Click(object sender, EventArgs e)
        {
            flag = true;
            num = 3;
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            trap.setPoints();
            point = trap;
            point.Paint(pictureBoxPaintong, es);
        }

        private void buttonPouring_Click(object sender, EventArgs e)
        {

            num = 2;
            Graphics g = pictureBoxPaintong.CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            try
            {
                chetur.points[0].X = int.Parse(textBoxXA.Text);
                chetur.points[0].Y = int.Parse(textBoxYA.Text);
                chetur.points[1].X = int.Parse(textBoxXB.Text);
                chetur.points[1].Y = int.Parse(textBoxYB.Text);
                chetur.points[2].X = int.Parse(textBoxXC.Text);
                chetur.points[2].Y = int.Parse(textBoxYC.Text);
                chetur.points[3].X = int.Parse(textBoxXD.Text);
                chetur.points[3].Y = int.Parse(textBoxYD.Text);
                point = chetur;
                point.Pouring(pictureBoxPaintong, es);
            }
            catch
            {
               
            }
            if(flag)
            try
            {
                num = 4;
                point = trap;
                point.Pouring(pictureBoxPaintong, es);
            }
            catch
            {
            }

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
