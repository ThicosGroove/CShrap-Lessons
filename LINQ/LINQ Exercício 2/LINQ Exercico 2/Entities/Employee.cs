using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Exercico_2.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }

        public Employee(string name, string email, float salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
