namespace BreakTheWall
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.htpButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.htpButton);
            this.panel1.Location = new System.Drawing.Point(64, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 416);
            this.panel1.TabIndex = 3;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.StartBtn.Location = new System.Drawing.Point(31, 31);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(286, 102);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.ExitBtn.Location = new System.Drawing.Point(31, 286);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(286, 102);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // htpButton
            // 
            this.htpButton.BackColor = System.Drawing.Color.DarkOrange;
            this.htpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htpButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htpButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.htpButton.Location = new System.Drawing.Point(31, 160);
            this.htpButton.Name = "htpButton";
            this.htpButton.Size = new System.Drawing.Size(286, 102);
            this.htpButton.TabIndex = 1;
            this.htpButton.Text = "How To Play";
            this.htpButton.UseVisualStyleBackColor = false;
            this.htpButton.Click += new System.EventHandler(this.htpButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BreakTheWall.Properties.Resources.apps_22208_13510798887506427_55ed70dd_7fe0_43fd_9552_50882f4a33cc;
            this.panel2.Location = new System.Drawing.Point(576, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 181);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(416, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 182);
            this.label1.TabIndex = 5;
            this.label1.Text = "Break The \r\nWall";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::BreakTheWall.Properties.Resources.resized;
            this.ClientSize = new System.Drawing.Size(855, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "Break The Wall";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button htpButton;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
    }
}