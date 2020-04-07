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
                 (this.rightPointEllipse.valueX > cursor.Width) && (this.rightPointEllipse.valueY > cursor.Height))
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
            this.leftPointEllipse.valueX += offsetX;
            this.rightPointEllipse.valueX += offsetX;
            this.leftPointEllipse.valueY += offsetY;
            this.rightPointEllipse.valueY += offsetY;
        }
    }
}
