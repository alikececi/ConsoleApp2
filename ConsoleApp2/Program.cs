using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }

            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }

            else
            {
                Console.WriteLine("Eşit");
            }






        }
    }
}
