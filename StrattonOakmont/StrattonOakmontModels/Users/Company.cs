using StrattonOakmontModels.Securities;
using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public long Сapitalization { get; set; }
        public string IMG { get; set; }
        public Security Security { get; set; } 
        public IEnumerable<Receipt> Receipts { get; set; }
    }
}
