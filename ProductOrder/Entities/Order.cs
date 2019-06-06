using System;
using System.Collections.Generic;
using System.Text;
using ProductOrder.Entities.Enums;

namespace ProductOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status = new OrderStatus();

    }
}
