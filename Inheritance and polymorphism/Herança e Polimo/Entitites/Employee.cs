using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_e_Polimo.Entitites
{
    class Employee
    {
        public string Name;
        public int Hours;
        public float ValuePerHour;

        public Employee() { }

        public Employee(string name, int hours, float valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual float Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
