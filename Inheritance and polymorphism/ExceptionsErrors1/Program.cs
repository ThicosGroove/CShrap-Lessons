using System;
using ExceptionsErrors1.Entities;
using ExceptionsErrors1.Entities.Exceptions;

namespace ExceptionsErrors1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Initial balance: ");
            float balance = float.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            float limit = float.Parse(Console.ReadLine());

            Account account = new Account(id, name, balance, limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            float amount = float.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
