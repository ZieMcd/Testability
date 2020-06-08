namespace Testability2
{

    public interface IShippingCalculator
    {
        float CalculateShipping(Orders order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Orders order) 
        {
            if (order.Price < 300f)
                return order.Price * 0.1f;

            return 0;
        }
    }
}