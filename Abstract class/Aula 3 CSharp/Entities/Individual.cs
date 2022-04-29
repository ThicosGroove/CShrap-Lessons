using System;
using System.Collections.Generic;
using System.Text;
using Aula_3_CSharp.Abstract;

namespace Aula_3_CSharp.Entities
{
    class Individual : TaxPayer
    {
        public float HealthExpenditures { get; set; }

        public Individual(float healthExpenditures, string name, float anualIncome): 
            base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override float Tax()
        {
            float tax = 0;
            float taxPercentage = 0;

            if (AnualIncome <= 20000)
            {
                taxPercentage = 0.15f;

                Console.WriteLine("Pessoa que recebe menos de 20K por ano Paga 15% de juros");
                tax = AnualIncome * taxPercentage;
            }
            else
            {
                taxPercentage = 0.25f;

                Console.WriteLine("Pessoa que recebe mais de 20k por ano Paga 25% de imposto");
                tax = AnualIncome * taxPercentage;
            }

            if (HealthExpenditures > 0)
            {
                tax = (AnualIncome * taxPercentage) - (HealthExpenditures * 0.5f);
            }

            return tax;
        }
    }
}
