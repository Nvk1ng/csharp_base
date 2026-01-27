using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            E - and &&
            OU - or ||
            Negacao - not !
            */

            int x = 12;

            bool entre = (x > 25) && (x < 40); // false
            bool ou = (x > 25) || (x < 40); // true
            bool negacao = !(x < 25); // falase
        }
    }
}