using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ocorre quando os tipo nao sao compativeis;
            e dada pelo uso do entre parenteses antes da atribuiçao;
            Segue as mesmas regras anteriores;
            */

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; // Conversao explícita
        }
    }
}