using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DrawFigureOne
{
    public partial class Form1 : Form
    {
        FigureList list = new FigureList();
        Color penColor = Color.FromName("Black");
        string path = Directory.GetCurrentDirectory();
        Figure checkFig = null;

        //for translating figure
        private int xCursorStart = 0;
        private int yCursorStart = 0;
        public Bitmap bmp;

        public static Point middleStart, middleEnd;

        //points for initial polygon
        private static List<Point> points;
        private static Point onePoint, twoPoint, threePoint, fourPoint, fivePoint, sixPoint;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(HolstPanel.Width, HolstPanel.Height);
            path = path.Substring(0, path.Length - 10);
        }


        private void HolstPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!colorDialog.FullOpen)
            {
                Figure fig;
                for (int i = 0; i < list.getSize; i++)
                {
                    fig = list.getFigure(i);
                    DisplayBMP(bmp, fig);
                }
                ReturnBMP(bmp, list);
            }
        }

        private void ChangePenColor_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.Color = penColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
               penColor = colorDialog.Color;
            colorDialog.FullOpen = false;
        }

        private void HolstPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkFig == null)
            {
                //change view of cursor
                if (list.CheckCursor(e.Location) != null)
                {
                    HolstPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
                }
                else
                {
                    HolstPanel.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
            else
            {
                //transform figure
                checkFig.RewriteFigure(e.X - xCursorStart, e.Y - yCursorStart);
                xCursorStart = e.X;
                yCursorStart = e.Y;
            }
        }

        private void HolstPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (HolstPanel.Cursor == System.Windows.Forms.Cursors.SizeAll)
            {
                checkFig = list.CheckCursor(e.Location);
                xCursorStart = e.X;
                yCursorStart = e.Y;
            }
        }

        private void HolstPanel_MouseUp(object sender, MouseEventArgs e)
        {
            checkFig = null;
        }

        private void DisplayBMP(Bitmap bmp, Figure fig)
        {
            Graphics graph = Graphics.FromImage(bmp);
            fig.Display(graph);
            HolstPanel.Image = bmp;
            graph.Dispose();
        }

        private void ReturnBMP (Bitmap bmp, FigureList list)
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.Clear(HolstPanel.BackColor);
            list.Display(graph);
            HolstPanel.Image = bmp;
        }

        private void ButtonSegment_MouseUp(object sender, MouseEventArgs e)
        {
            //change background
            if (e.Button == MouseButtons.Left)
            {
                buttonSegment.Image = Image.FromFile(path + "\\assets\\segmentActive.png");
                buttonRectangle.Image = Image.FromFile(path + "\\assets\\rectangle.png");
                buttonEllipse.Image = Image.FromFile(path + "\\assets\\ellipse.png");
                buttonPolygon.Image = Image.FromFile(path + "\\assets\\polygon.png");
            }
            else if (e.Button == MouseButtons.Right)
            {
                buttonSegment.Image = Image.FromFile(path + "\\assets\\segment.png");
            }

            //add base figure
            middleStart = new Point(HolstPanel.Width / 2 - 30, HolstPanel.Height / 2 - 30);
            middleEnd = new Point(HolstPanel.Width / 2 + 30, HolstPanel.Height / 2 + 30);
            Segment segment = new Segment(middleStart, middleEnd, penColor);
            list.Add(segment);
            HolstPanel.Refresh();
        }

        private void ButtonRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            //change background
            if (e.Button == MouseButtons.Left)
            {
                buttonSegment.Image = Image.FromFile(path + "\\assets\\segment.png");
                buttonRectangle.Image = Image.FromFile(path + "\\assets\\rectangleActive.png");
                buttonEllipse.Image = Image.FromFile(path + "\\assets\\ellipse.png");
                buttonPolygon.Image = Image.FromFile(path + "\\assets\\polygon.png");
            }
            else if (e.Button == MouseButtons.Right)
            {
                buttonRectangle.Image = Image.FromFile(path + "\\assets\\rectangle.png");
            }

            //add base figure
            middleStart = new Point(HolstPanel.Width / 2 - 30, HolstPanel.Height / 2 - 30);
            middleEnd = new Point(HolstPanel.Width / 2 + 30, HolstPanel.Height / 2 + 30);
            Rectangle rectangle = new Rectangle(middleStart, middleEnd, penColor);
            list.Add(rectangle);
            HolstPanel.Refresh();
        }

        private void ButtonEllipse_MouseUp(object sender, MouseEventArgs e)
        {
            //change background
            if (e.Button == MouseButtons.Left)
            {
                buttonSegment.Image = Image.FromFile(path + "\\assets\\segment.png");
                buttonRectangle.Image = Image.FromFile(path + "\\assets\\rectangle.png");
                buttonEllipse.Image = Image.FromFile(path + "\\assets\\ellipseActive.png");
                buttonPolygon.Image = Image.FromFile(path + "\\assets\\polygon.png");
            }
            else if (e.Button == MouseButtons.Right)
            {
                buttonEllipse.Image = Image.FromFile(path + "\\assets\\ellipse.png");
            }

            //add base figure
            middleStart = new Point(HolstPanel.Width / 2 - 30, HolstPanel.Height / 2 - 30);
            middleEnd = new Point(HolstPanel.Width / 2 + 30, HolstPanel.Height / 2 + 30);
            Ellipse ellipse = new Ellipse(middleStart, middleEnd, penColor);
            list.Add(ellipse);
            HolstPanel.Refresh();
        }

        private void ButtonPolygon_MouseUp(object sender, MouseEventArgs e)
        {
            //change background
            if (e.Button == MouseButtons.Left)
            {
                buttonSegment.Image = Image.FromFile(path + "\\assets\\segment.png");
                buttonRectangle.Image = Image.FromFile(path + "\\assets\\rectangle.png");
                buttonEllipse.Image = Image.FromFile(path + "\\assets\\ellipse.png");
                buttonPolygon.Image = Image.FromFile(path + "\\assets\\polygonActive.png");
            }
            else if (e.Button == MouseButtons.Right)
            {
                buttonPolygon.Image = Image.FromFile(path + "\\assets\\polygon.png");
            }

            //add base figure
            //initialize start points
            onePoint = new Point(HolstPanel.Width / 2, HolstPanel.Height / 2 + 30);
            twoPoint = new Point(HolstPanel.Width / 2 + 26, HolstPanel.Height / 2 + 15);
            threePoint = new Point(HolstPanel.Width / 2 + 26, HolstPanel.Height / 2 - 15);
            fourPoint = new Point(HolstPanel.Width / 2, HolstPanel.Height / 2 - 30);
            fivePoint = new Point(HolstPanel.Width / 2 - 26, HolstPanel.Height / 2 - 15);
            sixPoint = new Point(HolstPanel.Width / 2 - 26, HolstPanel.Height / 2 + 15);

            points = new List<Point>();
            points.Add(onePoint);
            points.Add(twoPoint);
            points.Add(threePoint);
            points.Add(fourPoint);
            points.Add(fivePoint);
            points.Add(sixPoint);

            Polygon polygon = new Polygon(points, penColor);
            list.Add(polygon);
            HolstPanel.Refresh();
        }

    }
}
