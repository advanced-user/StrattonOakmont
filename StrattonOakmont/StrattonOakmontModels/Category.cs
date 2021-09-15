using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Security> Securities { get; set; }


    }
}
