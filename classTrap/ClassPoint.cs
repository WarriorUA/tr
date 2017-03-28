using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classTrap
{
    public class ClassPoint//абстрактнй класс
    {
        public const int countPoints = 4;
        public Point[] points;

        public virtual void setPoints()
        {
            points = new Point[countPoints];
            points[0].X = 0;
            points[0].Y = 50;
            points[1].X = 0;
            points[1].Y = 100;
            points[2].X = 100;
            points[2].Y = 150;
            points[3].X = 100;
            points[3].Y = 0;
        }

        public virtual void Paint()
        {
            
        }//абстрактный метод
    }

    class Trap : ClassPoint
    {
        public float far = 0;
        public override void setPoints()//полиморфизм, перегруженный метод
        {
            points = new Point[countPoints];
            points[0].X = 0;
            points[0].Y = 50;
            points[1].X = 0;
            points[1].Y = 100;
            points[2].X = 100;
            points[2].Y = 150;
            points[3].X = 100;
            points[3].Y = 0;
        }
        public void Paint(object sender, PaintEventArgs e)//рисование
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillPolygon(new SolidBrush(Color.Aqua), points);
        }
        public void Rotate(object sender, PaintEventArgs e)//поворот
        {
            far += 30;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            e.Graphics.RotateTransform(far);//угол поворота
            e.Graphics.TranslateTransform(100.0F, 0.0F);//поворот, в остальных поворотах все то же
            g.DrawPolygon(new Pen(Color.Black, 2), points);
        }
    }

    class Chetur : ClassPoint
    {
        public float far = 0;
        public override void setPoints()//полиморфизм, перегруженный метод
        {
            points = new Point[countPoints];
        }
        public void Draw(object sender, PaintEventArgs e)//рисование
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawPolygon(new Pen(Color.Black,2),points );
        }
        public void Pouring(object sender, PaintEventArgs e)//закрашивание
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillPolygon(new SolidBrush(Color.Aqua), points);
        }
        public void RotatePaint(object sender, PaintEventArgs e)//поворот нарисованной трапеции
        {
            far += 30;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            e.Graphics.RotateTransform(far);
            e.Graphics.TranslateTransform(100.0F, 0.0F);
            g.DrawPolygon(new Pen(Color.Black, 2), points);
        }
        public void RotatePouring(object sender, PaintEventArgs e)//поворот закрашенной трапеции
        {
            far += 30;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            e.Graphics.RotateTransform(far);
            e.Graphics.TranslateTransform(100.0F, 0.0F);
            g.FillPolygon(new SolidBrush(Color.Aqua), points);
        }
        public void Clear(object sender, PaintEventArgs e)//метод очистки
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
        }
    }
}
