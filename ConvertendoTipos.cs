using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            // real = inteiro;
            // inteiro = (int)real;
            // string valorReal = real.ToString();
            // inteiro = int.Parse(real);
            // inteiro = Convert.ToInt32(real);

            // Console.WriteLine(valorReal);
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean("true"));
        }
    }
}