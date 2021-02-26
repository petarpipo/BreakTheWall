namespace BreakTheWall
{
    partial class DifficultyForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HardBtn = new System.Windows.Forms.Button();
            this.EasyBtn = new System.Windows.Forms.Button();
            this.MediumBtn = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BreakTheWall.Properties.Resources.apps_22208_13510798887506427_55ed70dd_7fe0_43fd_9552_50882f4a33cc;
            this.panel2.Location = new System.Drawing.Point(576, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 181);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HardBtn);
            this.panel1.Controls.Add(this.EasyBtn);
            this.panel1.Controls.Add(this.MediumBtn);
            this.panel1.Location = new System.Drawing.Point(59, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 416);
            this.panel1.TabIndex = 7;
            // 
            // HardBtn
            // 
            this.HardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.HardBtn.Location = new System.Drawing.Point(31, 284);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(286, 102);
            this.HardBtn.TabIndex = 3;
            this.HardBtn.Text = "Hard";
            this.HardBtn.UseVisualStyleBackColor = false;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // EasyBtn
            // 
            this.EasyBtn.BackColor = System.Drawing.Color.Silver;
            this.EasyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.EasyBtn.Location = new System.Drawing.Point(31, 38);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(286, 102);
            this.EasyBtn.TabIndex = 2;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = false;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // MediumBtn
            // 
            this.MediumBtn.BackColor = System.Drawing.Color.Gray;
            this.MediumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.MediumBtn.Location = new System.Drawing.Point(31, 160);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(286, 102);
            this.MediumBtn.TabIndex = 1;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = false;
            this.MediumBtn.Click += new System.EventHandler(this.MediumBtn_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gray;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.SystemColors.Menu;
            this.MainMenu.Location = new System.Drawing.Point(541, 397);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(255, 75);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(508, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 138);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose \r\nDifficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BreakTheWall.Properties.Resources.resized;
            this.ClientSize = new System.Drawing.Size(855, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DifficultyForm";
            this.Text = "DifficultyForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MediumBtn;
        private System.Windows.Forms.Button HardBtn;
        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
    }
}