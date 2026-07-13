namespace ValidadorDuplicidade
{
    partial class Report
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            QtdPl1 = new ReaLTaiizor.Controls.SkyLabel();
            panel5 = new ReaLTaiizor.Controls.Panel();
            panel2 = new ReaLTaiizor.Controls.Panel();
            label2 = new Label();
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            label1 = new Label();
            Descricao = new RichTextBox();
            ZoomP1 = new ReaLTaiizor.Controls.ForeverNumeric();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.Location = new Point(8, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(957, 256);
            flowLayoutPanel1.TabIndex = 44;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 73, 134);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(QtdPl1);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = Color.DarkGray;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(1041, 623);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 24;
            panel1.Text = "panel1";
            // 
            // QtdPl1
            // 
            QtdPl1.AutoSize = true;
            QtdPl1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QtdPl1.ForeColor = Color.White;
            QtdPl1.Location = new Point(414, 9);
            QtdPl1.Name = "QtdPl1";
            QtdPl1.Size = new Size(212, 23);
            QtdPl1.TabIndex = 37;
            QtdPl1.Text = "Reportar problema";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(aloneButton1);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(Descricao);
            panel5.Controls.Add(ZoomP1);
            panel5.Dock = DockStyle.Bottom;
            panel5.EdgeColor = Color.FromArgb(39, 51, 63);
            panel5.Location = new Point(4, 43);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(4);
            panel5.Size = new Size(1033, 576);
            panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel5.TabIndex = 27;
            panel5.Text = "panel5";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 145, 204);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.EdgeColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(30, 225);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(973, 272);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 46;
            panel2.Text = "panel2";
            panel2.Click += panel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 201);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 45;
            label2.Text = "Anexar fotos";
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton1.Location = new Point(489, 524);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(55, 40);
            aloneButton1.TabIndex = 42;
            aloneButton1.Text = "Send";
            aloneButton1.Click += aloneButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 4);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 41;
            label1.Text = "Descreva o problema";
            // 
            // Descricao
            // 
            Descricao.BackColor = Color.White;
            Descricao.ForeColor = SystemColors.WindowText;
            Descricao.Location = new Point(30, 28);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(973, 138);
            Descricao.TabIndex = 38;
            Descricao.Text = "";
            // 
            // ZoomP1
            // 
            ZoomP1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZoomP1.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP1.ButtonColorA = Color.FromArgb(83, 145, 204);
            ZoomP1.ButtonColorB = Color.Black;
            ZoomP1.ButtonColorC = Color.Black;
            ZoomP1.Font = new Font("Segoe UI", 10F);
            ZoomP1.ForeColor = Color.White;
            ZoomP1.Location = new Point(1263, 11);
            ZoomP1.Margin = new Padding(3, 2, 3, 2);
            ZoomP1.Maximum = 100L;
            ZoomP1.Minimum = 0L;
            ZoomP1.Name = "ZoomP1";
            ZoomP1.Size = new Size(75, 30);
            ZoomP1.TabIndex = 37;
            ZoomP1.Text = "foreverNumeric1";
            ZoomP1.Value = 0L;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1041, 623);
            Controls.Add(panel1);
            ImeMode = ImeMode.Disable;
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Panel panel5;
        private RichTextBox Descricao;
        private ReaLTaiizor.Controls.SkyLabel QtdPl1;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP1;
        private Label label1;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ReaLTaiizor.Controls.Panel panel2;
    }
}