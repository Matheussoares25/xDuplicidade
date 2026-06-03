using MaterialSkin.Controls;
using OfficeOpenXml;
using OfficeOpenXml.Data.Connection;
using Ookii.Dialogs.WinForms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
using ReaLTaiizor.Forms;
using System.Security.Cryptography;
using System.Windows.Forms;




namespace ValidadorDuplicidade
{
    public partial class Form1 : Form
    {



        Filtros f = new Filtros();

        List<string> r = new List<string>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.BackColor = Color.FromArgb(35, 35, 35);

            Planilha1.BorderStyle = BorderStyle.None;
            Planilha2.BorderStyle = BorderStyle.None;
            Planilha3.BorderStyle = BorderStyle.None;




            ExcelPackage.License.SetNonCommercialPersonal("Matheus");



            ZoomP1.Minimum = 9;
            ZoomP2.Minimum = 9;
            ZoomP3.Minimum = 9;


            Planilha1.Sorted = true;
            Planilha2.Sorted = true;
            Planilha3.Sorted = true;


            preencherListas();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn.ForeColor = Color.Black;

            Planilha1.BackColor = panel1.BackColor;
            Planilha1.ForeColor = Color.White;

            Planilha2.BackColor = panel2.BackColor;
            Planilha2.ForeColor = Color.White;

            Planilha3.BackColor = panel3.BackColor;
            Planilha3.ForeColor = Color.White;


        }




        private async void alertar(int numeroDuplicados)
        {

            switch (numeroDuplicados)
            {
                case 0:
                    MessageBox.Show("Nenhum registro duplicado encontrado.");
                    //FotoErro.BackgroundImage = Properties.Resources.Sucesso;
                    break;
                case < 5:
                    Piscar("amarelo");
                    //FotoErro.BackgroundImage = Properties.Resources.alerta;
                    break;
                default:
                    Piscar("vermelho");
                    //FotoErro.BackgroundImage = Properties.Resources.critico;
                    break;
            }

        }

        private async void Piscar(string cor)
        {
            switch (cor)
            {
                case "vermelho":
                    for (int i = 0; i < 5; i++)
                    {
                        //FotoErro.BackgroundImage = Properties.Resources.critico;
                        await Task.Delay(150);
                        //FotoErro.BackgroundImage = null;
                        await Task.Delay(150);
                        //FotoErro.BackgroundImage = Properties.Resources.critico;

                    }
                    break;
                case "amarelo":
                    for (int i = 0; i < 3; i++)
                    {
                        //FotoErro.BackgroundImage = Properties.Resources.alerta;
                        await Task.Delay(150);
                        //FotoErro.BackgroundImage = null;
                        await Task.Delay(150);
                        //FotoErro.BackgroundImage = Properties.Resources.alerta;
                    }
                    break;

            }

        }


        private void LoadTela(int tereceiraPlanilha = 0)
        {




        }

        public void preencherListas()
        {

            try
            {


                Planilha1.Sorted = true;
                Planilha2.Sorted = true;
                Planilha3.Sorted = true;


                Excel excel = new Excel();




                var retorno = excel.abrirDocumento(Properties.Settings.Default.Caminho_arq, f);


                Planilha1.Items.Clear();
                Planilha2.Items.Clear();
                Planilha3.Items.Clear();

                var contador1 = 0;
                var contador2 = 0;
                var contador3 = 0;
                var numeroDuplicados = 0;


                foreach (var dado in retorno.Lista1)
                {
                    contador1++;


                    Planilha1.Items.Add(dado);


                }

                foreach (var dado in retorno.Lista2)
                {
                    contador2++;
                    Planilha2.Items.Add(dado);

                }
                foreach (var dado in retorno.Lista3)
                {
                    contador3++;
                    Planilha3.Items.Add(dado);
                }

                foreach (var dado in retorno.Duplicados["DuplicadosTodos"])
                {

                    numeroDuplicados++;

                }

                if (numeroDuplicados >= 0)
                {
                    alertar(numeroDuplicados);
                    //QtdDuplicidade.Text = numeroDuplicados.ToString() + "  Registros Duplicados";
                }


                caminhoSelecionado.Text = Properties.Settings.Default.Caminho_arq;
                QtdPl2.Text = contador2.ToString() + "  Registros";
                QtdPl3.Text = contador3.ToString() + "  Registros";
                QtdPl1.Text = contador1.ToString() + "  Registros";

                Nome1.Text = retorno.nomes["nome1"] + " Tabela 1";
                Nome2.Text = retorno.nomes["nome2"] + " Tabela 2";
                Nome3.Text = retorno.nomes["nome3"] + " Tabela 3";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o arquivo: " + ex.Message + "\nNão existe duas planilhas para serem comparadas entre si.", "Sem items para comparar", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void smallTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void airButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Duplicados_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.Filter = "Excel (*.xlsx)|*.xlsx|Todos (*.*)|*.*";

            arquivo.Title = "Escolha um arquivo";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                caminhoSelecionado.Text = arquivo.FileName;

                Properties.Settings.Default.Caminho_arq = arquivo.FileName;
                Properties.Settings.Default.Save();


                Planilha1.Items.Clear();
                Planilha2.Items.Clear();

                LoadTela();
                preencherListas();

            }
        }



        private void QtdPl1_Click(object sender, EventArgs e)
        {

        }

        private void crownCheckBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Duplicados d = new Duplicados();
            d.Show();

            preencherListas();

        }

        private void spaceButton1_Click(object sender, EventArgs e)
        {


        }

        private void FechaTerceira_Click(object sender, EventArgs e)
        {



            LoadTela(0);

            panel7.Visible = false;


        }

        private void hopeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void panel7_Click(object sender, EventArgs e)
        {

        }

        private void AbreTerceira_Click(object sender, EventArgs e)
        {




            preencherListas();

            panel7.Visible = true;


        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void Planilha2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void foreverNumeric1_Click(object sender, EventArgs e)
        {


            Planilha1.Font = new Font(
                Planilha1.Font.FontFamily,
                (float)ZoomP1.Value,
                Planilha1.Font.Style
            );


        }

        private void foreverNumeric1_Click_1(object sender, EventArgs e)
        {
            Planilha2.Font = new Font(Planilha2.Font.FontFamily,
                (float)ZoomP2.Value,
                Planilha2.Font.Style
            );
        }

        private void ZoomP3_Click(object sender, EventArgs e)
        {
            Planilha3.Font = new Font(Planilha3.Font.FontFamily,
                (float)ZoomP3.Value,
                Planilha3.Font.Style
            );
        }

        private void ZoomD_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void Ordem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void foxButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
