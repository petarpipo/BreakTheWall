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
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.CenterToScreen();
            label1.BackColor = Color.FromArgb(150, Color.Black);
            panel1.BackColor = Color.FromArgb(150, Color.Black);
           

            YesBtn.BackColor = Color.FromArgb(150, Color.ForestGreen);
            NoBtn.BackColor = Color.FromArgb(150, Color.Firebrick);

        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
