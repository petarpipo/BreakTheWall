using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTheWall
{
    public class GameDoc
    {
        public Ball ball;
        public Paddle paddle;
        public List<Brick> bricks;
        public int level { get; set; }

        public GameDoc()
        {
            bricks = new List<Brick>();
            ball = new Ball(new Point(387,400), Color.Red,312);
            paddle = new Paddle(new Point(312, 600));
            level = 1;
        }
        public void Level1()
        {
            int x = 14;
            int y = 35;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Orange));
                x += 76;
            }
            x=49;
            y += 31;
            for (int i = 0; i < 9; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Yellow));
                x += 76;
            }
            x=84;
            y += 31;
            for(int i=0;i<8;i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Green));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Orange));
                x += 76;
            }
        }
        public void initializeLevel()
        {
            if (level == 1)
                Level1();
        }
        public void BrickHit(int x,int y)
        {
            for(int i=0;i<bricks.Count;i++)
            {
                if(bricks[i].isHit(x,y))
                {
                    ball.hit = true;
                    ball.hitY = bricks[i].Center.Y + bricks[i].Height;
                    bricks.RemoveAt(i);
                    i--;
                }
            }
        }
        public void Draw(Graphics g)
        {
            ball.Draw(g);
            paddle.Draw(g);
            foreach(Brick b in bricks)
            {
                b.Draw(g);
            }
        }


        public void MoveBall(int left, int top, int width, int height)
        {
            ball.Move(left,top,width,height);
        }


        public void MovePaddle(int x)
        {

            paddle.Move(x);
        }



    }
}
