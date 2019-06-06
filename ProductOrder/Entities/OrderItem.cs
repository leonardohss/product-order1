﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrder.Entities
{
    class OrderItem
    {
        public Product Product = new Product();
        public int Quantity { get; set; }
        public double Price { get; set; }
        
        public OrderItem() { }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
