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
    class Ellipse : Figure
    {
        public Point leftPointEllipse { get; set; }
        public Point rightPointEllipse { get; set; }
        private Color pColor;

        //construct
        public Ellipse(Point X, Point Y, Color pColor)
        {
            this.leftPointEllipse = X;
            this.rightPointEllipse = Y;
            this.pColor = pColor;
        }
        public override void Display(Graphics gr)
        {
            Pen p = new Pen(this.pColor, 2);
            int width = Math.Abs((int)(rightPointEllipse.valueX - leftPointEllipse.valueX));
            int height = Math.Abs((int)(rightPointEllipse.valueY - leftPointEllipse.valueY));
            gr.DrawEllipse(p, (int)leftPointEllipse.valueX, (int)leftPointEllipse.valueY, width, height);
        }

        public override bool IsInFigure(System.Drawing.Rectangle cursor)
        {
            if ((this.leftPointEllipse.valueX < cursor.X) && (this.leftPointEllipse.valueY < cursor.Y) &&
                 (this.rightPointEllipse.valueX > cursor.Right) && (this.rightPointEllipse.valueY > cursor.Bottom))
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
            if ((cursor.Bottom < this.leftPointEllipse.valueY - 3 && cursor.Bottom > this.leftPointEllipse.valueY - 13) &&
                    (cursor.X < this.leftPointEllipse.valueX + 3 && cursor.X > this.leftPointEllipse.valueX - 13))
            {
                return Tuple.Create(true, this.leftPointEllipse);
            }
            else
            {
                if ((cursor.Bottom < this.rightPointEllipse.valueY + 13 && cursor.Bottom > this.rightPointEllipse.valueY - 3) &&
                    (cursor.X > this.rightPointEllipse.valueX + 3 && cursor.X < this.rightPointEllipse.valueX + 13))
                {
                    return Tuple.Create(true, this.rightPointEllipse);
                }
                else
                {
                    return Tuple.Create(false, this.leftPointEllipse);
                }
            }
        }

        public override void RewriteFigure(int offsetX, int offsetY)
        {
            this.leftPointEllipse.valueX += offsetX;
            this.rightPointEllipse.valueX += offsetX;
            this.leftPointEllipse.valueY += offsetY;
            this.rightPointEllipse.valueY += offsetY;
        }

        public override void Rotate(int offsetX, int offsetY, Point checkPoint)
        {
            if (this.leftPointEllipse == checkPoint)
            {
                this.leftPointEllipse.valueX += offsetX;
                this.leftPointEllipse.valueY += offsetY;
            }
            else if (this.rightPointEllipse == checkPoint)
            {
                this.rightPointEllipse.valueX += offsetX;
                this.rightPointEllipse.valueY += offsetY;
            }
        }
    }
}
