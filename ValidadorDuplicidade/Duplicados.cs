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

        private int CelulaNome = 0;
        private int CelulaValor = 3;

        private string CabeçalhoNome = "Nome";
        private string CabeçalhoTipo = "Tipo";
        private string CabeçalhoVencimento = "Vencimento";
        private string CabeçalhoValor = "Valor";

        bool PanelAtivo = true;

        bool ultimasemanaExpand = false;
        bool penultimaSemanaExpand = false;






        public Duplicados()
        {

            InitializeComponent();

            TabelaResultado.Columns["Nome"].HeaderText = CabeçalhoNome;
            TabelaResultado.Columns["Tipo"].HeaderText = CabeçalhoTipo;
            TabelaResultado.Columns["Vencimento"].HeaderText = CabeçalhoVencimento;
            TabelaResultado.Columns["Valor"].HeaderText = CabeçalhoValor;

            ResultadoLista2.Columns["NomeUltimaTb"].HeaderText = CabeçalhoNome;
            ResultadoLista2.Columns["TipoUltimaTb"].HeaderText = CabeçalhoTipo;
            ResultadoLista2.Columns["VencimentoUltimaTb"].HeaderText = CabeçalhoVencimento;
            ResultadoLista2.Columns["ValorUltimaTb"].HeaderText = CabeçalhoValor;

            ResultadoLista1.Columns["NomePenultimaTb"].HeaderText = CabeçalhoNome;
            ResultadoLista1.Columns["TipoPenultimaTb"].HeaderText = CabeçalhoTipo;
            ResultadoLista1.Columns["VencimentoPenultimaTb"].HeaderText = CabeçalhoVencimento;
            ResultadoLista1.Columns["ValorPenultimaTb"].HeaderText = CabeçalhoValor;


            ToolTip dica = new ToolTip();
            ToolTip info = new ToolTip();

            dica.ToolTipIcon = ToolTipIcon.Info;
           
            //dica.SetToolTip(DescRegistrosVigente, "Destaca itens que foram encontrados somente na semana vigente (A busca é feita baseada no nome dos registros)");
            info.SetToolTip(BtnEscondeDicas, "Exibe ou esconde as dicas para utilização da ferramenta");
            info.SetToolTip(BtnExpandirUltimaSemana, "Recolhe ou expande a tabela com os registros da ultima semana");
            info.SetToolTip(BtnExpandirPenultimaSemana, "Recolhe ou expande a tabela com os registros da penultima semana");

            ResultadoLista1.ClearSelection();
            ResultadoLista2.ClearSelection();


            init();
            Colorir();

            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void FiltroValor_CheckedChanged(object sender, EventArgs e)
        {

            //Os contadores marcam a quantidade de registro dentro das tabelas;
            //São zerados quando o filtro é aplicado para recomeçar a contagem;



        }

        private void Colorir()
        {
            ResultadoLista2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaResultado.Sort(TabelaResultado.Columns[CelulaNome], System.ComponentModel.ListSortDirection.Ascending);
            ResultadoLista1.Sort(ResultadoLista1.Columns[CelulaNome], System.ComponentModel.ListSortDirection.Ascending);
            ResultadoLista2.Sort(ResultadoLista2.Columns[CelulaNome], System.ComponentModel.ListSortDirection.Ascending);


            foreach (DataGridViewRow rowL2 in ResultadoLista2.Rows)
            {
                string Nome = rowL2.Cells[CelulaNome].Value?.ToString();
                string Valor = rowL2.Cells[CelulaValor].Value?.ToString();

                foreach (DataGridViewRow row in TabelaResultado.Rows)
                {
                    bool nomeIgual = row.Cells[CelulaNome].Value?.ToString() == Nome;
                    bool valorIgual = row.Cells[CelulaValor].Value?.ToString() == Valor;

                    if (nomeIgual && valorIgual)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    }


                }
            }

            foreach (DataGridViewRow rowL1 in ResultadoLista1.Rows)
            {
                string Nome = rowL1.Cells[CelulaNome].Value?.ToString();
                string Valor = rowL1.Cells[CelulaValor].Value?.ToString();
                foreach (DataGridViewRow row in TabelaResultado.Rows)
                {
                    bool nomeIgual = row.Cells[CelulaNome].Value?.ToString() == Nome;
                    bool valorIgual = row.Cells[CelulaValor].Value?.ToString() == Valor;
                    if (nomeIgual && valorIgual)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    }
                }

            }


            foreach (DataGridViewRow rowResultado in TabelaResultado.Rows)
            {
                string nome = rowResultado.Cells[CelulaNome].Value?.ToString();
                string valor = rowResultado.Cells[CelulaValor].Value?.ToString();

                bool existeNaLista1 = false;
                bool existeNaLista2 = false;

                foreach (DataGridViewRow row in ResultadoLista1.Rows)
                {
                    if (row.Cells[CelulaNome].Value?.ToString() == nome &&
                        row.Cells[CelulaValor].Value?.ToString() == valor)
                    {
                        existeNaLista1 = true;
                        break;
                    }
                }

                foreach (DataGridViewRow row in ResultadoLista2.Rows)
                {
                    if (row.Cells[CelulaNome].Value?.ToString() == nome &&
                        row.Cells[CelulaValor].Value?.ToString() == valor)
                    {
                        existeNaLista2 = true;
                        break;
                    }
                }

                if (existeNaLista1 && existeNaLista2)
                {
                    rowResultado.DefaultCellStyle.BackColor = Color.MediumBlue;
                    rowResultado.DefaultCellStyle.ForeColor = Color.White;
                    rowResultado.DefaultCellStyle.SelectionBackColor = Color.MediumBlue;


                }

                rowResultado.DefaultCellStyle.Font = new Font("segui ui", 9, FontStyle.Regular);
            }


        }

            //foreach (DataGridViewRow row in TabelaResultado.Rows)
            //{
            //    string nome = row.Cells[CelulaNome].Value?.ToString();

            //    bool existeNaLista1 = true;
            //    bool existeNaLista2 = true;


            //    foreach (DataGridViewRow rowL1 in ResultadoLista1.Rows)
            //    {
            //        if (rowL1.Cells[CelulaNome].Value?.ToString() == nome)
            //        {
            //            existeNaLista1 = false;
            //            break;
            //        }
            //    }


            //    foreach (DataGridViewRow rowL2 in ResultadoLista2.Rows)
            //    {
            //        if (rowL2.Cells[CelulaNome].Value?.ToString() == nome)
            //        {
            //            existeNaLista2 = false;
            //            break;
            //        }
            //    }

            //    if (existeNaLista1 && existeNaLista2)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.SlateGray;
            //        row.DefaultCellStyle.ForeColor = Color.White;
            //    }
            //}
        
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
                        dado.NomeRegistro,
                        dado.TipoRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador++;

                }

                QtdResultado.Text = contador.ToString();

                foreach (var dado in retorno.Duplicados["RegistrosLista1"])
                {
                    ResultadoLista1.Rows.Add(
                        dado.NomeRegistro,
                        dado.TipoRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador1++;
                }
                QtdTabela1.Text = contador1.ToString();

                foreach (var dado in retorno.Duplicados["RegistrosLista2"])
                {
                    ResultadoLista2.Rows.Add(
                        dado.NomeRegistro,
                        dado.TipoRegistro,
                        dado.DataRegistro,
                        dado.ValorRegistro
                    );
                    contador2++;
                }
                QtdTabela2.Text = contador2.ToString();


                DataUltimaSemana.Text = retorno.nomes["nome2"] + " - " + "Ultima Semana";
                DataPenultimaSemana.Text = retorno.nomes["nome1"] + " - " + "Penultima Semana";
                DataVigente.Text = "Itens duplicados na semana Vigente: " + retorno.nomes["nome3"] + " - " + "Semana Atual";

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

            string Nome = TabelaResultado.CurrentRow.Cells[CelulaNome].Value?.ToString();
            string Valor = TabelaResultado.CurrentRow.Cells[CelulaValor].Value?.ToString();

            bool existeNaPenultima = false;
            bool existeNaUltima = false;

            //foreach (DataGridViewRow r in ResultadoLista1.Rows)
            //    r.DefaultCellStyle.BackColor = Color.Empty;

            ResultadoLista1.ClearSelection();
            ResultadoLista2.ClearSelection();


            //a lista1 é a amarela que representa a penultima semana;
            foreach (DataGridViewRow row in ResultadoLista1.Rows)
            {
                bool nomeIgual = row.Cells[CelulaNome].Value?.ToString() == Nome;
                bool valorIgual = row.Cells[CelulaValor].Value?.ToString() == Valor;

                if (nomeIgual && valorIgual)
                {

                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    ResultadoLista1.CurrentCell = row.Cells[0];
                    existeNaPenultima = true;

                    break;
                }

                if (nomeIgual)
                {
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Silver;
                    row.DefaultCellStyle.SelectionBackColor = Color.Silver;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    ResultadoLista1.CurrentCell = row.Cells[0];
                    existeNaPenultima = true;

                    
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
                bool nomeIgual = row.Cells[CelulaNome].Value?.ToString() == Nome;
                bool valorIgual = row.Cells[CelulaValor].Value?.ToString() == Valor;

                if (nomeIgual && valorIgual)
                {
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    ResultadoLista2.CurrentCell = row.Cells[0];
                    existeNaUltima = true;

                   
                    break;
                }

                if (nomeIgual)
                {
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = Color.Silver;
                    row.DefaultCellStyle.SelectionBackColor = Color.Silver;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    ResultadoLista2.CurrentCell = row.Cells[0];
                    existeNaUltima = true;


                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }


            if ((existeNaPenultima || existeNaUltima) && (penultimaSemanaExpand || ultimasemanaExpand))
            {

                
              var openregistro =  MessageBox.Show(
                    "O registro selecionado possui repetição em uma ou mais planilhas anteriores. Para facilitar a visualização desses registros repetidos,Deseja espandir as tabelas nas quais esse registro tambem existe?.",
                    "Item Encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);


                if(openregistro == DialogResult.Yes)
                {

                    if (existeNaPenultima)
                    {
                        penultimaSemanaExpand = false;
                        CentralTabelas.RowStyles[2].Height = 50;

                       
                        BtnExpandirPenultimaSemana.Text = "˅";
                    }

                    if (existeNaUltima)
                    {
                        
                        CentralTabelas.RowStyles[1].Height = 50;

                        ultimasemanaExpand = false;
                        BtnExpandirUltimaSemana.Text = "˅";
                    }

                }
            }
            if(!existeNaUltima && !existeNaPenultima)
            {
                MessageBox.Show(
                    "O item selecionado não foi encontrado nas semanas anteriores. O registro só teve repetição na semana vigente",
                    "Registro repetido só na semana vigente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            //Filtro de Valor
            //f.Valor = FiltroValor.Checked;
            //contador = 0;
            //contador1 = 0;
            //contador2 = 0;

            //init();
            //Colorir();
        }

        private void ZoomP1_Click(object sender, EventArgs e)
        {

        }



        private void ordenarTamanhos()
        {
            if (ultimasemanaExpand)
            {

                if (CentralTabelas.RowStyles[1].Height > 5)
                {
                    CentralTabelas.RowStyles[1].Height = 5;
                }
            }

            if (penultimaSemanaExpand) { 

                if(CentralTabelas.RowStyles[2].Height > 5)
                {
                    CentralTabelas.RowStyles[2].Height = 5;
                }
            }

            if (CentralTabelas.RowStyles[0].Height < 50)
            {
                CentralTabelas.RowStyles[0].Height = 50;
            }
        }

        private void royalButton1_Click(object sender, EventArgs e)
        {
            PanelAtivo = !PanelAtivo;

            PanelDicas.Height = PanelAtivo ? 210 : 37;

            BtnEscondeDicas.Text = PanelAtivo ? "˄" : "˅";
            NavBar.Visible = PanelAtivo;
           
                ordenarTamanhos();
                           
        }

        
        private void royalButton1_Click_1(object sender, EventArgs e)
        {

           

            CentralTabelas.RowStyles[1].Height = ultimasemanaExpand? 50 : 7;


            ultimasemanaExpand = !ultimasemanaExpand;


            BtnExpandirUltimaSemana.Text = ultimasemanaExpand? "˄" : "˅";

            ordenarTamanhos();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void royalButton2_Click(object sender, EventArgs e)
        {


            CentralTabelas.RowStyles[2].Height = penultimaSemanaExpand? 50 : 7;

            penultimaSemanaExpand = !penultimaSemanaExpand;

            BtnExpandirPenultimaSemana.Text = penultimaSemanaExpand ? "˄" : "˅";

            ordenarTamanhos();
        }
    }


}
