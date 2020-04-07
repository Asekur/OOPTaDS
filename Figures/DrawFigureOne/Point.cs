using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigureOne
{
    public class Point
    {
        public float valueX { get; set; }
        public float valueY { get; set; }

        //construct
        public Point(float x, float y)
        {
            valueX = x;
            valueY = y;
        }
    }
}
