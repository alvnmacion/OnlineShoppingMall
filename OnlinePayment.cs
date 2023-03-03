using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class OnlinePayment : ShoppingPayment
    {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV{ get; set; }

        public override bool ProcessPayment()
        {
            // Process the payment online
            Console.WriteLine($"Online payment processed for ${Amount} using card {CardNumber}");
            return true;
        }
    }
}
