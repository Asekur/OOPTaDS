using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Фигня_какая_то
{
    class Rectangle : Figure
    {
        public Point rightPoint { get; set; }

        //construct
        public Rectangle(Point X, Point Y) : base (X)
        {
            this.rightPoint = Y;
        }

        public override void Display(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 2);
            gr.DrawRectangle(p, (int)getX(), (int)getY(), (int)rightPoint.valueX, (int)rightPoint.valueY);
            gr.Dispose();
        }
    }
}
