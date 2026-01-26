using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            soma -> +
            subtraçao -> - 
            multiplicaçao -> *
            divisao -> /
            */

            int soma = 25 + 10;
            int sub = 100 - 20;
            int divisao = 10 / 2;
            int mul = 10 * 2;

            // Utilizamos parenteses para redefinir a ordem de execuçao
            int x = 2 + 2 * 2;
            int y = 2 + (2 * 2);
            int z = (2 + 2) * 2;
        }
    }
}