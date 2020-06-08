using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability2;
using System;

namespace Testability2.Tests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        [ExpectedException (typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new Testability2.OrderProcessor(new FakeShippingCalculator());

            var order = new Orders 
            {
                Shippment = new Shippment()
            };

            orderProcessor.Process(order);
        }

            [TestMethod]
            public void Process_OrderIsNotShipped_ShouldSetShipmentProperty()
            {
                var orderProcessor = new Testability2.OrderProcessor(new FakeShippingCalculator());
                var order = new Orders
                {
                    IsShipped = true
                };

                orderProcessor.Process(order);

                Assert.IsTrue(order.IsShipped);
                Assert.AreEqual(1, order.Shippment.Cost);
                Assert.AreEqual(DateTime.Today.AddDays(1), order.Shippment.ShippingDate);
            }
    }

    

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Testability2.Orders order)
        {
            ///throw new NotImplementedException();
            return 1;
        }
    }
}
