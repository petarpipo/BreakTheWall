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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.CenterToScreen();
         
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            panel2.BackColor = Color.FromArgb(0, Color.Black);
            StartBtn.BackColor = Color.FromArgb(50, Color.ForestGreen);
            htpButton.BackColor = Color.FromArgb(50, Color.DarkOrange);
            ExitBtn.BackColor = Color.FromArgb(50, Color.Firebrick);
            label1.BackColor = Color.FromArgb(0, Color.Black);
            this.DoubleBuffered = true;

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }


        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DifficultyForm form = new DifficultyForm();
            form.ShowDialog();
        }


        private void htpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowToPlayForm form = new HowToPlayForm();
            form.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitForm form = new ExitForm();
            form.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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


    }
}
