using eshopping.client.Models;

namespace eshopping.client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product
            {
                Name = "Laptop",
                Category = "Laptop",
                Description = "A high-performance laptop suitable for all your computing needs.",
                ImageFile = "laptop.jpg",
                Price = 999.99m
            },
            new Product
            {
                Name = "Smartphone",
                Category = "Smart Phone",
                Description = "A latest-generation smartphone with cutting-edge features.",
                ImageFile = "smartphone.jpg",
                Price = 699.99m
            },
            new Product
            {
                Name = "Headphones",
                Category = "Accessories",
                Description = "Noise-cancelling headphones for an immersive audio experience.",
                ImageFile = "headphones.jpg",
                Price = 199.99m

            },
            new Product
            {
                Name = "Coffee Maker",
                Category = "Home Appliances",
                Description = "Brew the perfect cup of coffee with this easy-to-use coffee maker.",
                ImageFile = "coffeemaker.jpg",
                Price = 49.99m
            }
        };
    }
}
