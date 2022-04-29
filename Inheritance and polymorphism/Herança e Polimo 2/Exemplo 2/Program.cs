using System;
using Exemplo_2.Entities;
using System.Collections.Generic;

namespace Exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>(); 
            
            Console.Write("Enter the number of products ");
            int nProduct = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nProduct; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)?");
                string answer = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                float price = float.Parse(Console.ReadLine());

                if (answer == "i")
                {
                    Console.Write("Customs fee: ");
                    float fee = float.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else if (answer == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.WriteLine("Valued as Common Product");
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
