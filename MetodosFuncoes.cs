using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo("C# é bom!");

            var nome = RetornaNome("Matheus", "Sanderhus");
            Console.WriteLine(nome);
        }

        // Definiçao do metodo
        static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}