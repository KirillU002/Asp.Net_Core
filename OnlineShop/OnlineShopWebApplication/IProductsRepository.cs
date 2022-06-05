using OnlineShopWebApplication.Models;

namespace OnlineShopWebApplication
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product TryGetById(int id);
    }
}