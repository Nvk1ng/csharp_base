using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utilizado quando temos muitas decisoes

            string valor = "matheus";
            switch (valor)
            {
                case "joao": Console.WriteLine("Olá joao"); break;
                case "marcelo": Console.WriteLine("Olá marcelo"); break;
                case "matheus": Console.WriteLine("Olá matheus"); break;
                default: Console.WriteLine("Nao encontrei"); break;
            }
        }
    }
}