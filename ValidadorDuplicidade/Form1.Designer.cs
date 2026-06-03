namespace ValidadorDuplicidade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new ReaLTaiizor.Controls.Panel();
            btn = new ReaLTaiizor.Controls.FoxButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            caminhoSelecionado = new ReaLTaiizor.Controls.HopeTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            QtdPl1 = new ReaLTaiizor.Controls.SkyTextBox();
            pictureBox1 = new PictureBox();
            panel5 = new ReaLTaiizor.Controls.Panel();
            Planilha1 = new ListBox();
            Nome1 = new ReaLTaiizor.Controls.SkyTextBox();
            ZoomP1 = new ReaLTaiizor.Controls.ForeverNumeric();
            panel2 = new ReaLTaiizor.Controls.Panel();
            QtdPl2 = new ReaLTaiizor.Controls.SkyTextBox();
            pictureBox2 = new PictureBox();
            panel4 = new ReaLTaiizor.Controls.Panel();
            Planilha2 = new ListBox();
            ZoomP2 = new ReaLTaiizor.Controls.ForeverNumeric();
            Nome2 = new ReaLTaiizor.Controls.SkyTextBox();
            panel7 = new ReaLTaiizor.Controls.Panel();
            QtdPl3 = new ReaLTaiizor.Controls.SkyTextBox();
            pictureBox3 = new PictureBox();
            panel8 = new ReaLTaiizor.Controls.Panel();
            ZoomP3 = new ReaLTaiizor.Controls.ForeverNumeric();
            Planilha3 = new ListBox();
            Nome3 = new ReaLTaiizor.Controls.SkyTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 51, 63);
            panel3.Controls.Add(btn);
            panel3.Controls.Add(materialButton1);
            panel3.Controls.Add(caminhoSelecionado);
            panel3.Dock = DockStyle.Fill;
            panel3.EdgeColor = Color.FromArgb(32, 41, 50);
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4);
            panel3.Size = new Size(1533, 94);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 26;
            panel3.Text = "panel3";
            panel3.Click += panel3_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.Transparent;
            btn.BaseColor = Color.FromArgb(249, 249, 249);
            btn.BorderColor = Color.FromArgb(193, 193, 193);
            btn.DisabledBaseColor = Color.FromArgb(249, 249, 249);
            btn.DisabledBorderColor = Color.FromArgb(209, 209, 209);
            btn.DisabledTextColor = Color.FromArgb(166, 178, 190);
            btn.DownColor = Color.FromArgb(232, 232, 232);
            btn.EnabledCalc = true;
            btn.Font = new Font("Segoe UI", 10F);
            btn.ForeColor = Color.FromArgb(66, 78, 90);
            btn.Location = new Point(48, 11);
            btn.Name = "btn";
            btn.OverColor = Color.FromArgb(242, 242, 242);
            btn.Size = new Size(181, 41);
            btn.TabIndex = 36;
            btn.Click += foxButton1_Click;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1337, 60);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(175, 26);
            materialButton1.TabIndex = 35;
            materialButton1.Text = "Comparar Tabelas";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // caminhoSelecionado
            // 
            caminhoSelecionado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            caminhoSelecionado.BackColor = Color.FromArgb(44, 55, 66);
            caminhoSelecionado.BaseColor = Color.FromArgb(44, 55, 66);
            caminhoSelecionado.BorderColorA = Color.FromArgb(64, 158, 255);
            caminhoSelecionado.BorderColorB = Color.Transparent;
            caminhoSelecionado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caminhoSelecionado.ForeColor = Color.DarkGray;
            caminhoSelecionado.Hint = "";
            caminhoSelecionado.Location = new Point(246, 11);
            caminhoSelecionado.Margin = new Padding(3, 2, 3, 2);
            caminhoSelecionado.MaxLength = 32767;
            caminhoSelecionado.Multiline = false;
            caminhoSelecionado.Name = "caminhoSelecionado";
            caminhoSelecionado.PasswordChar = '\0';
            caminhoSelecionado.ScrollBars = ScrollBars.None;
            caminhoSelecionado.SelectedText = "";
            caminhoSelecionado.SelectionLength = 0;
            caminhoSelecionado.SelectionStart = 0;
            caminhoSelecionado.Size = new Size(1266, 41);
            caminhoSelecionado.TabIndex = 23;
            caminhoSelecionado.TabStop = false;
            caminhoSelecionado.Text = "hopeTextBox1";
            caminhoSelecionado.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 2, 1);
            tableLayoutPanel1.Location = new Point(30, 112);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.38888884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98.6111145F));
            tableLayoutPanel1.Size = new Size(1539, 453);
            tableLayoutPanel1.TabIndex = 31;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(QtdPl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(4, 10);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(504, 439);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 23;
            panel1.Text = "panel1";
            panel1.Click += panel1_Click;
            // 
            // QtdPl1
            // 
            QtdPl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QtdPl1.BackColor = Color.FromArgb(192, 192, 255);
            QtdPl1.BaseColor = Color.Transparent;
            QtdPl1.BorderColorA = Color.Transparent;
            QtdPl1.BorderColorB = Color.Transparent;
            QtdPl1.BorderColorC = Color.Transparent;
            QtdPl1.BorderColorD = Color.Transparent;
            QtdPl1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QtdPl1.ForeColor = Color.Navy;
            QtdPl1.Location = new Point(357, 28);
            QtdPl1.Margin = new Padding(3, 2, 3, 2);
            QtdPl1.MaxLength = 32767;
            QtdPl1.MultiLine = false;
            QtdPl1.Name = "QtdPl1";
            QtdPl1.Size = new Size(108, 23);
            QtdPl1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            QtdPl1.TabIndex = 30;
            QtdPl1.Text = "skyTextBox1";
            QtdPl1.TextAlignment = HorizontalAlignment.Center;
            QtdPl1.UnknownBackColor = Color.FromArgb(43, 43, 43);
            QtdPl1.UseSystemPasswordChar = false;
            QtdPl1.Click += QtdPl1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 36);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(49, 61, 63);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(Planilha1);
            panel5.Controls.Add(Nome1);
            panel5.Controls.Add(ZoomP1);
            panel5.EdgeColor = Color.FromArgb(39, 51, 63);
            panel5.Location = new Point(4, 62);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(4);
            panel5.Size = new Size(495, 373);
            panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel5.TabIndex = 27;
            panel5.Text = "panel5";
            // 
            // Planilha1
            // 
            Planilha1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha1.BackColor = Color.White;
            Planilha1.Font = new Font("Segoe UI", 9F);
            Planilha1.ForeColor = SystemColors.Window;
            Planilha1.FormattingEnabled = true;
            Planilha1.HorizontalScrollbar = true;
            Planilha1.Location = new Point(4, 37);
            Planilha1.Margin = new Padding(3, 2, 3, 2);
            Planilha1.Name = "Planilha1";
            Planilha1.Size = new Size(487, 274);
            Planilha1.TabIndex = 40;
            // 
            // Nome1
            // 
            Nome1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nome1.BackColor = Color.FromArgb(49, 61, 63);
            Nome1.BaseColor = Color.Transparent;
            Nome1.BorderColorA = Color.Transparent;
            Nome1.BorderColorB = Color.Transparent;
            Nome1.BorderColorC = Color.Transparent;
            Nome1.BorderColorD = Color.Transparent;
            Nome1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome1.ForeColor = SystemColors.Window;
            Nome1.Location = new Point(89, 4);
            Nome1.Margin = new Padding(3, 2, 3, 2);
            Nome1.MaxLength = 32767;
            Nome1.MultiLine = false;
            Nome1.Name = "Nome1";
            Nome1.Size = new Size(323, 26);
            Nome1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Nome1.TabIndex = 35;
            Nome1.TextAlignment = HorizontalAlignment.Center;
            Nome1.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome1.UseSystemPasswordChar = false;
            // 
            // ZoomP1
            // 
            ZoomP1.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP1.ButtonColorA = Color.Lime;
            ZoomP1.ButtonColorB = Color.Black;
            ZoomP1.ButtonColorC = Color.Black;
            ZoomP1.Font = new Font("Segoe UI", 10F);
            ZoomP1.ForeColor = Color.White;
            ZoomP1.Location = new Point(281, 6);
            ZoomP1.Margin = new Padding(3, 2, 3, 2);
            ZoomP1.Maximum = 100L;
            ZoomP1.Minimum = 0L;
            ZoomP1.Name = "ZoomP1";
            ZoomP1.Size = new Size(75, 30);
            ZoomP1.TabIndex = 37;
            ZoomP1.Text = "foreverNumeric1";
            ZoomP1.Value = 0L;
            ZoomP1.Click += foreverNumeric1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 51, 63);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(QtdPl2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.EdgeColor = Color.FromArgb(32, 41, 50);
            panel2.Location = new Point(516, 10);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(505, 439);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 25;
            panel2.Text = "\\\\\\";
            // 
            // QtdPl2
            // 
            QtdPl2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QtdPl2.BackColor = Color.FromArgb(192, 192, 255);
            QtdPl2.BaseColor = Color.Transparent;
            QtdPl2.BorderColorA = Color.Transparent;
            QtdPl2.BorderColorB = Color.Transparent;
            QtdPl2.BorderColorC = Color.Transparent;
            QtdPl2.BorderColorD = Color.Transparent;
            QtdPl2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QtdPl2.ForeColor = Color.Navy;
            QtdPl2.Location = new Point(374, 28);
            QtdPl2.Margin = new Padding(3, 2, 3, 2);
            QtdPl2.MaxLength = 32767;
            QtdPl2.MultiLine = false;
            QtdPl2.Name = "QtdPl2";
            QtdPl2.Size = new Size(108, 23);
            QtdPl2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            QtdPl2.TabIndex = 31;
            QtdPl2.Text = "skyTextBox1";
            QtdPl2.TextAlignment = HorizontalAlignment.Center;
            QtdPl2.UnknownBackColor = Color.FromArgb(43, 43, 43);
            QtdPl2.UseSystemPasswordChar = false;
            QtdPl2.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(22, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(49, 61, 63);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(Planilha2);
            panel4.Controls.Add(ZoomP2);
            panel4.Controls.Add(Nome2);
            panel4.EdgeColor = Color.FromArgb(39, 51, 63);
            panel4.Location = new Point(4, 62);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(496, 373);
            panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel4.TabIndex = 26;
            panel4.Text = "panel4";
            // 
            // Planilha2
            // 
            Planilha2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha2.BackColor = Color.White;
            Planilha2.Font = new Font("Segoe UI", 9F);
            Planilha2.ForeColor = SystemColors.Window;
            Planilha2.FormattingEnabled = true;
            Planilha2.HorizontalScrollbar = true;
            Planilha2.Location = new Point(4, 37);
            Planilha2.Margin = new Padding(3, 2, 3, 2);
            Planilha2.Name = "Planilha2";
            Planilha2.Size = new Size(488, 274);
            Planilha2.TabIndex = 39;
            // 
            // ZoomP2
            // 
            ZoomP2.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP2.ButtonColorA = Color.Blue;
            ZoomP2.ButtonColorB = Color.Black;
            ZoomP2.ButtonColorC = Color.Black;
            ZoomP2.Font = new Font("Segoe UI", 10F);
            ZoomP2.ForeColor = Color.White;
            ZoomP2.Location = new Point(271, 6);
            ZoomP2.Margin = new Padding(3, 2, 3, 2);
            ZoomP2.Maximum = 100L;
            ZoomP2.Minimum = 0L;
            ZoomP2.Name = "ZoomP2";
            ZoomP2.Size = new Size(75, 30);
            ZoomP2.TabIndex = 38;
            ZoomP2.Text = "foreverNumeric1";
            ZoomP2.Value = 0L;
            ZoomP2.Click += foreverNumeric1_Click_1;
            // 
            // Nome2
            // 
            Nome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nome2.BackColor = Color.FromArgb(49, 61, 63);
            Nome2.BaseColor = Color.Transparent;
            Nome2.BorderColorA = Color.Transparent;
            Nome2.BorderColorB = Color.Transparent;
            Nome2.BorderColorC = Color.Transparent;
            Nome2.BorderColorD = Color.Transparent;
            Nome2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome2.ForeColor = SystemColors.Window;
            Nome2.Location = new Point(79, 4);
            Nome2.Margin = new Padding(3, 2, 3, 2);
            Nome2.MaxLength = 32767;
            Nome2.MultiLine = false;
            Nome2.Name = "Nome2";
            Nome2.Size = new Size(324, 26);
            Nome2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Nome2.TabIndex = 36;
            Nome2.TextAlignment = HorizontalAlignment.Center;
            Nome2.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome2.UseSystemPasswordChar = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(39, 51, 63);
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(QtdPl3);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.EdgeColor = Color.FromArgb(32, 41, 50);
            panel7.Location = new Point(1029, 10);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(4);
            panel7.Size = new Size(506, 439);
            panel7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel7.TabIndex = 29;
            panel7.Text = "panel7";
            panel7.Click += panel7_Click;
            // 
            // QtdPl3
            // 
            QtdPl3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QtdPl3.BackColor = Color.FromArgb(192, 192, 255);
            QtdPl3.BaseColor = Color.Transparent;
            QtdPl3.BorderColorA = Color.Transparent;
            QtdPl3.BorderColorB = Color.Transparent;
            QtdPl3.BorderColorC = Color.Transparent;
            QtdPl3.BorderColorD = Color.Transparent;
            QtdPl3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QtdPl3.ForeColor = Color.Navy;
            QtdPl3.Location = new Point(378, 22);
            QtdPl3.Margin = new Padding(3, 2, 3, 2);
            QtdPl3.MaxLength = 32767;
            QtdPl3.MultiLine = false;
            QtdPl3.Name = "QtdPl3";
            QtdPl3.Size = new Size(106, 23);
            QtdPl3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            QtdPl3.TabIndex = 32;
            QtdPl3.Text = "skyTextBox1";
            QtdPl3.TextAlignment = HorizontalAlignment.Center;
            QtdPl3.UnknownBackColor = Color.FromArgb(43, 43, 43);
            QtdPl3.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Location = new Point(22, 22);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 36);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(49, 61, 63);
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(ZoomP3);
            panel8.Controls.Add(Planilha3);
            panel8.Controls.Add(Nome3);
            panel8.EdgeColor = Color.FromArgb(39, 51, 63);
            panel8.Location = new Point(0, 62);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(4);
            panel8.Size = new Size(493, 373);
            panel8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel8.TabIndex = 27;
            panel8.Text = "panel8";
            // 
            // ZoomP3
            // 
            ZoomP3.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP3.ButtonColorA = Color.Crimson;
            ZoomP3.ButtonColorB = Color.Black;
            ZoomP3.ButtonColorC = Color.Black;
            ZoomP3.Font = new Font("Segoe UI", 10F);
            ZoomP3.ForeColor = Color.White;
            ZoomP3.Location = new Point(281, 4);
            ZoomP3.Margin = new Padding(3, 2, 3, 2);
            ZoomP3.Maximum = 100L;
            ZoomP3.Minimum = 0L;
            ZoomP3.Name = "ZoomP3";
            ZoomP3.Size = new Size(75, 30);
            ZoomP3.TabIndex = 39;
            ZoomP3.Text = "foreverNumeric1";
            ZoomP3.Value = 0L;
            ZoomP3.Click += ZoomP3_Click;
            // 
            // Planilha3
            // 
            Planilha3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha3.BackColor = Color.White;
            Planilha3.Font = new Font("Segoe UI", 9F);
            Planilha3.ForeColor = SystemColors.Window;
            Planilha3.FormattingEnabled = true;
            Planilha3.HorizontalScrollbar = true;
            Planilha3.Location = new Point(4, 37);
            Planilha3.Margin = new Padding(3, 2, 3, 2);
            Planilha3.Name = "Planilha3";
            Planilha3.Size = new Size(485, 274);
            Planilha3.TabIndex = 25;
            // 
            // Nome3
            // 
            Nome3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nome3.BackColor = Color.FromArgb(49, 61, 63);
            Nome3.BaseColor = Color.Transparent;
            Nome3.BorderColorA = Color.Transparent;
            Nome3.BorderColorB = Color.Transparent;
            Nome3.BorderColorC = Color.Transparent;
            Nome3.BorderColorD = Color.Transparent;
            Nome3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nome3.ForeColor = SystemColors.Window;
            Nome3.Location = new Point(79, 4);
            Nome3.Margin = new Padding(3, 2, 3, 2);
            Nome3.MaxLength = 32767;
            Nome3.MultiLine = false;
            Nome3.Name = "Nome3";
            Nome3.Size = new Size(324, 26);
            Nome3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Nome3.TabIndex = 37;
            Nome3.TextAlignment = HorizontalAlignment.Center;
            Nome3.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome3.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Location = new Point(30, 9);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1539, 98);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1594, 625);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = ".";
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.HopeTextBox caminhoSelecionado;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.SkyTextBox QtdPl1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Panel panel5;
        private ReaLTaiizor.Controls.SkyTextBox Nome1;
        private ReaLTaiizor.Controls.Panel panel7;
        private ReaLTaiizor.Controls.SkyTextBox QtdPl3;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.Panel panel8;
        private ListBox Planilha3;
        private ReaLTaiizor.Controls.SkyTextBox Nome3;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.SkyTextBox QtdPl2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.SkyTextBox Nome2;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP1;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP2;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP3;
        private ListBox Planilha2;
        private ListBox Planilha1;
        private ReaLTaiizor.Controls.FoxButton btn;
    }
}
