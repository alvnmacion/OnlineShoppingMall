using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class Shop
    {
        private IEnumerable<Product> products;

        public string ShopName { get; set; }
        public int ShopRating { get; set; }
        public List<Product> Products { get; set; }

        public Shop(string name, string shopName, int shopRating)
        {
            this.ShopName = shopName;
            this.ShopRating = shopRating;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public void ViewShop(List<Product> products)
        {
            Console.WriteLine("Shop Products:");
            foreach(Product product in products)
            {
                Console.WriteLine($"- {product.Name} -(${product.Description}) -(${product.Price}) -(${product.ProductRating}");
            }
        }

        public void GetProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.GetProduct());
                Console.WriteLine();
            }
        }
    }
}
