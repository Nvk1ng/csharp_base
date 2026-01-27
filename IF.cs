using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            if(idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }

            int numero = 5;
            if(numero % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("ímpar");
            }

            int nota = 75;
            if(nota >= 90)
            {
                Console.WriteLine("A");
            }else if(nota >= 70){
                Console.WriteLine("B");
            }else if(nota >= 50)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}