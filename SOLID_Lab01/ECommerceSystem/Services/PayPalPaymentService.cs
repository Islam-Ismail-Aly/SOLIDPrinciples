using SOLID_Lab01.ECommerceSystem.Interfaces;

namespace SOLID_Lab01.ECommerceSystem.Services
{
    public class PayPalPaymentService : IPaymentService
    {
        public void Payment(decimal amount)
        {
            // Process PayPal payment
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
