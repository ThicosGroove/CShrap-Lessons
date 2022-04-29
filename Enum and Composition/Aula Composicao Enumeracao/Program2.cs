using System;
using System.Collections.Generic;
using Aula_Composicao_Enumeracao.Entities;
using Aula_Composicao_Enumeracao.Entities.Enums;

namespace Aula_Composicao_Enumeracao
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();

            Console.Write("How many items to this order?");
            int nOders = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nOders; i++)
            {

                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddOrder(orderItem);
            }


            Console.WriteLine();

            Console.WriteLine("Order Summary");
            Console.WriteLine(order);
        }
    }
}
