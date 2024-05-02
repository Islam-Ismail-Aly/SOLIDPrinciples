using SOLID_Lab01.ECommerceSystem.Entities;

namespace SOLID_Lab01.ECommerceSystem.Interfaces
{
    public interface IEmailNotificationService
    {
        public void SendOrderConfirmationEmail(Order order);
    }
}
