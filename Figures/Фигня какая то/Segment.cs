using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Фигня_какая_то
{
    class Segment : Figure
    {
        public Point endLine { get; set; }

        //construct
        public Segment( Point X, Point Y) : base (X)
        {
            this.endLine = Y;
        }
        public override void Display(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 2);
            PointF pointOne = new PointF(getX(), getY());
            PointF pointTwo = new PointF(endLine.valueX, endLine.valueY);
            gr.DrawLine(p, pointOne, pointTwo);
            gr.Dispose();
        }

    }

}
