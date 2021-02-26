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
        public bool GameOver;
        public bool NextLevel;
        public List<int> Hit2 { get; set; }
        public List<int> hit3 { get; set; }
        public static int dificutly { get; set; }
        public static Random random = new Random();
        


        public GameDoc(int Level)
        {
            bricks = new List<Brick>();
            ball = new Ball(new Point(387,400), Color.Red,312);
            if(dificutly==1)
                paddle = new Paddle(new Point(312, 600),250);
            else if(dificutly==2)
                paddle = new Paddle(new Point(312, 600), 150);
            else if (dificutly == 3)
                paddle = new Paddle(new Point(312, 600), 80);
            level = Level;
            GameOver = false;
            NextLevel = false;
        }



        public void GameEnd()
        {
            if(ball.Center.Y > paddle.Center.Y + 70)
            { 
                GameOver = true;
            }

            if(bricks.Count == 0)
            {
                NextLevel = true;
            }
        }


        public void Level1()
        {
            int x = 14;
            int y = 35;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 49;
            y += 31;
            for (int i = 0; i < 9; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 84;
            y += 31;
            for (int i = 0; i < 8; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            Hit2 = new List<int>();
            while (Hit2.Count < 5)
            {
                int n = random.Next(0, 36);
                if (Hit2.Contains(n))
                {
                    continue;
                }
                Hit2.Add(n);
            }
            hit3 = new List<int>();
            while (hit3.Count < 3)
            {
                int n = random.Next(0, 36);
                if (Hit2.Contains(n) || hit3.Contains(n))
                {
                    continue;
                }
                hit3.Add(n);
            }
            foreach (int i in Hit2)
            {
                bricks[i].Color = Color.Silver;
            }
            foreach (int i in hit3)
            {
                bricks[i].Color = Color.DimGray;
            }
            int b = 1;
            for (int i = 5; i < 25; i = i + 5)
            {
                bricks[i].Joker = true;
                bricks[i].jokertype = b;
                b++;
            }

        }
        public void level3()
        {
            int x = 14;
            int y = 35;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.DimGray));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.DimGray));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Silver));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Silver));
                x += 76;
            }
            x = 14;
            y += 31;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.Silver));
                x += 76;
            }
            int b = 1;
            for (int i = 5; i < 25; i = i + 5)
            {
                bricks[i].Joker = true;
                bricks[i].jokertype = b;
                b++;
            }

        }
        public void level2()
        {
            int x = 14;
            int y = 34;
            for (int i = 0; i < 10; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 84;
            y += 31;
            for (int i = 0; i < 8; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 154;
            y += 31;
            for (int i=0;i<6;i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 224;
             y+= 31;
            for (int i = 0; i < 4; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            x = 294;
            y += 31;
            for (int i = 0; i < 2; i++)
            {
                bricks.Add(new Brick(new Point(x, y), Color.WhiteSmoke));
                x += 76;
            }
            Hit2 = new List<int>();
            while (Hit2.Count < 10)
            {
                int n = random.Next(0,30);
                if (Hit2.Contains(n))
                {
                    continue;
                }
                Hit2.Add(n);
            }
            hit3 = new List<int>();
            while (hit3.Count < 10)
            {
                int n = random.Next(0,30);
                if (Hit2.Contains(n) || hit3.Contains(n))
                {
                    continue;
                }
                hit3.Add(n);
            }
            foreach (int i in Hit2)
            {
                bricks[i].Color = Color.Silver;
            }
            foreach (int i in hit3)
            {
                bricks[i].Color = Color.DimGray;
            }
            int b = 1;
            for (int i = 5; i < 25; i = i + 5)
            {
                bricks[i].Joker = true;
                bricks[i].jokertype = b;
                b++;
            }
        }
        public void initializeLevel()
        {
            if (level == 1)
                Level1();
            else if (level == 2)
                level2();
            else if (level == 3)
                level3();
        }
        public void BrickHit(int x,int y)
        {
            for(int i=0;i<bricks.Count;i++)
            {
                if (bricks[i].isHit(x, y))
                {
                    ball.hit = true;
                    ball.hitY = bricks[i].Center.Y + bricks[i].Height;
                    if (bricks[i].Color == Color.WhiteSmoke)
                    {
                        if (bricks[i].Joker)
                        {
                            if(bricks[i].jokertype==1)
                            {
                                Paddle.Width = Paddle.Width * 2;
                                Form1.paddleJoker = true;
        
    }
                            if(bricks[i].jokertype==2)
                            {
                                Ball.Velocity = 7;
                                Form1.ballJoker = true;
    }
                            if(bricks[i].jokertype==3)
                            {
                                Form1.Lives++;
                            }
                            if(bricks[i].jokertype==4)
                            {
                                Form1.Score += 10000;
                            }
                        }
                        Form1.Score += 100;
                        bricks.RemoveAt(i);
                        i--;
                    }
                    else if(bricks[i].Color==Color.Silver)
                    {
                        Form1.Score += 100;
                        bricks[i].Color = Color.WhiteSmoke;
                    }
                    else if (bricks[i].Color == Color.DimGray)
                    {
                        Form1.Score += 100;
                        bricks[i].Color = Color.Silver;
                    }
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
