using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DrawFigureOne
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

        public void Display(Graphics gr)
        {
            foreach (Figure fig in list)
            {
                fig.Display(gr);
            }
        }

        //check for sizeAll cursor
        public Figure CheckCursor (System.Drawing.Point ptn)
        {
            Figure result = null;
            System.Drawing.Rectangle cursorArea = 
                new System.Drawing.Rectangle(ptn.X + 8, ptn.Y + 8, ptn.X, ptn.Y);

            foreach (Figure fig in list)
            {
               if (fig.IsInFigure(cursorArea))
               {
                  result = fig;
               }
            }
            return result;
        }
    }
}
