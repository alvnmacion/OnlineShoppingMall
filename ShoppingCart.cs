using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public string ShoppingCartId { get; set; }
        public int ProductSize { get; set; }

        public ShoppingCart(string shoppingCartId, int productSize)
        {
            this.Products = new List<Product>();
            this.ShoppingCartId = shoppingCartId;
            this.ProductSize = productSize;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"{product.Name} added to cart.");
        }

        public void RemoveProduct(Product product)
        {
            if (Products.Contains(product))
            {
                Products.Remove(product);
                Console.WriteLine($"{product.Name} removed from cart.");
            }
            else
            {
                Console.WriteLine($"{product.Name} is not in cart.");
            }
        }
        public void ShowCart()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Your cart contains:");
                foreach (Product product in Products)
                {
                    Console.WriteLine($"- {product.Name} (${product.Price})");
                }
            }
        }
        public decimal Checkout()
        {
            decimal total = 0;
            foreach (Product product in Products)
            {
                total += product.Price;
            }
            Console.WriteLine($"Your total is: ${total}");
            Products.Clear();
            return total;
        }
    }
}
