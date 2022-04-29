using System;
using System.Collections.Generic;
using Herança_e_Polimo.Entitites;

namespace Herança_e_Polimo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string answer = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                float valuePerHour = float.Parse(Console.ReadLine());



                if (answer == "y")
                {
                    Console.Write("Additional Charge: ");
                    int additionalCharge = int.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS");
            }

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString());
            }
        }
    }
}
