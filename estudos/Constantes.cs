using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            tambem utilizamos constantes para armazenar informaçoes;
            as constates NAO PODEM ser alteradas;
            uma vez criadas somos obrigados a definir um valor;
            */

            const int IDADE_MINIMA; // Correto inicia com ZERO
            const int IDADE_MINIMA = 25: // Correto inicia com 25
            const var IDADE_MINIMA = 25; // Errado
            const var IDADE_MINIMA; // Errado
        }
    }
}