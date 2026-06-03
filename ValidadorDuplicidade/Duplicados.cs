using System;
using System.Windows.Forms;

namespace ValidadorDuplicidade
{
    public partial class Duplicados : Form

    {
        private List<Registro> DuplicadosLista;
        private List<Registro> List1;
        private List<Registro> List2;

        public int contador;
        public int contador1;
        public int contador2;

        Filtros f = new Filtros();
        Excel excel = new Excel();




        public Duplicados()
        {


            InitializeComponent();

            ResultadoLista1.ClearSelection();
            ResultadoLista2.ClearSelection();


            init();
            Colorir();




        }

        private void FiltroValor_CheckedChanged(object sender, EventArgs e)
        {

            //Os contadores marcam a quantidade de registro dentro das tabelas;
            //São zerados quando o filtro é aplicado para recomeçar a contagem;

           

        }

        private void Colorir()
        {
            ResultadoLista2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaResultado.Sort(TabelaResultado.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            ResultadoLista1.Sort(ResultadoLista1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            ResultadoLista2.Sort(ResultadoLista2.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            foreach (DataGridViewRow rowL2 in ResultadoLista2.Rows)
            {
                string Nome = rowL2.Cells[1].Value?.ToString();
                string Valor = rowL2.Cells[3].Value?.ToString();

                foreach (DataGridViewRow row in TabelaResultado.Rows)
                {
                    bool nomeIgual = row.Cells[1].Value?.ToString() == Nome;
                    bool valorIgual = row.Cells[3].Value?.ToString() == Valor;

                    if (nomeIgual && valorIgual)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }


                }
            }

            foreach (DataGridViewRow rowL1 in ResultadoLista1.Rows)
            {
                string Nome = rowL1.Cells[1].Value?.ToString();
                string Valor = rowL1.Cells[3].Value?.ToString();
                foreach (DataGridViewRow row in TabelaResultado.Rows)
                {
                    bool nomeIgual = row.Cells[1].Value?.ToString() == Nome;
                    bool valorIgual = row.Cells[3].Value?.ToString() == Valor;
                    if (nomeIgual && valorIgual)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }

            }


            foreach (DataGridViewRow rowResultado in TabelaResultado.Rows)
            {
                string nome = rowResultado.Cells[1].Value?.ToString();
                string valor = rowResultado.Cells[3].Value?.ToString();

                bool existeNaLista1 = false;
                bool existeNaLista2 = false;

                foreach (DataGridViewRow row in ResultadoLista1.Rows)
                {
                    if (row.Cells[1].Value?.ToString() == nome &&
                        row.Cells[3].Value?.ToString() == valor)
                    {
                        existeNaLista1 = true;
                        break;
                    }
                }

                foreach (DataGridViewRow row in ResultadoLista2.Rows)
                {
                    if (row.Cells[1].Value?.ToString() == nome &&
                        row.Cells[3].Value?.ToString() == valor)
                    {
                        existeNaLista2 = true;
                        break;
                    }
                }

                if (existeNaLista1 && existeNaLista2)
                {
                    rowResultado.DefaultCellStyle.BackColor = Color.MediumBlue;
                    rowResultado.DefaultCellStyle.ForeColor = Color.White;
                }
            }



        }
        public void init()
        {
            try
            {
                TabelaResultado.Rows.Clear();
                ResultadoLista1.Rows.Clear();
                ResultadoLista2.Rows.Clear();

                var retorno = excel.abrirDocumento(Properties.Settings.Default.Caminho_arq, f);


                foreach (var dado in retorno.Duplicados["DuplicadosTodos"])
                {
                    TabelaResultado.Rows.Add(
                        dado.NumeroRegistro,
                        dado.NomeRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador++;

                }

                QtdResultado.Text = contador.ToString();

                foreach (var dado in retorno.Duplicados["RegistrosLista1"])
                {
                    ResultadoLista1.Rows.Add(
                        dado.NumeroRegistro,
                        dado.NomeRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador1++;
                }
                QtdTabela1.Text = contador1.ToString();

                foreach (var dado in retorno.Duplicados["RegistrosLista2"])
                {
                    ResultadoLista2.Rows.Add(
                        dado.NumeroRegistro,
                        dado.NomeRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador2++;
                }
                QtdTabela2.Text = contador2.ToString();


                DataUltimaSemana.Text = retorno.nomes["nome2"];
                DataPenultimaSemana.Text = retorno.nomes["nome1"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message + "\nNão existe planilhas suficientes para serem comparadas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Duplicados_Load(object? sender, EventArgs e)
        {

        }

        private void moonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private async void TabelaResultado_CellClick(object sender, EventArgs e)
        {


            if (TabelaResultado.CurrentRow == null) return;



            string Nome = TabelaResultado.CurrentRow.Cells[1].Value?.ToString();
            string Valor = TabelaResultado.CurrentRow.Cells[3].Value?.ToString();

            foreach (DataGridViewRow r in ResultadoLista1.Rows)
                r.DefaultCellStyle.BackColor = Color.Empty;

            ResultadoLista1.ClearSelection();
            ResultadoLista2.ClearSelection();

            foreach (DataGridViewRow row in ResultadoLista1.Rows)
            {
                bool nomeIgual = row.Cells[1].Value?.ToString() == Nome;
                bool valorIgual = row.Cells[3].Value?.ToString() == Valor;

                if (nomeIgual && valorIgual)
                {

                    //for (int i = 0; i < 3; i++)
                    //{
                    //    row.DefaultCellStyle.BackColor = Color.Red;
                    //    await Task.Delay(200);
                    //    row.DefaultCellStyle.BackColor = Color.Orange;
                    //    await Task.Delay(200);
                    //    row.DefaultCellStyle.BackColor = Color.White;

                    //}

                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    ResultadoLista1.CurrentCell = row.Cells[0];
                    break;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

            }

            foreach (DataGridViewRow row in ResultadoLista2.Rows)
            {
                bool nomeIgual = row.Cells[1].Value?.ToString() == Nome;
                bool valorIgual = row.Cells[3].Value?.ToString() == Valor;

                if (nomeIgual && valorIgual)
                {

                    ////for (int i = 0; i < 3; i++)
                    ////{
                    ////    row.DefaultCellStyle.BackColor = Color.Red;
                    ////    await Task.Delay(200);
                    ////    row.DefaultCellStyle.BackColor = Color.Orange;
                    ////    await Task.Delay(200);
                    ////    row.DefaultCellStyle.BackColor = Color.White;


                    ////}
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    ResultadoLista2.CurrentCell = row.Cells[0];
                    break;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResultadoLista2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultadoLista1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPenultimaSemana_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {

        }

        private void crownCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FiltroValor_CheckedChanged_1(object sender, EventArgs e)
        {
            f.Valor = FiltroValor.Checked;
            contador = 0;
            contador1 = 0;
            contador2 = 0;

            init();
            Colorir();
        }
    }


}
