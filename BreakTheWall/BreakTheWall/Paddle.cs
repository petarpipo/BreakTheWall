using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTheWall
{
    public class Paddle
    {

        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Paddle(Point Center)
        {

            this.Center = Center;
            Color = Color.Black;
            Width = 150;
            Height =10;
        }



        public void Draw(Graphics g)
        {

            Brush b = new SolidBrush(Color);




            g.FillRectangle(b, Center.X, Center.Y, Width, Height);


        }
        public void Move(int x)
        {
            if (x < 13)
                x = 12;
            else if (x > 621)
                x = 622;
            this.Center = new Point(x, this.Center.Y);
        }










    }
}
