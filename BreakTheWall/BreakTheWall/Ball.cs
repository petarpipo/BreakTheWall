using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTheWall
{
    public class Ball
    {

        public int Radius { get; set; }
        public Point Center { get; set; }
        public Color Color { get; set; }
        public int paddleX { get; set; }
        public bool hit { get; set; }
        public int hitY { get; set; }

        public int Velocity { get; set; }
        public double Angle { get; set; }

        public float VelocityX { get; set; }
        public float VelocityY { get; set; }





        public Ball(Point location, Color color,int pX)
        {
            hit = false;
            paddleX = pX;
            Radius = 12;
            Center = location;
            Color = color;
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble()*2*Math.PI;

            VelocityX = (float)(Math.Cos(Angle) * Velocity);
            VelocityY = (float)(Math.Sin(Angle) * Velocity);



        }



        public void Move(int left, int top, int width, int height)
        {


            int nextX = (int)(Center.X + VelocityX);
            int nextY = (int)(Center.Y + VelocityY);

            int maxTop = top + Radius;
            int maxBottom = top + height - Radius;
            int maxLeft = left + Radius;
            int maxRight = left + width - Radius;


            if (nextX >= maxRight)
            {

                nextX = nextX - (nextX - maxRight);
                VelocityX = -VelocityX;
            }

            if (nextY >= maxBottom && nextX>=paddleX && nextX<=(paddleX+150) && nextY<600)
            {

                nextY = nextY - (nextY - maxBottom);
                VelocityY = -VelocityY;
            }
            if (nextX <= maxLeft)
            {

                nextX = nextX + (maxLeft-nextX);
                VelocityX = -VelocityX;
            }
            if(hit)
            {
                hit = false;
                nextY = nextY + (hitY - nextY);
                VelocityY = -VelocityY;

            }
            if (nextY <= maxTop)
            {

                nextY = nextY + (maxTop - nextY);
                VelocityY = -VelocityY;
            }

            Center = new Point(nextX, nextY);



        }






        public void Draw( Graphics g)
        {

            Brush b = new SolidBrush(Color);

            g.FillEllipse(b, Center.X - Radius, Center.Y-Radius, Radius*2, Radius*2);

        }




    }
}
