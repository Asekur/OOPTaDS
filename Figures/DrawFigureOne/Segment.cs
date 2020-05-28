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
    class Segment : Figure
    {
        public Point startLine { get; set; }
        public Point endLine { get; set; }
        private Color pColor;


        //construct
        public Segment(List<Point> arrOfPoints, Color pColor)
        {
            this.startLine = arrOfPoints[0];
            this.endLine = arrOfPoints[1];
            this.pColor = pColor;
        }

        public override void Display(Graphics gr)
        {
            Pen p = new Pen(this.pColor, 2);
            gr.DrawLine(p, (int)startLine.valueX, (int)startLine.valueY, (int)endLine.valueX, (int)endLine.valueY);
        }

        public override void Change(System.Drawing.Point location)
        {
            float substractionX = this.endLine.valueX - this.startLine.valueX;
            float substractionY = this.endLine.valueY - this.startLine.valueY;
            this.startLine.valueX = location.X;
            this.startLine.valueY = location.Y;
            this.endLine.valueX = this.startLine.valueX + substractionX;
            this.endLine.valueY = this.startLine.valueY + substractionY;
        }

        public override bool IsInFigure(System.Drawing.Rectangle cursor)
        {
            if ((this.startLine.valueX < cursor.X) && (this.startLine.valueY < cursor.Y) &&
                 (this.endLine.valueX > cursor.Right) && (this.endLine.valueY > cursor.Bottom))
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
            if ((cursor.Bottom < this.startLine.valueY - 3 && cursor.Bottom > this.startLine.valueY - 13) && 
                    (cursor.X < this.startLine.valueX + 3 && cursor.X > this.startLine.valueX - 13))
            {
                return Tuple.Create(true, this.startLine);

            }
            else
            {
                if ((cursor.Bottom < this.endLine.valueY + 13 && cursor.Bottom > this.endLine.valueY - 3) &&
                    (cursor.X > this.endLine.valueX + 3 && cursor.X < this.endLine.valueX + 13))
                {
                    return Tuple.Create(true, this.endLine);

                }
                else
                {
                    return Tuple.Create(false, this.startLine);
                }
            }
        }

        public override void RewriteFigure(int offsetX, int offsetY)
        {
            this.startLine.valueX += offsetX;
            this.endLine.valueX += offsetX;
            this.startLine.valueY += offsetY;
            this.endLine.valueY += offsetY;
        }

        public override void Rotate(int offsetX, int offsetY, Point checkPoint)
        {
            if (this.startLine == checkPoint)
            {
                this.startLine.valueX += offsetX;
                this.startLine.valueY += offsetY;
            }
            else if (this.endLine == checkPoint)
            {
                this.endLine.valueX += offsetX;
                this.endLine.valueY += offsetY;
            }
        }
    }

}
