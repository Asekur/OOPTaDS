using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фигня_какая_то
{
    public abstract class Figure
    {
        public Point start { get; set; }
        public Figure (Point X)
        {
            this.start = X;
        }

        public float getX()
        {
            return start.valueX;
        }

        public float getY()
        {
            return start.valueY;
        }

        public abstract void Display(PaintEventArgs e);
    }
}
