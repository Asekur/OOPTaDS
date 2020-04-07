using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
{
    class Segment : Figure
    {
        public Point startLine { get; set; }
        public Point endLine { get; set; }
        private Color pColor;

        //construct
        public Segment( Point X, Point Y, Color pColor)
        {
            this.startLine = X;
            this.endLine = Y;
            this.pColor = pColor;
        }
        public override void Display(Graphics gr)
        {
            Pen p = new Pen(this.pColor, 2);
            gr.DrawLine(p, (int)startLine.valueX, (int)startLine.valueY, (int)endLine.valueX, (int)endLine.valueY);
        }

        public override bool IsInFigure(System.Drawing.Rectangle cursor)
        {
            if ((this.startLine.valueX < cursor.X) && (this.startLine.valueY < cursor.Y) &&
                 (this.endLine.valueX > cursor.Width) && (this.endLine.valueY > cursor.Height))
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
            this.startLine.valueX += offsetX;
            this.endLine.valueX += offsetX;
            this.startLine.valueY += offsetY;
            this.endLine.valueY += offsetY;
        }
    }

}
