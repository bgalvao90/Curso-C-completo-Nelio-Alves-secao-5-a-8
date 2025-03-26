using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula105.Entities.Enums;

namespace Aula105.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order()
        {
            items = new List<OrderItem>();
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
            items = new List<OrderItem>();
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.subTotal();
            }
            return sum;
        }
    }
}
