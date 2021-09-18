using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Сapitalization { get; set; }
        public string IMG { get; set; }
        public List<Security> Securities { get; set; }
    }
}
