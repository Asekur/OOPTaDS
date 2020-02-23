using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
{
    class Ellipse : Figure
    {
        public Point rightPointEllipse { get; set; }

        //construct
        public Ellipse(Point X, Point Y) : base(X)
        {
            this.rightPointEllipse = Y;
        }
        public override void Display(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 2);
            gr.DrawEllipse(p, (int)getX(), (int)getY(), (int)rightPointEllipse.valueX, (int)rightPointEllipse.valueY);
            gr.Dispose();
        }
    }
}
