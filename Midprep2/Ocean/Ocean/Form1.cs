using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean
{
    public partial class Form1 : Form
    {
        int x = 300;
        int y = 200;
        Pen yellow = new Pen(Color.Yellow, 3);
        Circle c1 = new Circle(280, 200);
        Circle c2 = new Circle(270, 180);
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Point[] fish =
            {
            new Point(x,y),
            new Point(x+20,y-20),
            new Point(x+40,y-29),
            new Point(x+80,y-28),
            new Point(x+120,y-20),
            new Point(x+140,y),
            new Point(x+120,y+20),
            new Point(x+80,y+28),
            new Point(x+40,y+29),
            new Point(x+20,y+20),
            };

            Point[] kanat1 =
            {
                new Point(x+40,y-29),
                new Point(x+90,y-45),
                new Point(x+80,y-28)
            };
            Point[] kanat2 =
            {
                new Point(x+40,y+29),
                new Point(x+90,y+45),
                new Point(x+80,y+28)
            };
            Point[] kanat3 =
            {
                new Point(x+140,y),
                new Point(x+170,y-20),
                new Point(x+170,y+20)
            };
            e.Graphics.FillPolygon(Brushes.Yellow, kanat1);
            e.Graphics.FillPolygon(Brushes.Yellow, kanat2);
            e.Graphics.FillPolygon(Brushes.Yellow, kanat3);
            e.Graphics.FillClosedCurve(Brushes.Orange, fish);
            e.Graphics.DrawLine(yellow, 340, 171, 340, 229);
            e.Graphics.FillPath(Brushes.White, c1.graph);
            e.Graphics.FillPath(Brushes.White, c2.graph);
            e.Graphics.DrawLine(new Pen(Color.Black,1),x, y, x + 13, y+3);
            e.Graphics.FillEllipse(Brushes.Black, x +10, y-10, 5,5);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c1.Appear();
            c2.Appear();
            Refresh();
        }
    }
}
