using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueSky
{
    public partial class Form1 : Form
    {
        public static Random rand = new Random();
        public static Random rand1 = new Random();
        public static int x_1 = rand.Next(1, 300);
        public static int y_1 = rand.Next(1, 300);

        public static int x_2 = rand.Next(1, 300);
        public static int y_2 = rand.Next(1, 300);
        public static int x_3 = rand.Next(1, 300);
        public static int y_3 = rand.Next(1, 300);
        int x = 200;
        int y = 100;
        Star s1 = new Star(50, 50);
        Star s2 = new Star(200, 300);
        Circle c1 = new Circle(x_1, y_1);
        Circle c2 = new Circle(x_2, y_2);
        Circle c3 = new Circle(x_3, y_3);

        Graphics graph;
        public Form1()
        {
            this.Width = 700;
            this.Height = 500;
            BackColor = Color.DarkBlue;
            InitializeComponent();
             graph = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] month =
            {
                new Point(x,y),
                new Point(x,y + 30),
                new Point(x-10,y+50),
                new Point(x-40,y+60),
                new Point(x-70,y+50),
                new Point(x-40,y + 40),
                new Point(x-20,y+30),
                new Point(x-10,y-10),
            };
            e.Graphics.FillClosedCurve(Brushes.Gray, month);
            e.Graphics.FillPath(Brushes.Yellow, s1.gr);
            e.Graphics.FillPath(Brushes.Yellow, s2.gr);
            e.Graphics.FillPath(Brushes.Red, c1.graph);
            e.Graphics.FillPath(Brushes.Red, c2.graph);
            e.Graphics.FillPath(Brushes.Red, c3.graph);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s1.Move();
            s2.Move();
            c1.Appear();
            c2.Appear();
            c3.Appear();
            graph.FillEllipse(Brushes.White, 100, 100, 10, 10);
            Refresh();
            
        }
    }
}
