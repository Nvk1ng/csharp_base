using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Uma variavel é algo que utilizamos para armazenar uma informaçao;
            Ser variavel significa que seu valor pode ser alterado a qualquer momento;
            Sempre que criamos uma variavel dizemos que estamos iniciando ela.
            */

            string primeiroNome = "Matheus";
            int idade; // Correto inicia com ZERO
            int idade = 25; // Correto inica com 25
            var idade = 25; // Correto inicia com 25
            var idade; // errado
        }
    }
}