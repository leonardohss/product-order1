﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProductOrder.Entities
{
    class OrderItem
    {
        public Product product = new Product();
        public int Quantity { get; set; }
        public double Price { get; set; }
        
        public OrderItem() { }

        public OrderItem(string name, int quantity, double price)
        {
            product.Name = name;
            Quantity = quantity;
            Price = price;
            product.Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString(){
            return $"{product.Name}, ${Price}, Quantity: {Quantity}," 
            + $" ---Subtotal: ${SubTotal().ToString("F2")}---";
        }
    }
}
