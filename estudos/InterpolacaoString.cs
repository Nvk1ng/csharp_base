using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //var text = "O preço do produto é " + price + " apenas na promoçao!";
            //var text = string.Format("O preço do produto é {0} apenas na promoçao", price);
            var text = $"o preço do produto é {price} apenas na promocao";

            Console.WriteLine(text);
        }
    }
}