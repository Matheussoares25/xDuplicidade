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
                    MessageBox.Show(
                        "Nenhum arquivo selecionado.",
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

                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {

                    if (package?.Workbook?.Worksheets == null || package.Workbook.Worksheets.Count < 2)
                    {
                        return (
                            new List<Registro>(),
                            new List<Registro>(),
                            new List<Registro>(),
                            new Dictionary<string, List<Registro>>(),
                            new Dictionary<string, string>()
                        );
                    }

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    ExcelWorksheet worksheet2 = package.Workbook.Worksheets[1];
                    ExcelWorksheet worksheet3 = package.Workbook.Worksheets[2];

                    if (worksheet.Dimension == null ||
                        worksheet2.Dimension == null ||
                        worksheet3.Dimension == null)
                    {
                        MessageBox.Show(
                            "Uma ou mais planilhas não existem.",
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


                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        Registro registro = new Registro
                        {
                            NumeroRegistro = worksheet.Cells[row, 1].Text,
                            NomeRegistro = worksheet.Cells[row, 2].Text,
                            DataRegistro =  worksheet.Cells[row, 3].Text,
                            ValorRegistro =  worksheet.Cells[row, 4].Text
                        };

                        Lista1.Add(registro);
                    }

                    for (int row = 2; row <= worksheet2.Dimension.End.Row; row++)
                    {
                        Registro registro = new Registro
                        {
                            NumeroRegistro = worksheet2.Cells[row, 1].Text ,
                            NomeRegistro = worksheet2.Cells[row, 2].Text ,
                            DataRegistro = worksheet2.Cells[row, 3].Text ,
                            ValorRegistro =  worksheet2.Cells[row, 4].Text
                        };

                        Lista2.Add(registro);
                    }

                    for (int row = 2; row <= worksheet3.Dimension.End.Row; row++)
                    {
                        Registro registro = new Registro
                        {
                            NumeroRegistro =  worksheet3.Cells[row, 1].Text,
                            NomeRegistro =worksheet3.Cells[row, 2].Text ,
                            DataRegistro =  worksheet3.Cells[row, 3].Text ,
                            ValorRegistro =  worksheet3.Cells[row, 4].Text 
                        };

                        Lista3.Add(registro);
                    }

                    string nome = worksheet.Name;
                    string nome2 = worksheet2.Name;
                    string nome3 = worksheet3.Name;


                    var duplicadosDentroda2 = Lista2
                        .Where(x => Lista2.Count(y => x.NumeroRegistro == y.NumeroRegistro) > 1)
                        .Distinct()
                        .ToList();



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
                    $"Erro ao abrir o arquivo: {ex.Message}",
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