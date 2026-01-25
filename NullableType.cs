using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? idade = null;
            byte? t = 127;

            Console.WriteLine(idade);
            Console.WriteLine(t);


            int? num = 0;
            Console.WriteLine(num);
            num = null;
            Console.WriteLine(num);
            num = 25;
            Console.WriteLine(num);
        }
    }
}