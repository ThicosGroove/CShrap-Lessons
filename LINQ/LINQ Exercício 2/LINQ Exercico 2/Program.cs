using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using LINQ_Exercico_2.Entities;

namespace LINQ_Exercico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter Full file Path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    float salary = float.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }
            Console.WriteLine("Enter salary: ");
            float enterSalary = float.Parse(Console.ReadLine());

            Console.WriteLine("Email of people whose salary is more than " + enterSalary);

            var rich = list.Where(p => p.Salary > enterSalary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (var newEmail in rich)
            {
                Console.WriteLine(newEmail);
            }

            Console.WriteLine();

            float sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}
