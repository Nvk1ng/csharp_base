using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto = "Olá, Mundo!";
            Console.WriteLine(texto.Replace("Olá", "Oi"));
            Console.WriteLine(texto.Replace("o", "x"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);

            var resultado = texto.Substring(4, 5);
            Console.WriteLine(resultado);

            Console.WriteLine(resultado.Trim());
        }
    }
}