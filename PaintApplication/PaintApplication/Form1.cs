using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication
{
    enum Tool
    {
        Line,
        None,
        Pencil,
        Rectangle,
        Ellipse,
        Fill,
        Eraser,
        Triangle
    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graphics;
        Pen pen = new Pen(Color.Brown, 2);
        Tool activeTool = Tool.None;
        Point firstPoint;
        Point secondPoint;
        Point[] tr;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.White);
            pictureBox1.Image = bmp;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            if(activeTool == Tool.Fill)
            {
               // MapFill mapFill = new MapFill();
              //  mapFill.Fill(graphics, e.Location, pen.Color, ref bmp);
                graphics = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            secondPoint = e.Location;
            switch (activeTool)
            {
                case Tool.Line:
                    graphics.DrawLine(pen, firstPoint, secondPoint);
                    break;
                case Tool.Pencil:
                    graphics.DrawLine(pen, firstPoint, secondPoint);
                    firstPoint = secondPoint;
                    break;
                case Tool.Rectangle:
                    graphics.DrawRectangle(pen,GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Ellipse:
                    graphics.DrawEllipse(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Eraser:
                    graphics.DrawLine(new Pen(Color.White,5), firstPoint, secondPoint);
                    firstPoint = secondPoint;
                    break;
                case Tool.Triangle:
                    graphics.DrawPolygon(pen, GetTriangle(firstPoint, secondPoint));
                    break;
                default:
                    break;
            }
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle res = new Rectangle();
            res.X = Math.Min(p1.X, p2.X);
            res.Y = Math.Min(p1.Y, p2.Y);
            res.Width = Math.Abs(p1.X - p2.X);
            res.Height = Math.Abs(p1.Y - p2.Y);
            return res;
        }
        private Point[] GetTriangle(Point p1, Point p2)
        {
            
            if (p1.X < p2.X && p1.Y < p2.Y)
            {
                Point[] tr = { new Point(p1.X, p2.Y),
                    new Point(p2.X,p2.Y),
                    new Point(p2.X, p2.Y),
                    new Point((p2.X + p1.X) / 2, p1.Y),
                    new Point(p1.X,p2.Y),
                    new Point((p2.X + p1.X) / 2, p1.Y),
                };
                
            }
            if (p1.X > p2.X && p1.Y > p2.Y)
            {
                Point[] tr = {
                    new Point(p1.X, p1.Y),
                    new Point(p2.X, p1.Y),
                    new Point((p2.X + p1.X) / 2, p2.Y)};

            }
            if (p1.X < p2.X && p1.Y > p2.Y)
            {
                Point[] tr = {
                        new Point(p1.X, p1.Y),
                        new Point(p2.X, p1.Y),
                        new Point((p2.X + p1.X) / 2, p2.Y)};

            }
            if (p1.X > p2.X && p1.Y < p2.Y)
            {
                Point[] tr = {
                    new Point(p1.X, p2.Y),
                    new Point(p2.X, p2.Y),
                    new Point((p2.X + p1.X) / 2, p1.Y)};
                
            }
            return tr;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                secondPoint = e.Location;
                switch (activeTool)
                {
                    case Tool.Line:
                        break;
                    case Tool.Pencil:
                       graphics.DrawLine(pen, firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    case Tool.Rectangle:
                        break;
                    case Tool.Ellipse:
                        break;
                    case Tool.Fill:
                        break;
                    case Tool.Eraser:
                        graphics.DrawLine(new Pen(Color.White, 5), firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    default:
                        break;

                }
                pictureBox1.Refresh();
            }
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Line;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rectangle;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Ellipse;
        }
        private void Eraser_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Eraser;
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill;
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (activeTool)
            {
                case Tool.Line:
                    e.Graphics.DrawLine(pen, firstPoint, secondPoint);
                    break;
                case Tool.Pencil:
                    break;
                case Tool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Fill:
                    break;
                case Tool.Eraser:
                    break;
                case Tool.Triangle:
                    graphics.DrawPolygon(pen, GetTriangle(firstPoint, secondPoint));
                    break;
                default:
                    break;
            }
        }
        private void FromColorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void widthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem2.Pressed)
            {
                pen = new Pen(Color.Black, int.Parse(toolStripMenuItem2.Text));
            }
            else if (toolStripMenuItem3.Pressed)
            {
                pen = new Pen(Color.Black, int.Parse(toolStripMenuItem3.Text));
            }
            else if (toolStripMenuItem4.Pressed)
            {
                pen = new Pen(Color.Black, int.Parse(toolStripMenuItem4.Text));
            }
        }
    }
}
