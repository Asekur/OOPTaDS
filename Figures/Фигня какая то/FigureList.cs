using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигня_какая_то
{
    class FigureList
    {
        public List<Figure> list = new List<Figure>();
        public int getSize = 0;

        public void Add(Figure figureNew)
        {
            list.Add(figureNew);
            getSize++;
        }

        public Figure getFigure(int i)
        {
            return list[i];
        }
    }
}
