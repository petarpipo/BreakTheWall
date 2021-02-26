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
        Boolean Joker { get; set; }

        public Brick(Point location,Color color)
        {
            Center = location;
            Color = color;
            Width = 70;
            Height = 25;
        }
        public bool isHit(int x,int y)
        {
            if (x+12 > Center.X && x < (Center.X + Width+12) && y < Center.Y+Height)
                return true;
            return false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Center.X, Center.Y, Width, Height);
        }
    }
}
