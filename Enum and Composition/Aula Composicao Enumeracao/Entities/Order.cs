using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_Composicao_Enumeracao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrder(OrderItem item)
        {
            orderItems.Add(item);
        }

        public void RemoveOrder(OrderItem item)
        {
            orderItems.Remove(item);
        }

        public float Total()
        {
            float sum = 0;

            foreach (OrderItem item in orderItems)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Summary:");
            sb.Append("Order moment");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order moment" + Status);
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client);


            foreach (OrderItem item in orderItems)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total Price: $ " + Total().ToString());

            return ToString();
        }

    }
}
