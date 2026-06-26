using OfficeOpenXml;

namespace ValidadorDuplicidade
{
    internal class Excel
    {
        bool Data;
        bool Nome = true;
        bool Valor = false;


        public (List<Registro> Lista1,List<Registro> Lista2,List<Registro> Lista3,Dictionary<string, List<Registro>> Duplicados,Dictionary<string, string> nomes)abrirDocumento(string caminho, Filtros filtro)
        {
            if(filtro.Valor)
            {
                Valor = true;
            }
            else
            {
                Valor = false;
            }


            try
            {
                List<Registro> Lista1 = new();
                List<Registro> Lista2 = new();
                List<Registro> Lista3 = new();
                List<Registro> duplicadosTodos = new();

                string filePath = caminho;

                if (string.IsNullOrWhiteSpace(filePath))
                {
                    throw new Erros(404, "Caminho do arquivo não pode ser vazio.");
                }

                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {

                    if (package?.Workbook?.Worksheets == null || package.Workbook.Worksheets.Count < 3)
                    {
                        throw new Erros(406, "O arquivo deve conter pelo menos 3 planilhas." );
                        
                    }


                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    ExcelWorksheet worksheet2 = package.Workbook.Worksheets[1];
                    ExcelWorksheet worksheet3 = package.Workbook.Worksheets[2];

                    if (worksheet.Dimension == null ||
                        worksheet2.Dimension == null ||
                        worksheet3.Dimension == null)
                    {
                         throw new Erros(405, "Uma ou mais planilhas estão vazias ou não possuem dados.");
                    }



                    //momento que define qual celula tem nome e valor;
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string nomeCel = worksheet.Cells[row, 1].Text?.Trim() ?? string.Empty;
                        string tipoCel = worksheet.Cells[row, 2].Text?.Trim() ?? string.Empty;
                        string dataCel = worksheet.Cells[row, 3].Text?.Trim() ?? string.Empty;
                        string valorCel = worksheet.Cells[row, 4].Text?.Trim() ?? string.Empty;

                        if(string.IsNullOrEmpty(nomeCel) && string.IsNullOrEmpty(tipoCel) && string.IsNullOrEmpty(dataCel) && string.IsNullOrEmpty(valorCel))
                        {
                           continue; 
                        }



                        Registro registro = new Registro
                        {
                            NomeRegistro = nomeCel,
                            TipoRegistro = tipoCel,
                            DataRegistro = dataCel,
                            ValorRegistro = valorCel
                        };


                        Lista1.Add(registro);
                    }

                    for (int row = 2; row <= worksheet2.Dimension.End.Row; row++)
                    {
                        string nomeCel = worksheet2.Cells[row, 1].Text?.Trim() ?? string.Empty;
                        string tipoCel = worksheet2.Cells[row, 2].Text?.Trim() ?? string.Empty;
                        string dataCel = worksheet2.Cells[row, 3].Text?.Trim() ?? string.Empty;
                        string valorCel = worksheet2.Cells[row, 4].Text?.Trim() ?? string.Empty;

                        if (string.IsNullOrEmpty(nomeCel) && string.IsNullOrEmpty(tipoCel) && string.IsNullOrEmpty(dataCel) && string.IsNullOrEmpty(valorCel))
                        {
                            continue;
                        }

                        Registro registro = new Registro
                        {
                            NomeRegistro = nomeCel,
                            TipoRegistro = tipoCel,
                            DataRegistro = dataCel,
                            ValorRegistro = valorCel
                        };


                        Lista2.Add(registro);
                    }

                    for (int row = 2; row <= worksheet3.Dimension.End.Row; row++)
                    {
                        string nomeCel = worksheet3.Cells[row, 1].Text?.Trim() ?? string.Empty;
                        string tipoCel = worksheet3.Cells[row, 2].Text?.Trim() ?? string.Empty;
                        string dataCel = worksheet3.Cells[row, 3].Text?.Trim() ?? string.Empty;
                        string valorCel = worksheet3.Cells[row, 4].Text?.Trim() ?? string.Empty;

                        if (string.IsNullOrEmpty(nomeCel) && string.IsNullOrEmpty(tipoCel) && string.IsNullOrEmpty(dataCel) && string.IsNullOrEmpty(valorCel))
                        {
                            continue;
                        }

                        Registro registro = new Registro
                        {
                            NomeRegistro = nomeCel,
                            TipoRegistro = tipoCel,
                            DataRegistro = dataCel,
                            ValorRegistro = valorCel
                        };

                        Lista3.Add(registro);
                    }

                    string nome = worksheet.Name;
                    string nome2 = worksheet2.Name;
                    string nome3 = worksheet3.Name;



                    //aqui vou pegar os filtro novamente (nome, valor, e data) caso o filtro ativo, ele so tras o registro q tem os mesmo pareametos)
                    var registrosDuplicados1 = Lista1.Where(
                        x => Lista3.Any(z =>
                            x.NomeRegistro == z.NomeRegistro && (!Valor || x.ValorRegistro == z.ValorRegistro)
                        )
                    ).ToList();

                    var registrosDuplicados2 = Lista2.Where(
                        x => Lista3.Any(z => x.NomeRegistro == z.NomeRegistro && (!Valor || x.ValorRegistro == z.ValorRegistro))
                        ).ToList();

                    var registrosDuplicados3 = Lista3.Where(
                        x => Lista3.Count(z => x.NomeRegistro == z.NomeRegistro) > 1

                    ).ToList();


                    //compara a lista 3 com a lista 1 e 2, caso aconteça duplicidade dentro da lista 3, tambem retorna esssas duplicidades
                    duplicadosTodos = Lista3
                        .Where(x =>
                            Lista2.Any(y => y.NomeRegistro == x.NomeRegistro)
                            ||
                            Lista1.Any(z => z.NomeRegistro == x.NomeRegistro)
                            ||
                            Lista3.Count(z => z.NomeRegistro == x.NomeRegistro) > 1
                        )
                       
                        .ToList();

                    Dictionary<string, string> nomes = new()
                    {
                        { "nome1", nome },
                        { "nome2", nome2 },
                        { "nome3", nome3 }
                    };


                    Dictionary<string, List<Registro>> duplicados = new()
                    {
                        {"RegistrosLista1", registrosDuplicados1 },
                        {"RegistrosLista2", registrosDuplicados2 },
                        {"RegistrosLista3", registrosDuplicados3 },
                        { "DuplicadosTodos", duplicadosTodos }
                    };

                    //Lista 1 - 3 le todas tabelas sem filtros, Duplicados 1 2 retorna os registros da lista 1 e 2 que tem os mesmo registros da lista 3
                    //sendo assim os duplicados, e o DuplicadosTodos retorna os registros da lista 3 que tem os mesmo registros da lista 1 ou 2, sendo assim os duplicados
                    return (Lista1, Lista2, Lista3, duplicados, nomes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro inesperado: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return (
                    new List<Registro>(),
                    new List<Registro>(),
                    new List<Registro>(),
                    new Dictionary<string, List<Registro>>(),
                    new Dictionary<string, string>()
                );
            }
        }
    }
}