using OnlineShopWebApplication.Models;

namespace OnlineShopWebApplication
{
    public class ProductsInMemoryRepository : IProductsRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Монитор AOC 32 CQ32G1", 40290,"31.5, VA, LED, 2560x1440 (Quad HD), 1 мс, 144 Гц, AMD FreeSync, 3000:1. 178°/178°. 2xHDMI, 2xDisplayPort, Цвет: чёрный", "/images/image1.jpg"),
            new Product("Монитор AOC CU34G2/BK", 37855,"34, 3440x1440, 100 Гц, *VA, черный, Поддержка FreeSync/G-Sync", "/images/image2.jpg"),
            new Product("Монитор AOC AGON AG352UCG6", 98890,"34, 3440x1440, 100 Гц, *VA, черный, Поддержка FreeSync/G-Sync", "/images/image3.png"),
            new Product("Монитор Acer Predator Z35P", 82126,"35, 3440x1440, 100 Гц, *VA, черный", "/images/Image4.jpg"),
            new Product("Монитор Acer 49 EI491CRPbmiiipx Nitro", 89680,"49, VA, UltraWide, 3840x1080, изогнутый, 4 мс, 144 Гц, AMD FreeSync 2, 400 кд/м2, 178°/178°, 2xHDMI, DisplayPort, динамики, чёрный", "/images/image5.jpg"),
            new Product("Монитор Acer Predator Z35P", 89220,"Описание: Монитор Acer Predator Z35P 35 VA Чёрный, Изогнутый монитор Acer Predator Z35P с диагональю экрана 35, разрешением 2560x1080 (UltraWide FHD) и типом матрицы VA. Модель оснащена встроенными динамиками. Подставка поддерживает возможность поворота экрана в портретный режим (Pivot). Время отклика составляет 4мс, яркость 300кд/м², динамическая контрастность 100000000:1. Монитор содержит видеопорты: 1xHDMI и 1xDisplayPort.", "/images/image6.jpg"),
            new Product("Монитор MSI MPG341CQR", 34685,"Тип: игровой ЖК-монитор, широкоформатный. Диагональ: 34. Разрешение: 3440x1440@144 Гц (21:9) Тип матрицы экрана: *VA. Подсветка: WLED", "/images/image7.jpg")
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
