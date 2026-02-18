using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("teste"));
        }
    }
}