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
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ProductRating { get; set; }

        public Product(string name,decimal price, string description, string category, string rating)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.ProductRating = rating;
        }

        internal bool GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
