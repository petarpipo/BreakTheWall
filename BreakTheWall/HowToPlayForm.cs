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
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();

            this.CenterToScreen();

            panel1.BackColor = Color.FromArgb(150, Color.Black);
            panel2.BackColor = Color.FromArgb(0, Color.Black);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BackColor = Color.FromArgb(0, Color.Black);

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.BackColor = Color.FromArgb(0, Color.Black);

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.BackColor = Color.FromArgb(0, Color.Black);

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.BackColor = Color.FromArgb(0, Color.Black);

            MainMenu.BackColor = Color.FromArgb(200, Color.Gray);

            label1.BackColor = Color.FromArgb(0, Color.Black);
            label2.BackColor = Color.FromArgb(0, Color.Black);
            label3.BackColor = Color.FromArgb(0, Color.Black);
            label4.BackColor = Color.FromArgb(0, Color.Black);
            //MainMenu.BackColor = Color.FromArgb(200, Color.Gray);
            this.DoubleBuffered = true;
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


        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm form = new StartForm();
            form.ShowDialog();
        }
    }
}
