using MaterialSkin.Controls;
using OfficeOpenXml;
using OfficeOpenXml.Data.Connection;
using Ookii.Dialogs.WinForms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Extension;
using ReaLTaiizor.Forms;
using System.CodeDom;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;





namespace ValidadorDuplicidade
{
    public partial class Form1 : Form
    {



        Filtros f = new Filtros();

        List<string> r = new List<string>();

        int numeroDuplicados = 0;
        public Form1()
        {

            InitializeComponent();
            this.Load += Form1_Load;

            Properties.Settings.Default.Caminho_arq = null;


            ToolTip dica = new ToolTip();

            dica.SetToolTip(QtdPl1, "Quantidade de registros na Planilha 1");
            dica.SetToolTip(QtdPl2, "Quantidade de registros na Planilha 2");
            dica.SetToolTip(QtdPl3, "Quantidade de registros na Planilha 3");
            dica.SetToolTip(btn, "Selecione um arquivo para validar a duplicidade dos dados");






            if (Properties.Settings.Default.Caminho_arq == null || Properties.Settings.Default.Caminho_arq == "")
            {
                tableLayoutPanel1.Visible = false;
                return;
            }
            else
            {
                preencherListas();
            }

            Planilha1.BorderStyle = BorderStyle.None;
            Planilha2.BorderStyle = BorderStyle.None;
            Planilha3.BorderStyle = BorderStyle.None;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn.ForeColor = Color.Silver;

            Planilha1.ForeColor = Color.White;


            Planilha2.ForeColor = Color.White;


            Planilha3.ForeColor = Color.White;


        }





        private void LoadTela(int tereceiraPlanilha = 0)
        {




        }

        public void preencherListas()
        {

            ZoomP1.Minimum = 9;
            ZoomP2.Minimum = 9;
            ZoomP3.Minimum = 9;


            Planilha1.Sorted = true;
            Planilha2.Sorted = true;
            Planilha3.Sorted = true;


            ExcelPackage.License.SetNonCommercialPersonal("Matheus");



            try
            {
                numeroDuplicados = 0;

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
                tableLayoutPanel1.Visible = true;

                caminhoSelecionado.Text = Properties.Settings.Default.Caminho_arq;
                QtdPl2.Text = contador2.ToString() + "  Registros";
                QtdPl3.Text = contador3.ToString() + "  Registros";
                QtdPl1.Text = contador1.ToString() + "  Registros";

                Nome1.Text = retorno.nomes["nome1"] + " Tabela 1";
                Nome2.Text = retorno.nomes["nome2"] + " Tabela 2";
                Nome3.Text = retorno.nomes["nome3"] + " Tabela 3";
            }
            catch (Erros ex)
            {
                MessageBox.Show(ex.Message, "Erro ao abrir o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                limpaDados();
                Properties.Settings.Default.Caminho_arq = null;
            }


        }
        private void limpaDados()
        {
            //caminhoSelecionado.Text = string.Empty;
            Properties.Settings.Default.Caminho_arq = null;
            tableLayoutPanel1.Visible = false;
            caminhoSelecionado.Text = null;

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

        }



        private void QtdPl1_Click(object sender, EventArgs e)
        {

        }

        private void crownCheckBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

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

        private void btn_Click_1(object sender, EventArgs e)
        {


            Excel excel = new Excel();
            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.Filter = "Excel (*.xlsx)|*.xlsx|Todos (*.*)|*.*";

            arquivo.Title = "Escolha um arquivo";

            try
            {
                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    caminhoSelecionado.Text = arquivo.FileName;

                    Properties.Settings.Default.Caminho_arq = arquivo.FileName;
                    Properties.Settings.Default.Save();


                    Planilha1.Items.Clear();
                    Planilha2.Items.Clear();
                }
                else { return; }
                preencherListas();
            }
            catch (Exception ex)
            {
            }
        }

        private void parrotButton1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Caminho_arq == null || caminhoSelecionado.Text == null)
            {
                var res = MessageBox.Show("Nenhum arquivo selecionado. Por favor, selecione um arquivo continuar!. \nDeseja Selecionar um arquivo agora?", "Arquivo Não Selecionado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    btn_Click_1(sender, e);

                }

                return;
            }
            if (numeroDuplicados > 0)
            {
                var res = MessageBox.Show("Existem " + numeroDuplicados + " registros duplicados. Deseja revisar os dados para garantir a integridade das informações.", "Alerta de Duplicidade", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Duplicados d = new Duplicados();
                    d.Show();
                }
            }

            if (numeroDuplicados == 0)
            {
                var res = MessageBox.Show("Nenhum registro duplicado encontrado. Deseja revisar os dados para garantir a integridade das informações.", "Validação Concluída", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Duplicados d = new Duplicados();
                    d.Show();
                }
            }

            numeroDuplicados = 0;

            preencherListas();



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void nightHeaderLabel1_Click(object sender, EventArgs e)
        {
            btn_Click_1(sender, e);
        }

        private void spaceLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hopeNotify1_Click(object sender, EventArgs e)
        {

        }



        private void panel6_Click(object sender, EventArgs e)
        {
            btn_Click_1(sender, e);
        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void skyLabel1_Click(object sender, EventArgs e)
        {

        }

        private void parrotButton2_Click(object sender, EventArgs e)
        {

        }

        private void problemasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirUmChamadoRelacionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatarProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.ShowDialog();

        }

        private void formularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/forms/d/e/1FAIpQLSdELOdNUu5spQlh57C4lATaTv7DSP6zPwe9r2QK1GI1kgMXXw/viewform",
                UseShellExecute = true
            });
        }
    }
}
