using System;
using System.Collections.Generic;

namespace Testability2
{
    public class Orders
    {
        public bool IsShipped { get; set; }
        public float Price { get; set; }
        public DateTime DateOrdered { get; set; }
        public Shippment Shippment { get; set; }

        
    }
}