namespace ValidadorDuplicidade
{
    partial class Config
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
            celnome = new TextBox();
            celvalor = new TextBox();
            panel1 = new ReaLTaiizor.Controls.Panel();
            lostAcceptButton1 = new ReaLTaiizor.Controls.LostAcceptButton();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // celnome
            // 
            celnome.Location = new Point(30, 114);
            celnome.Name = "celnome";
            celnome.Size = new Size(100, 23);
            celnome.TabIndex = 0;
            // 
            // celvalor
            // 
            celvalor.Location = new Point(152, 114);
            celvalor.Name = "celvalor";
            celvalor.Size = new Size(100, 23);
            celvalor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(lostAcceptButton1);
            panel1.Controls.Add(skyLabel2);
            panel1.Controls.Add(skyLabel1);
            panel1.Controls.Add(celnome);
            panel1.Controls.Add(celvalor);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(259, 115);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(282, 220);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // lostAcceptButton1
            // 
            lostAcceptButton1.BackColor = SystemColors.ActiveCaption;
            lostAcceptButton1.Font = new Font("Segoe UI", 9F);
            lostAcceptButton1.ForeColor = Color.Black;
            lostAcceptButton1.HoverColor = Color.ForestGreen;
            lostAcceptButton1.Image = null;
            lostAcceptButton1.Location = new Point(81, 163);
            lostAcceptButton1.Name = "lostAcceptButton1";
            lostAcceptButton1.Size = new Size(120, 40);
            lostAcceptButton1.TabIndex = 4;
            lostAcceptButton1.Text = "Salvar";
            lostAcceptButton1.Click += lostAcceptButton1_Click;
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            skyLabel2.ForeColor = Color.White;
            skyLabel2.Location = new Point(30, 83);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(83, 12);
            skyLabel2.TabIndex = 3;
            skyLabel2.Text = "Coluna de nome";
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            skyLabel1.ForeColor = Color.White;
            skyLabel1.Location = new Point(152, 83);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(81, 12);
            skyLabel1.TabIndex = 2;
            skyLabel1.Text = "Coluna de valor";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Config";
            Text = "Config";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox celnome;
        private TextBox celvalor;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton1;
    }
}