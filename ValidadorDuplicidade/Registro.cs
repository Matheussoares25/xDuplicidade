using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ValidadorDuplicidade
{
    public class Registro
    {
       public string NomeRegistro;

        public string TipoRegistro;

        public string ValorRegistro;

        public string DataRegistro;



        public override string ToString()
        {
            return $"{NomeRegistro} - {DataRegistro} - {ValorRegistro}";
        }

        public string[] RetornArray()
        {
            return new string[] { NomeRegistro, TipoRegistro, ValorRegistro, DataRegistro };
        }

    }
}
