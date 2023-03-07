using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class ShoppingPayment : ShoppingCart
    {
        public decimal Amount { get; set; }
        public ShoppingPayment()
        {
            this.Amount = 0;
        }
        public bool ProcessPayment();
    }
}
