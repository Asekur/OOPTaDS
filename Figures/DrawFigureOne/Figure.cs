using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DrawFigureOne
{
    [Serializable]
    public abstract class Figure
    {
        public abstract void Display(Graphics e);
        public abstract void Change(System.Drawing.Point location);
        public abstract bool IsInFigure(System.Drawing.Rectangle cursor);
        public abstract Tuple<bool, Point> IsNearFigure(System.Drawing.Rectangle cursor);
        public abstract void RewriteFigure(int offsetX, int offsetY);
        public abstract void Rotate(int offsetX, int offsetY, Point checkPoint);
    }
}
