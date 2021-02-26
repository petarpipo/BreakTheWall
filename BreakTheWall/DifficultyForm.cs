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
    public partial class DifficultyForm : Form
    {
        public DifficultyForm()
        {
            InitializeComponent();
            
            this.CenterToScreen();
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            panel2.BackColor = Color.FromArgb(0, Color.Black);
            EasyBtn.BackColor = Color.FromArgb(50, Color.Silver);
            MediumBtn.BackColor = Color.FromArgb(50, Color.Gray);
            HardBtn.BackColor = Color.FromArgb(50, 64, 64, 64);
            label1.BackColor = Color.FromArgb(0, Color.Black);
            MainMenu.BackColor = Color.FromArgb(200, Color.Gray);
            this.DoubleBuffered = true;
           
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm form = new StartForm();
            form.ShowDialog();
           

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

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            Ball.Velocity = 12;
            GameDoc.dificutly = 2;
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            Ball.Velocity = 10;
            GameDoc.dificutly = 1;
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            Ball.Velocity = 10;
            GameDoc.dificutly = 3;
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
