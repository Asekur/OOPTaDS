using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
{
    [Serializable]
    class Rectangle : Figure
    {
        public Point leftPoint { get; set; }
        public Point rightPoint { get; set; }
        private List<Point> arr { get; set; }
        private Color pColor;

        //construct
        public Rectangle(List<Point> arrOfPoints, Color pColor)
        {
            Point lrPoint = new Point(arrOfPoints[1].valueX, arrOfPoints[0].valueY);
            Point rlPoint = new Point(arrOfPoints[0].valueX, arrOfPoints[1].valueY);

            arr = new List<Point>();
            arr.Add(arrOfPoints[0]);
            arr.Add(lrPoint);
            arr.Add(arrOfPoints[1]);
            arr.Add(rlPoint);
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

        public override void Change(System.Drawing.Point location)
        {
            List<float> substractionX = new List<float>();
            List<float> substractionY = new List<float>();
            for (int i = 1; i < arr.Count; i++)
            {
                substractionX.Add(this.arr[0].valueX - this.arr[i].valueX);
                substractionY.Add(this.arr[0].valueY - this.arr[i].valueY);
            }
            this.arr[0].valueX = location.X;
            this.arr[0].valueY = location.Y;
            for (int i = 1; i < arr.Count; i++)
            {
                arr[i].valueX = this.arr[0].valueX + substractionX[i - 1];
                arr[i].valueY = this.arr[0].valueY + substractionY[i - 1];
            }
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
                 (maxX > cursor.Right) && (maxY > cursor.Bottom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Tuple<bool, Point> IsNearFigure(System.Drawing.Rectangle cursor)
        {
            foreach (Point p in arr)
            {
                if (p == this.arr[0] || p == this.arr[2])
                {
                    //if cursor near figure
                    if (((cursor.X > p.valueX - 10) && (cursor.X < p.valueX + 10) &&
                        (cursor.Y > p.valueY - 10) && (cursor.Y < p.valueY + 10)) ||
                       ((cursor.X > p.valueX - 10) && (cursor.X < p.valueX + 10) &&
                        (cursor.Bottom > p.valueY - 10) && (cursor.Bottom < p.valueY + 10)))
                    {
                        return Tuple.Create(true, p);
                    }
                }
            }
            return Tuple.Create(false, this.arr[0]);
        }

        public override void RewriteFigure(int offsetX, int offsetY)
        {
            foreach (Point p in arr)
            {
                p.valueX += offsetX;
                p.valueY += offsetY;
            }
        }

        public override void Rotate(int offsetX, int offsetY, Point checkPoint)
        {
            foreach (Point p in arr)
            {
                if (p == checkPoint)
                {
                    if (p == this.arr[0])
                    {
                        this.arr[1].valueY += offsetY;
                        this.arr[3].valueX += offsetX;
                    }
                    else
                    {
                        this.arr[1].valueX += offsetX;
                        this.arr[3].valueY += offsetY;
                    }
                    p.valueX += offsetX;
                    p.valueY += offsetY;
                }
            }
        }
    }
}
