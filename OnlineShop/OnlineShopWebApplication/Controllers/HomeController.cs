using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApplication.Models;
using System.Diagnostics;

namespace OnlineShopWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productRepository;

        public HomeController(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}