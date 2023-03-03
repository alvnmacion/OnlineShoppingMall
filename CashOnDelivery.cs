using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class CashOnDelivery : ShoppingPayment
    {
        public string DeliveryAddress { get; set; }
        public override bool ProcessPayment()
        {
            // Pay cash on delivery
            Console.WriteLine($"Cash on delivery payment processed for ${Amount} to address {DeliveryAddress}");
            return true;
        }
    }
}
