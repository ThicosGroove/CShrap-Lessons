using System;
using System.Globalization;

namespace Interface_escercise.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public float Amount { get; set; }

        public Installment(DateTime dueDate, float amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}