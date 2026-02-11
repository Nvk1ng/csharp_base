using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("0f1d61e5-b605-4258-898d-bfe26f64b3dc");
            Console.WriteLine(id);
        }
    }
}