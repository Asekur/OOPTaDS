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
        public Color pColor;

        //construct
        public Polygon(List<Point> arrOfPoints, Color pColor)
        {
            this.arr = arrOfPoints;
            arr.Insert(arr.Count, arrOfPoints[0]);
            this.pColor = pColor;
        }
        public override void Display(Graphics gr)
        {
            Pen p = new Pen(this.pColor, 2);

            PointF[] masF = new PointF[arr.Count];
            Point[] mas = arr.ToArray();
            for (int i = 0; i < arr.Count; i++)
            {
                PointF insertPoint = new PointF(mas[i].valueX, mas[i].valueY);
                masF[i] = insertPoint;
            }
            gr.DrawPolygon(p, masF);
        }

        public override bool IsInFigure(System.Drawing.Rectangle cursor)
        {
            //minimal and maximal X
            float maxX = this.arr[0].valueX;
            float minX = this.arr[0].valueX;
            foreach (Point p in arr) 
            {
                if (p.valueX > maxX)
                {
                    maxX = p.valueX;
                }
                if (p.valueX < minX)
                {
                    minX = p.valueX;
                }
            }

            //minimal and maximal Y
            float maxY = this.arr[0].valueY;
            float minY = this.arr[0].valueY;
            foreach (Point p in arr)
            {
                if (p.valueY > maxY)
                {
                    maxY = p.valueY;
                }
                if (p.valueY < minY)
                {
                    minY = p.valueY;
                }
            }

            if ((minX < cursor.X) && (minY < cursor.Y) &&
                 (maxX > cursor.Width) && (maxY > cursor.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void RewriteFigure(int offsetX, int offsetY)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                this.arr[i].valueX += offsetX;
                this.arr[i].valueY += offsetY;
            }
        }
    }
}
