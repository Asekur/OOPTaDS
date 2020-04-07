using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
{
    class Rectangle : Figure
    {
        public Point leftPoint { get; set; }
        public Point rightPoint { get; set; }
        private Color pColor;

        //construct
        public Rectangle(Point X, Point Y, Color pColor)
        {
            this.leftPoint = X;
            this.rightPoint = Y;
            this.pColor = pColor;
        }

        public override void Display(Graphics gr)
        {
            Pen p = new Pen(this.pColor, 2);
            int width = Math.Abs((int)(rightPoint.valueX - leftPoint.valueX));
            int height = Math.Abs((int)(rightPoint.valueY - leftPoint.valueY));
            gr.DrawRectangle(p, (int)leftPoint.valueX, (int)leftPoint.valueY, width, height);
        }

        public override bool IsInFigure(System.Drawing.Rectangle cursor)
        {
            if ((this.leftPoint.valueX < cursor.X) && (this.leftPoint.valueY < cursor.Y) &&
                 (this.rightPoint.valueX > cursor.Width) && (this.rightPoint.valueY > cursor.Height))
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
            this.leftPoint.valueX += offsetX;
            this.rightPoint.valueX += offsetX;
            this.leftPoint.valueY += offsetY;
            this.rightPoint.valueY += offsetY;
        }
    }
}
