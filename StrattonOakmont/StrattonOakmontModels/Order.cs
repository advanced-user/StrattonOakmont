using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class Order
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string SuName { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }


    }
}
