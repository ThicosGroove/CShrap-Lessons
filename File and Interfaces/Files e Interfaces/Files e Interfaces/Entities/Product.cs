namespace Files_e_Interfaces.Entities
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product() { }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}
