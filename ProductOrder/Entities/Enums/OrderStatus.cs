using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrder.Entities.Enums
{
    enum OrderStatus : int
    {
        pending_payment = 0,
        processing = 1,
        shipped = 2,
        deliveres = 3
    }
}
