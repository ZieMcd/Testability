using System;

namespace Testability2
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Orders order)
        {
            if(!order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");
                
            order.Shippment = new Shippment 
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}