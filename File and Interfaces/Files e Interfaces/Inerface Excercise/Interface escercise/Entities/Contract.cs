using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_escercise.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public float TotalValue { get; set; }

        List<Installment> installments { get; set; }


        public Contract(int number, DateTime date, float totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installments = new List<Installment>();
        }

        public void AddInstallments(Installment installment)
        {
            installments.Add(installment);
        }

    }
}
