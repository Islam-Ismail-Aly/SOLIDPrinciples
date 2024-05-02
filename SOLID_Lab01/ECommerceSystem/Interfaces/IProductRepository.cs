using SOLID_Lab01.ECommerceSystem.Entities;

namespace SOLID_Lab01.ECommerceSystem.Interfaces
{
    public interface IProductRepository
    {
        public void AddProduct(string name, decimal price, int quantity);
        public Product GetProductById(int id);
    }
}
