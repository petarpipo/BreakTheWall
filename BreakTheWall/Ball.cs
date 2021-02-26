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
        public bool hit{ get; set; }
        public int hitY { get; set; }
        public static Random r { get; set; }

        public static int Velocity { get; set; }
        public double Angle { get; set; }

        public float VelocityX { get; set; }
        public float VelocityY { get; set; }





        public Ball(Point location, Color color, int pX)
        {
            //hit = false;
            paddleX = pX;
            Radius = 12;
            Center = location;
            Color = color;
            r = new Random();
            Angle = Math.PI*270/180;
        

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

            if (nextY >= maxBottom && nextX>=paddleX && nextX<=(paddleX+Paddle.Width) && nextY<600)
            {
                Form1.Score -= 25;
                nextY = nextY - (nextY - maxBottom);
                VelocityY = -VelocityY;


                /* STARO
                 
                 if (nextX > paddleX && nextX <= paddleX + 70 && VelocityX < 0)
                {
                   
                    Angle = r.Next(220, 250) * Math.PI / 180;
                    VelocityX = -VelocityX;

                }

                else if (nextX > paddleX + 80 && nextX < paddleX + 100)
                    Angle = r.Next(260, 280) * Math.PI / 180;
                else if (nextX > paddleX + 110 && nextX < paddleX + 150 && VelocityX > 0)
                {
                    Angle = r.Next(290, 320) * Math.PI / 180;
                    VelocityX = -VelocityX;
                }
               
                */



                //Dodadeno

                if ((nextX >= paddleX && nextX <= paddleX + 0.4*Paddle.Width && VelocityX < 0) || (nextX >= paddleX + 0.6*Paddle.Width && nextX <= paddleX + Paddle.Width && VelocityX < 0))
                {
                    Angle = r.Next(220, 251) * Math.PI / 180;
                }

                else if ((nextX >= paddleX && nextX <= paddleX + Paddle.Width && VelocityX > 0) || (nextX >= paddleX + 0.6*Paddle.Width && nextX <= paddleX + Paddle.Width && VelocityX > 0))
                {
                    Angle = r.Next(290, 321) * Math.PI / 180;
                }
                else if (nextX >= paddleX + 0.4*Paddle.Width+1 && nextX <= paddleX + 0.6*Paddle.Width-1 && VelocityX > 0)
                {
                    Angle = r.Next(270, 291) * Math.PI / 180;
                }
                else if (nextX >= paddleX + 0.4 * Paddle.Width + 1 && nextX <= paddleX + 0.6 * Paddle.Width - 1 && VelocityX < 0)
                {
                    Angle = r.Next(250, 271) * Math.PI / 180;
                }
               
                //Kraj

                VelocityX = (float)(Math.Cos(Angle) * Velocity);
                VelocityY = (float)(Math.Sin(Angle) * Velocity);
                
            }
            if (nextX <= maxLeft)
            {

                nextX = nextX + (maxLeft-nextX);
                VelocityX = -VelocityX;
            }
            if(hit)
            {
                hit = !hit;
                if (VelocityY < 0)
                {
                    nextY = nextY - (hitY - nextY);
                    VelocityY = -VelocityY;
                }
                else
                {
                    nextY = nextY - (nextY - hitY+25);
                    VelocityY = -VelocityY;
                }

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
