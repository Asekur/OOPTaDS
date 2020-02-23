using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
{
    class Polygon : Figure
    {
        public List<Point> arr { get; set; }

        //construct
        public Polygon(Point X, List<Point> arrOfPoints) : base (X)
        {
            this.arr = arrOfPoints;
            Point start = new Point(getX(), getY());
            arr.Insert(0, start);
            arr.Insert(arr.Count, start);
        }
        public override void Display(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.DodgerBlue, 2);

            PointF[] masF = new PointF[arr.Count];
            Point[] mas = arr.ToArray();
            for (int i = 0; i < arr.Count; i++)
            {
                PointF insertPoint = new PointF(mas[i].valueX, mas[i].valueY);
                masF[i] = insertPoint;
            }
            gr.DrawPolygon(p, masF);
        }
    }
}
