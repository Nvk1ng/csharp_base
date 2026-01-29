using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string nome = RetornaNome("Andre", "baltiere", 30);
            Console.WriteLine(nome);        
            }

        static void MeuMetodo()
        {
            Console.WriteLine("Meu Metodo");
        }

        static string RetornaNome(string nome, string sobrenome, int idade)
        {
            return nome + " " + sobrenome + " " + idade.ToString();
        }
    }
}