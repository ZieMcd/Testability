using System;

namespace Testability2
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());

            var order = new Orders {DateOrdered = DateTime.Now, Price = 100f};
            orderProcessor.Process(order);
        }
    }
}
