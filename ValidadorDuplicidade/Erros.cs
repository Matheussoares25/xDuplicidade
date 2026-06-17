using System;
using System.Collections.Generic;
using System.Text;

namespace ValidadorDuplicidade
{
    internal class Erros : Exception
    {

        public int CodigoErro { get; }

        public Erros(int codigoErro, string mensagem)
            : base(mensagem)
        {
            CodigoErro = codigoErro;
        }

        public void ExibirMensagem()
        {
            Console.WriteLine($"Erro {CodigoErro}: {Message}");
        }


    }

}

