using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorgeousEyes
{
    class Circle
    {
        int x;
        int y;
       public  GraphicsPath gr;
        
        public Circle(int x,int y)
        {
            this.x = x;
            this.y = y;
            gr = new GraphicsPath();
        }
        public void MoveR()
        {
            x += 1;
            if (x == 350)
            {
                MoveL();
            }
            gr.Reset();
            gr.AddEllipse(x, y, 30, 30);
        }
        public void MoveL()
        {
            x -= 1;
            if (x == 310)
            {
                MoveR();
            }
            gr.Reset();
            gr.AddEllipse(x, y, 30, 30);
        }

    }
}
