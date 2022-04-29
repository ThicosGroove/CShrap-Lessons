using System;
using Aula_3_CSharp.Entities;
using Aula_3_CSharp.Abstract;
using System.Collections.Generic;

namespace Aula_3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int nTaxPayers = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= nTaxPayers; i++)
            {
                Console.Write("Individual or Company (i / c)? ");
                char taxPayerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Anual Income: ");
                float anualIncome = float.Parse(Console.ReadLine());

                if (taxPayerType == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    float health = float.Parse(Console.ReadLine());

                    list.Add(new Individual(health, name, anualIncome));
                }
                else if (taxPayerType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(nEmployees, name, anualIncome));
                }
                else
                {
                    Console.WriteLine("Error"); 
                }

            }
                Console.WriteLine();

                Console.WriteLine("Taxes Paid");

                float totalTax = 0;

                foreach(TaxPayer payer in list)
                {

                    Console.WriteLine(payer.Name + " $ " + payer.Tax());


                    totalTax += payer.Tax();
                }

                Console.WriteLine();

                Console.WriteLine("Total Taxes: $ " + totalTax);

        }
    }
}
