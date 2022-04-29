using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3_CSharp.Abstract
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public float AnualIncome { get; set; }

        public TaxPayer(string name, float anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract float Tax();
    }
}
