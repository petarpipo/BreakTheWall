using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BreakTheWall
{
    public class Brick
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Boolean Joker { get; set; }
        public int jokertype { get; set; }
        public Font font;

        public Brick(Point location,Color color)
        {
            Center = location;
            Color = color;
            Width = 70;
            Height = 25;
            font = new Font("Arial", 18, FontStyle.Bold);
        }
        public bool isHit(int x,int y)
        {
            if(x>=Center.X-12 && x<=Center.X+Width+12 && Center.Y+Height+12>=y&& Center.Y-12<y)
                return true;
            return false;
        }
        public void Draw(Graphics g)
        {

            Pen p = new Pen(new SolidBrush(Color.Black), 3);
            g.DrawRectangle(p, Center.X, Center.Y, Width, Height);


            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Center.X, Center.Y, Width, Height);

            if (Joker)
            {
                Brush fb = new SolidBrush(Color.Black);
                g.DrawString("?", font, fb, Center.X +22 , Center.Y-2  );
            }
            }
    }
}
