using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Composicao_Enumeracao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product() { }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
