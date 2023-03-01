﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMall
{
    public abstract class ShoppingPayment
    {
        public decimal Amount { get; set; }
        public abstract bool ProcessPayment();
    }
}
