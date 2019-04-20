using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSky
{
    class Star
    {
        int x;
        int y;
        public GraphicsPath gr;
        public Star(int x, int y)
        {
            this.x = x;
            this.y = y;
            gr = new GraphicsPath();
        }
        public void Move()
        {
            if (x == 500) x = 10;
            if (y == 500) y = 10;
            x += 2;
            y += 2;
            gr = new GraphicsPath();
            Point[] star1 = {
                new Point(x,y),
                new Point(x+2,y+3),
                new Point(x+6,y+3),
                new Point(x+3,y+6),
                new Point(x+4,y+9),
                new Point(x,y+7),
                new Point(x-4,y+9),
                new Point(x-3,y+6),
                new Point(x-6,y+3),
                new Point(x-2,y+3),
                };
            gr.AddPolygon(star1);

        }
    }
}
