using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class Shopping
    {
        public List<Product> Products { get; set; }
        
        public Shopping(List<Product> products)
        { 
            this.Products = products; 
        }

        public void ShowProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (Product product in Products)
            {
                Console.WriteLine($"- {product.Name} (${product.Price})");
            }
        }

        public Product? SelectProduct(string productName)
        {
            foreach(Product product in Products)
            {
                if(product.Name == productName)
                {
                    return product;
                }
            }

            Console.WriteLine($"Sorry, {productName} is not available.");
            return null;
        }
    }
}
