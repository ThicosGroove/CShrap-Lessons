using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Composicao_Enumeracao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(){ }

        public OrderItem(int quantity, float price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public float SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString()
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString();
        }
    }
}
