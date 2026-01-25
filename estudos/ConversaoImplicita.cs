using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            É comum precisarmos transformar dados do tipo X em Y;
            As conversoes implicitas sao conversoes que:
                Podem ser executadas apenas com passagem de dados;
                Possuem dados compatíveis.
            */
            float valor = 25.8f;
            int outro = 25;
            valor = outro;
        }
    }
}