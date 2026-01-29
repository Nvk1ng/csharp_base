using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            int x = 25;
            int y = x;
            Console.WriteLine(x); // 25
            Console.WriteLine(y); // 25
            x = 32;
            Console.WriteLine(x); // 32
            Console.WriteLine(y); // 25

            // Reference Type
            var arr = new string[2];
            arr[0] = "item 1";
            var arr2 = arr;

            Console.WriteLine(arr);
            Console.WriteLine(arr2);

            arr[0] = "Item Alterado";
            Console.WriteLine(arr);
            Console.WriteLine(arr2);
        }
    }
}