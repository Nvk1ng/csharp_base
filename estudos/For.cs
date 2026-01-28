using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for(var i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for(var i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}