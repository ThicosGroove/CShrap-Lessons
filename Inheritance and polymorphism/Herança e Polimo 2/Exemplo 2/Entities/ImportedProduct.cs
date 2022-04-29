using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_2.Entities
{
    class ImportedProduct : Product
    {
        public float CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, float price, float customsFee)
            : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public float TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString()
                + " (Customs fee: $ "
                + CustomsFee.ToString()
                + ")";
        }


    }
}
