using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este esto é um teste";
            Console.WriteLine(texto.IndexOf("teste"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}