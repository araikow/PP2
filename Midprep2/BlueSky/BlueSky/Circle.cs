using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSky
{
    class Circle
    {
        
        int x;
        int y;
        public GraphicsPath graph; 
        public Circle(int x,int y)
        {
            this.x = x;
            this.y = y;
            graph = new GraphicsPath();

        }
        public void Appear()
        {
            if (x == 700) x = 30;
            if (y == 500) y = 30;
            x += 1;
            y += 1;
            graph = new GraphicsPath();
            graph.AddEllipse(x, y, 10, 10);
        }
        
    }
}
