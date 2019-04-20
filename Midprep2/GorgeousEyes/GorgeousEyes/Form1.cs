using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorgeousEyes
{
    public partial class Form1 : Form
    {
        public static int x = 300;
        public static int y = 150;
        public static int x1 = 400;
        public static int y1 = 150;
       Circle c1 = new Circle(x + 26, y - 15);
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Pink;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //one eye
            Point[] p = {
                new Point(x,y),
                new Point(x+10,y-10),
                new Point(x+30,y-18),
                new Point(x+40,y-20),
                new Point(x+50,y-18),
                new Point(x+70,y-10),
                new Point(x+80,y),
                new Point(x+70,y+10),
                new Point(x+50,y+18),
                new Point(x+40,y+20),
                new Point(x+30,y+18),
                new Point(x+10,y+10)
            };
            e.Graphics.FillClosedCurve(Brushes.White, p);
            // second eye
            Point[] p1 = {
                new Point(x1,y1),
                new Point(x1+10,y1-10),
                new Point(x1+30,y1-18),
                new Point(x1+40,y1-20),
                new Point(x1+50,y1-18),
                new Point(x1+70,y1-10),
                new Point(x1+80,y1),
                 new Point(x1+70,y1+10),
                 new Point(x1+50,y1+18),
                  new Point(x1+40,y1+20),
                    new Point(x1+30,y1+18),
                new Point(x1+10,y1+10)
            };
            e.Graphics.FillClosedCurve(Brushes.White, p1);

            e.Graphics.FillPath(Brushes.DarkBlue,c1.gr);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c1.MoveR();
            Refresh();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            c1.MoveL();
            Refresh();
        }
    }
}
