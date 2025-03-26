using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula105.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product products { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product products)
        {
            Quantity = quantity;
            Price = price;
            this.products = products;
           
        }

        public double subTotal()
        {
            return  Quantity * Price;
        }

        

    }
}
