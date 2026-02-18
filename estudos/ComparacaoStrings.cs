using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            var texto = "Esse texto é um teste";
            
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));

            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}