using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string Rating { get; set; }

        public Product(string name,int price, string description, string category, int productId, string prodDescription, string prodCategory, string rating)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.ProductId = productId;
            this.ProductDescription = prodDescription;
            this.ProductCategory = prodCategory;
            this.Rating = rating;
        }

    }
}
