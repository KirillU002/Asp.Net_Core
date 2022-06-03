using OnlineShopWebApplication.Models;

namespace OnlineShopWebApplication
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Name1", 10,"Desc1"),
            new Product("Name2", 30,"Desc2"),
            new Product("Name3", 40,"Desc3"),
            new Product("Name4", 50,"Desc4"),
            new Product("Name5", 250,"Desc5"),
            new Product("Name6", 2650,"Desc6"),
            new Product("Name7", 500,"Desc7")
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);            
        }
    }
}
