using System;
using System.Collections.Generic;
using System.Text;
using ProductOrder.Entities;
using ProductOrder.Entities.Enums;

namespace ProductOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status = new OrderStatus();
        public List<OrderItem> Items = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Add(item);
        }

        public double Total()
        {
            double total = 0;

            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }
    }
}
