using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DrawFigureOne
{
    [Serializable]
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

        public void Display(Graphics gr)
        {
            foreach (Figure fig in list)
            {
                fig.Display(gr);
            }
        }

        //check for sizeAll cursor
        public Figure CheckCursorSizeAll(System.Drawing.Point ptn)
        {
            Figure result = null;
            System.Drawing.Rectangle cursorArea = 
                new System.Drawing.Rectangle(ptn.X - 2, ptn.Y - 2, 4, 4);
            foreach (Figure fig in list)
            {
                if (fig.IsInFigure(cursorArea))
                {
                    result = fig;
                }
            }
            return result;
        }

        //check for Hand cursor
        public Tuple<Figure, Point> CheckCursorHand(System.Drawing.Point ptn)
        {
            System.Drawing.Rectangle cursorArea =
                new System.Drawing.Rectangle(ptn.X - 5, ptn.Y - 5, 10, 10);
            foreach (Figure fig in list)
            {
                if (fig.IsNearFigure(cursorArea).Item1)
                {
                    return Tuple.Create(fig, fig.IsNearFigure(cursorArea).Item2);
                }
            }
            Point point = new Point(-1, -1);
            Figure figure = null;
            return Tuple.Create(figure, point);
        }
    }
}
