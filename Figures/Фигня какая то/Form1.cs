using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фигня_какая_то
{
    public partial class Form1 : Form
    {
        FigureList list = new FigureList();
        int counter = -1;

        public static List<Point> points = new List<Point>();
        public static List<Point> poi = new List<Point>();
        public void InitializeList ()
        {
            Point firstPoint = new Point(100, 150);
            Point secondPoint = new Point(122, 70);
            Point thirdPoint = new Point(108, 87);
            Point fourthPoint = new Point(76, 67);
            Point fifthPoint = new Point(95, 124);
            Point sixthPoint = new Point(230, 300);
            Point seventhPoint = new Point(286, 180);

            points.Add(secondPoint);
            points.Add(thirdPoint);
            points.Add(firstPoint);
            points.Add(sixthPoint);

            poi.Add(seventhPoint);
            poi.Add(fifthPoint);

            Ellipse elOne = new Ellipse(firstPoint, fourthPoint);
            Rectangle recOne = new Rectangle(fourthPoint, fifthPoint);
            Segment segOne = new Segment(secondPoint, fifthPoint);
            Rectangle recTwo = new Rectangle(thirdPoint, secondPoint);
            Polygon polOne = new Polygon(fifthPoint, points);
            Ellipse elTwo = new Ellipse(seventhPoint, fourthPoint);
            Polygon polTwo = new Polygon(secondPoint, poi);
            Segment segTwo = new Segment(sixthPoint, seventhPoint);
            Rectangle recThree = new Rectangle(sixthPoint, thirdPoint);

            //add to list
            list.Add(elOne);
            list.Add(recOne);
            list.Add(segOne);
            list.Add(recTwo);
            list.Add(polOne);
            list.Add(elTwo);
            list.Add(polTwo);
            list.Add(segTwo);
            list.Add(recThree);
        }

        public Form1()
        {
            InitializeComponent();
            InitializeList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //draw figure
            HolstPanel.Refresh();
        }

        private void HolstPanel_Paint(object sender, PaintEventArgs e)
        {
            Figure fig;
            if ((counter != -1) && (counter != list.getSize))
            {
                fig = list.getFigure(counter);
                fig.Display(e);
            }
            else
            if (counter == list.getSize)
            {
                counter = 0;
                fig = list.getFigure(counter);
                fig.Display(e);
            }
            counter++;
        }
    }
}
