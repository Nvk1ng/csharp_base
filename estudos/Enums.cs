using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product mouse = new Product();
            var mouse = new Product(1, "mouse gamer", 20.99, EProductType.Product);
            var manutencaoEletrica = new Product(2, "manutencao eletrica", 500, EProductType.Service);

            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Name);
            Console.WriteLine(manutencaoEletrica.Price);
            Console.WriteLine(manutencaoEletrica.Type);


            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
        }
    }
    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name; 
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}   
