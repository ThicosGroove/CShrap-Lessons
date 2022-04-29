using System;
using System.Collections.Generic;
using System.Text;
using Aula_3_CSharp.Abstract;

namespace Aula_3_CSharp.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }


        public Company(int numberOfEmployees, string name, float anualIncome) :
            base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override float Tax()
        {
            float tax = 0;
            float taxPercentage = 0;

            if (NumberOfEmployees >= 10)
            {
                taxPercentage = 0.14f;

                tax = AnualIncome * taxPercentage;
            }
            else
            {
                taxPercentage = 0.16f;
                tax = AnualIncome * taxPercentage;
            }

            return tax;

        }
    }
}
