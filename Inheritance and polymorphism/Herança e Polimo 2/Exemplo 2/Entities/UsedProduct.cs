using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, float price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price
                + "(Manufactured date: "
                + ManufactureDate
                + ")";
        }

    }
}
