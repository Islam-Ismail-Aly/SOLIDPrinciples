namespace SOLID_Lab01.ECommerceSystem.Interfaces
{
    public interface IOrderRepository
    {
        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod);
    }
}
