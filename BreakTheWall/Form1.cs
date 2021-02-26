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
        public static int width;
        public int height;
        public static int Score = 0;
        public static int Lives = 3;
        public static bool paddleJoker = false;
        public static bool ballJoker = false;
        public static int balltimer = 0;
        public static int paddletimer = 0;


        public void newGame(int nLevel)
        {

            paddleJoker = false;
            ballJoker = false;
            Lives = 3;
            lScore.Text= "0";
            LivesLabel.Text = "Lives: 3";
            if (nLevel == 1)
                Score = 0;
            doc = new GameDoc(nLevel);
            doc.initializeLevel();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();

        
            b = 0;
            width = this.Width;
            height = this.Height;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;
            this.CenterToScreen();


            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);

            newGame(1);

        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if(paddleJoker)
            {
                /*paddletimer++;
                if(paddletimer>1000)
                {
                   
                    Paddle.Width = Paddle.Width / 2;
                    paddleJoker = false;
                    paddletimer = 0;
                }*/

                timerPad.Start();
                paddleStatus.Text = "ENABLED";
                paddleStatus.ForeColor = Color.Green;

            }
            if(ballJoker)
            {
                /*balltimer++;
                if(balltimer>1000)
                {
                    if (GameDoc.dificutly == 3)
                        Ball.Velocity = 10;
                    if(GameDoc.dificutly == 2)
                        Ball.Velocity = 9;
                    if (GameDoc.dificutly == 1)
                        Ball.Velocity = 7;
                    ballJoker = false;
                    balltimer = 0;
                }*/
                
                timerBall.Start();
                ballStatus.Text = "ENABLED";
                ballStatus.ForeColor = Color.Green;



            }

          
          
            doc.MoveBall(13,33,757,568);
            int nextX = (int)(doc.ball.Center.X + doc.ball.VelocityX);
            int nextY = (int)(doc.ball.Center.Y + doc.ball.VelocityY);
            doc.BrickHit(nextX, nextY);
            doc.GameEnd();
            if (doc.GameOver && Lives > 0)
            {
                Lives--;
                timer.Stop();
                LivesLabel.Text = "Lives: " + Lives.ToString();
                DialogResult dialogResult = MessageBox.Show("Continue? ", "Game Over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    doc.ball = new Ball(new Point(387, 400), Color.Red, 312);
                    doc.GameOver = false;
                }
                else
                {
                    this.Hide();
                    StartForm form = new StartForm();
                    form.ShowDialog();
                }
            }
            if (doc.GameOver)
            {

                timer.Stop();

                DialogResult dialogResult = MessageBox.Show("Game is over. Do you want new game? ", "Game Over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    //do something
                    newGame(1);
                }
                else
                {
                    this.Hide();
                    StartForm form = new StartForm();
                    form.ShowDialog();
                }

            }


            Invalidate(true);


            if (doc.NextLevel)
            {
                timer.Stop();

                doc.level++;

                if (doc.level <= 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Level " + doc.level, "Next Level", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        //do something


                        timerBall.Stop();
                        ballStatus.Text = "DISABLED";
                        ballStatus.ForeColor = Color.Red;

                        timerPad.Stop();
                        paddleStatus.Text = "DISABLED";
                        paddleStatus.ForeColor = Color.Red;

                      

                        newGame(doc.level);


                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Congradulations, YOU WIN ! ","End of the game" ,MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        //do something
                        this.Hide();
                        StartForm form = new StartForm();
                        form.ShowDialog();

                    }
                }
               

            }

            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(p,10,30,width-22,height);

            doc.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {         
                doc.ball.paddleX = e.Location.X - Paddle.Width/2;
            if (doc.ball.paddleX < 13)
                doc.ball.paddleX = 12;
            else if (doc.ball.paddleX > width - 26 - Paddle.Width)
                doc.ball.paddleX = width - 25 - Paddle.Width;
                doc.MovePaddle(e.Location.X - Paddle.Width / 2);
            //Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                timer.Start();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerBall_Tick(object sender, EventArgs e)
        {

            if (GameDoc.dificutly == 3)
                Ball.Velocity = 10;
            if (GameDoc.dificutly == 2)
                Ball.Velocity = 12;
            if (GameDoc.dificutly == 1)
                Ball.Velocity = 10;

            ballJoker = false;
            timerBall.Stop();
            ballStatus.Text = "DISABLED";
            ballStatus.ForeColor = Color.Red;
            Invalidate();
        }

        private void timerPad_Tick(object sender, EventArgs e)
        {
            Paddle.Width = Paddle.Width / 2;
            paddleJoker = false;
            timerPad.Stop();
            paddleStatus.Text = "DISABLED";
            paddleStatus.ForeColor = Color.Red;
            Invalidate();
        }

        private void lScore_Paint(object sender, PaintEventArgs e)
        {
            lScore.Text = Score.ToString();
        }

        private void LivesLabel_Paint(object sender, PaintEventArgs e)
        {
            LivesLabel.Text = "Lives: " + Lives.ToString();
        }
    }
}
