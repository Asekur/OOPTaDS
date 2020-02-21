using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигня_какая_то
{
    public class Point
    {
        public float valueX { get; private set; }
        public float valueY { get; private set; }

        //construct
        public Point(float x, float y)
        {
            valueX = x;
            valueY = y;
        }
    }
}
