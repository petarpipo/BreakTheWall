using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTheWall
{
    public partial class Form1 : Form
    {

        public int b;
        public GameDoc doc;
        public Timer timer;
        public int width;
        public int height;


        public void newGame()
        {

            doc = new GameDoc();
            doc.initializeLevel();
        }



        public Form1()
        {
            InitializeComponent();

            newGame();
            b = 0;
            width = this.Width;
            height = this.Height;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 20;
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
        }
        public void timer_Tick(object sender, EventArgs e)
        {
            doc.MoveBall(13,33,757,568);
            Invalidate(true);
            int nextX = (int)(doc.ball.Center.X + doc.ball.VelocityX);
            int nextY = (int)(doc.ball.Center.Y + doc.ball.VelocityY);
            doc.BrickHit(nextX, nextY);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            Pen p = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(p,10,30,width-40,height);

            doc.Draw(e.Graphics);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            doc.ball.paddleX = e.Location.X - 75;
            doc.MovePaddle(e.Location.X-75);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
