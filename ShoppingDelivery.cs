using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public class ShoppingDelivery : ShoppingPayment
    {
        private string address;
        private decimal cost;

        public ShoppingDelivery(string address, decimal cost)
        {
            this.address = address;
            this.cost = cost;
        }

        public string Address
        {
            get{return address;}
        }

        public decimal Cost
        {
            get{return cost;}
        }

        public override bool ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}
