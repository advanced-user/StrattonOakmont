using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SecurityId { get; set; }
        public int Price { get; set; }

        public virtual Security Security { get; set; }
        public virtual Order Order { get; set; }
    }
}
