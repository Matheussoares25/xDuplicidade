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
            caminhoSelecionado = new ReaLTaiizor.Controls.HopeTextBox();
            panel3 = new ReaLTaiizor.Controls.Panel();
            parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            btn = new ReaLTaiizor.Controls.ParrotButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            panel7 = new ReaLTaiizor.Controls.Panel();
            QtdPl3 = new ReaLTaiizor.Controls.SkyLabel();
            panel8 = new ReaLTaiizor.Controls.Panel();
            pictureBox5 = new PictureBox();
            ZoomP3 = new ReaLTaiizor.Controls.ForeverNumeric();
            Planilha3 = new ListBox();
            Nome3 = new ReaLTaiizor.Controls.SkyTextBox();
            Panel2 = new ReaLTaiizor.Controls.Panel();
            QtdPl2 = new ReaLTaiizor.Controls.SkyLabel();
            panel4 = new ReaLTaiizor.Controls.Panel();
            pictureBox2 = new PictureBox();
            Planilha2 = new ListBox();
            Nome2 = new ReaLTaiizor.Controls.SkyTextBox();
            ZoomP2 = new ReaLTaiizor.Controls.ForeverNumeric();
            panel1 = new ReaLTaiizor.Controls.Panel();
            QtdPl1 = new ReaLTaiizor.Controls.SkyLabel();
            panel5 = new ReaLTaiizor.Controls.Panel();
            Planilha1 = new ListBox();
            pictureBox1 = new PictureBox();
            Nome1 = new ReaLTaiizor.Controls.SkyTextBox();
            ZoomP1 = new ReaLTaiizor.Controls.ForeverNumeric();
            tableLayoutPanel1 = new TableLayoutPanel();
            nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            panel6 = new Panel();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            Panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // caminhoSelecionado
            // 
            caminhoSelecionado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            caminhoSelecionado.BackColor = Color.FromArgb(44, 55, 66);
            caminhoSelecionado.BaseColor = Color.FromArgb(44, 55, 66);
            caminhoSelecionado.BorderColorA = Color.FromArgb(64, 158, 255);
            caminhoSelecionado.BorderColorB = Color.Transparent;
            caminhoSelecionado.Enabled = false;
            caminhoSelecionado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caminhoSelecionado.ForeColor = Color.DarkGray;
            caminhoSelecionado.Hint = "";
            caminhoSelecionado.Location = new Point(285, 26);
            caminhoSelecionado.MaxLength = 32767;
            caminhoSelecionado.Multiline = false;
            caminhoSelecionado.Name = "caminhoSelecionado";
            caminhoSelecionado.PasswordChar = '\0';
            caminhoSelecionado.ScrollBars = ScrollBars.None;
            caminhoSelecionado.SelectedText = "";
            caminhoSelecionado.SelectionLength = 0;
            caminhoSelecionado.SelectionStart = 0;
            caminhoSelecionado.Size = new Size(1307, 47);
            caminhoSelecionado.TabIndex = 23;
            caminhoSelecionado.TabStop = false;
            caminhoSelecionado.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(parrotButton1);
            panel3.Controls.Add(btn);
            panel3.Controls.Add(caminhoSelecionado);
            panel3.Dock = DockStyle.Top;
            panel3.EdgeColor = Color.FromArgb(32, 41, 50);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(1816, 98);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 26;
            panel3.Text = "panel3";
            panel3.Click += panel3_Click;
            // 
            // parrotButton1
            // 
            parrotButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parrotButton1.BackgroundColor = Color.FromArgb(83, 145, 204);
            parrotButton1.ButtonImage = null;
            parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton1.ButtonText = "Comparar Planilhas";
            parrotButton1.ClickBackColor = Color.Silver;
            parrotButton1.ClickTextColor = Color.White;
            parrotButton1.CornerRadius = 5;
            parrotButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotButton1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton1.HoverTextColor = Color.Black;
            parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton1.Location = new Point(1599, 26);
            parrotButton1.Margin = new Padding(3, 4, 3, 4);
            parrotButton1.Name = "parrotButton1";
            parrotButton1.Size = new Size(197, 47);
            parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton1.TabIndex = 38;
            parrotButton1.TextColor = Color.White;
            parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton1.Vertical_Alignment = StringAlignment.Center;
            parrotButton1.Click += parrotButton1_Click;
            // 
            // btn
            // 
            btn.BackgroundColor = Color.FromArgb(83, 145, 204);
            btn.ButtonImage = Properties.Resources.pasta;
            btn.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btn.ButtonText = "Selecionar Arquivo";
            btn.ClickBackColor = Color.Silver;
            btn.ClickTextColor = Color.White;
            btn.CornerRadius = 2;
            btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn.Horizontal_Alignment = StringAlignment.Center;
            btn.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btn.HoverTextColor = Color.Black;
            btn.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btn.Location = new Point(26, 26);
            btn.Margin = new Padding(3, 4, 3, 4);
            btn.Name = "btn";
            btn.Size = new Size(239, 47);
            btn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn.TabIndex = 37;
            btn.TextColor = Color.White;
            btn.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn.Vertical_Alignment = StringAlignment.Center;
            btn.Click += btn_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel2.Size = new Size(1822, 104);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.Silver;
            pictureBox4.BackgroundImage = Properties.Resources.logo_GLPI_250_black;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(623, 108);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(577, 119);
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(41, 73, 134);
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(QtdPl3);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.EdgeColor = Color.Silver;
            panel7.Location = new Point(1177, 13);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(577, 597);
            panel7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel7.TabIndex = 29;
            panel7.Text = "panel7";
            panel7.Click += panel7_Click;
            // 
            // QtdPl3
            // 
            QtdPl3.AutoSize = true;
            QtdPl3.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            QtdPl3.ForeColor = Color.White;
            QtdPl3.Location = new Point(484, 13);
            QtdPl3.Name = "QtdPl3";
            QtdPl3.Size = new Size(75, 14);
            QtdPl3.TabIndex = 40;
            QtdPl3.Text = "skyLabel1";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(64, 64, 64);
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(ZoomP3);
            panel8.Controls.Add(Planilha3);
            panel8.Controls.Add(Nome3);
            panel8.EdgeColor = Color.FromArgb(39, 51, 63);
            panel8.Location = new Point(0, 41);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(569, 550);
            panel8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel8.TabIndex = 27;
            panel8.Text = "panel8";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Location = new Point(8, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 47);
            pictureBox5.TabIndex = 43;
            pictureBox5.TabStop = false;
            // 
            // ZoomP3
            // 
            ZoomP3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZoomP3.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP3.ButtonColorA = Color.FromArgb(83, 145, 204);
            ZoomP3.ButtonColorB = Color.Black;
            ZoomP3.ButtonColorC = Color.Black;
            ZoomP3.Font = new Font("Segoe UI", 10F);
            ZoomP3.ForeColor = Color.White;
            ZoomP3.Location = new Point(473, 16);
            ZoomP3.Maximum = 100L;
            ZoomP3.Minimum = 0L;
            ZoomP3.Name = "ZoomP3";
            ZoomP3.Size = new Size(86, 30);
            ZoomP3.TabIndex = 39;
            ZoomP3.Text = "foreverNumeric1";
            ZoomP3.Value = 0L;
            ZoomP3.Click += ZoomP3_Click;
            // 
            // Planilha3
            // 
            Planilha3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha3.BackColor = SystemColors.ControlDarkDark;
            Planilha3.BorderStyle = BorderStyle.None;
            Planilha3.Font = new Font("Segoe UI", 9F);
            Planilha3.ForeColor = SystemColors.Menu;
            Planilha3.FormattingEnabled = true;
            Planilha3.Location = new Point(4, 61);
            Planilha3.Name = "Planilha3";
            Planilha3.Size = new Size(559, 480);
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
            Nome3.Location = new Point(83, 16);
            Nome3.MaxLength = 32767;
            Nome3.MultiLine = false;
            Nome3.Name = "Nome3";
            Nome3.Size = new Size(376, 30);
            Nome3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Nome3.TabIndex = 37;
            Nome3.TextAlignment = HorizontalAlignment.Center;
            Nome3.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome3.UseSystemPasswordChar = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(41, 73, 134);
            Panel2.BackgroundImageLayout = ImageLayout.None;
            Panel2.Controls.Add(QtdPl2);
            Panel2.Controls.Add(panel4);
            Panel2.Dock = DockStyle.Fill;
            Panel2.EdgeColor = Color.Silver;
            Panel2.Location = new Point(591, 13);
            Panel2.Margin = new Padding(5);
            Panel2.Name = "Panel2";
            Panel2.Padding = new Padding(5);
            Panel2.Size = new Size(576, 597);
            Panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Panel2.TabIndex = 25;
            Panel2.Text = "\\\\\\";
            // 
            // QtdPl2
            // 
            QtdPl2.AutoSize = true;
            QtdPl2.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            QtdPl2.ForeColor = Color.White;
            QtdPl2.Location = new Point(493, 13);
            QtdPl2.Name = "QtdPl2";
            QtdPl2.Size = new Size(75, 14);
            QtdPl2.TabIndex = 39;
            QtdPl2.Text = "skyLabel1";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(Planilha2);
            panel4.Controls.Add(Nome2);
            panel4.Controls.Add(ZoomP2);
            panel4.EdgeColor = Color.FromArgb(39, 51, 63);
            panel4.Location = new Point(5, 41);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(565, 550);
            panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel4.TabIndex = 26;
            panel4.Text = "panel4";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(8, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 47);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // Planilha2
            // 
            Planilha2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha2.BackColor = SystemColors.ControlDarkDark;
            Planilha2.BorderStyle = BorderStyle.None;
            Planilha2.Font = new Font("Segoe UI", 9F);
            Planilha2.ForeColor = SystemColors.Menu;
            Planilha2.FormattingEnabled = true;
            Planilha2.Location = new Point(5, 61);
            Planilha2.Name = "Planilha2";
            Planilha2.Size = new Size(552, 480);
            Planilha2.TabIndex = 41;
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
            Nome2.Location = new Point(96, 16);
            Nome2.MaxLength = 32767;
            Nome2.MultiLine = false;
            Nome2.Name = "Nome2";
            Nome2.Size = new Size(368, 30);
            Nome2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.None;
            Nome2.TabIndex = 40;
            Nome2.TextAlignment = HorizontalAlignment.Center;
            Nome2.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome2.UseSystemPasswordChar = false;
            // 
            // ZoomP2
            // 
            ZoomP2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZoomP2.BaseColor = Color.FromArgb(45, 47, 49);
            ZoomP2.ButtonColorA = Color.FromArgb(83, 145, 204);
            ZoomP2.ButtonColorB = Color.Black;
            ZoomP2.ButtonColorC = Color.Black;
            ZoomP2.Font = new Font("Segoe UI", 10F);
            ZoomP2.ForeColor = Color.White;
            ZoomP2.Location = new Point(471, 16);
            ZoomP2.Maximum = 100L;
            ZoomP2.Minimum = 0L;
            ZoomP2.Name = "ZoomP2";
            ZoomP2.Size = new Size(86, 30);
            ZoomP2.TabIndex = 38;
            ZoomP2.Text = "foreverNumeric1";
            ZoomP2.Value = 0L;
            ZoomP2.Click += foreverNumeric1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 73, 134);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(QtdPl1);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = Color.DarkGray;
            panel1.Location = new Point(5, 13);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(576, 597);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 23;
            panel1.Text = "panel1";
            panel1.Click += panel1_Click;
            // 
            // QtdPl1
            // 
            QtdPl1.AutoSize = true;
            QtdPl1.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            QtdPl1.ForeColor = Color.White;
            QtdPl1.Location = new Point(490, 13);
            QtdPl1.Name = "QtdPl1";
            QtdPl1.Size = new Size(75, 14);
            QtdPl1.TabIndex = 37;
            QtdPl1.Text = "skyLabel1";
            QtdPl1.Click += skyLabel1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(Planilha1);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(Nome1);
            panel5.Controls.Add(ZoomP1);
            panel5.EdgeColor = Color.FromArgb(39, 51, 63);
            panel5.Location = new Point(5, 41);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(566, 550);
            panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel5.TabIndex = 27;
            panel5.Text = "panel5";
            // 
            // Planilha1
            // 
            Planilha1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha1.BackColor = SystemColors.ControlDarkDark;
            Planilha1.BorderStyle = BorderStyle.None;
            Planilha1.Font = new Font("Segoe UI", 9F);
            Planilha1.ForeColor = SystemColors.Menu;
            Planilha1.FormattingEnabled = true;
            Planilha1.Location = new Point(5, 61);
            Planilha1.Name = "Planilha1";
            Planilha1.Size = new Size(555, 480);
            Planilha1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 47);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
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
            Nome1.Location = new Point(99, 16);
            Nome1.MaxLength = 32767;
            Nome1.MultiLine = false;
            Nome1.Name = "Nome1";
            Nome1.Size = new Size(369, 30);
            Nome1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.None;
            Nome1.TabIndex = 35;
            Nome1.TextAlignment = HorizontalAlignment.Center;
            Nome1.UnknownBackColor = Color.FromArgb(43, 43, 43);
            Nome1.UseSystemPasswordChar = false;
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
            ZoomP1.Location = new Point(475, 16);
            ZoomP1.Maximum = 100L;
            ZoomP1.Minimum = 0L;
            ZoomP1.Name = "ZoomP1";
            ZoomP1.Size = new Size(86, 30);
            ZoomP1.TabIndex = 37;
            ZoomP1.Text = "foreverNumeric1";
            ZoomP1.Value = 0L;
            ZoomP1.Click += foreverNumeric1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(Panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel7, 2, 1);
            tableLayoutPanel1.Location = new Point(29, 230);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.38888884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98.6111145F));
            tableLayoutPanel1.Size = new Size(1759, 615);
            tableLayoutPanel1.TabIndex = 31;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // nightHeaderLabel1
            // 
            nightHeaderLabel1.Anchor = AnchorStyles.Top;
            nightHeaderLabel1.BackColor = Color.Transparent;
            nightHeaderLabel1.Cursor = Cursors.Hand;
            nightHeaderLabel1.Font = new Font("Segoe UI Historic", 18.75F);
            nightHeaderLabel1.ForeColor = Color.Gray;
            nightHeaderLabel1.LeftSideForeColor = Color.Gray;
            nightHeaderLabel1.Location = new Point(412, 149);
            nightHeaderLabel1.Name = "nightHeaderLabel1";
            nightHeaderLabel1.RightSideForeColor = Color.FromArgb(170, 171, 176);
            nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            nightHeaderLabel1.Size = new Size(920, 49);
            nightHeaderLabel1.TabIndex = 35;
            nightHeaderLabel1.Text = "Antes de iniciar, selecione o arquivo para realizar a comparação!";
            nightHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nightHeaderLabel1.UseCompatibleTextRendering = true;
            nightHeaderLabel1.Click += nightHeaderLabel1_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(nightHeaderLabel1);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(39, 245);
            panel6.Name = "panel6";
            panel6.Size = new Size(1744, 346);
            panel6.TabIndex = 36;
            panel6.Click += panel6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Silver;
            ClientSize = new Size(1822, 849);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel6);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "xDuplicidades";
            TransparencyKey = Color.Fuchsia;
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.HopeTextBox caminhoSelecionado;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.ParrotButton btn;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.Panel panel7;
        private ReaLTaiizor.Controls.Panel panel8;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP3;
        private ListBox Planilha3;
        private ReaLTaiizor.Controls.SkyTextBox Nome3;
        private ReaLTaiizor.Controls.Panel Panel2;
        private ReaLTaiizor.Controls.Panel panel4;
        private PictureBox pictureBox2;
        private ListBox Planilha2;
        private ReaLTaiizor.Controls.SkyTextBox Nome2;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP2;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Panel panel5;
        private ListBox Planilha1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.SkyTextBox Nome1;
        private ReaLTaiizor.Controls.ForeverNumeric ZoomP1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.SkyLabel QtdPl1;
        private ReaLTaiizor.Controls.SkyLabel QtdPl3;
        private ReaLTaiizor.Controls.SkyLabel QtdPl2;
    }
}
