using System;

namespace ders2_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Monkey Shoulder";
            product1.ProductOrigin = "Scotland";
            product1.ProductPrice = 16.98;

            Product product2 = new Product();
            product2.ProductName = "Jack Daniels";
            product2.ProductOrigin = "America";
            product2.ProductPrice = 66.98;

            Product product3 = new Product();
            product3.ProductName = "J&B";
            product3.ProductOrigin = "England";
            product3.ProductPrice = 56.98;

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product1.ProductName + " : " + product1.ProductPrice);
            }

        }

    }
    class Product
    {
        public string ProductName { get; set; }
        public string ProductOrigin { get; set; }
        public double ProductPrice { get; set; }
    }
}
