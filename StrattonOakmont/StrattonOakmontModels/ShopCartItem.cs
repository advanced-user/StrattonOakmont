using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class ShopCartItem
    {
        public int Id { get; set; }
        public Security Security { get; set; }
        public decimal Price { get; set; }
        public string ShopCartId { get; set; }
    }
}
