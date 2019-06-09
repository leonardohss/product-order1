using System;
using System.Collections.Generic;
using System.Text;
using ProductOrder.Entities;
using ProductOrder.Entities.Enums;
using System.Globalization;

namespace ProductOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus status = new OrderStatus();
        public List<OrderItem> Items = new List<OrderItem>();
        public Client client = new Client();

        public Order() { }

        public Order(string name, string email, DateTime birthDate, DateTime moment, OrderStatus status)
        {
            client.Name = name;
            client.Email = email;
            client.BirthDate = birthDate;
            Moment = moment;
            this.status = status;
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

        public override string ToString(){
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---ORDER SUMMARY---");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items){
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
