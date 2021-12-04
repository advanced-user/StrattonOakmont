using StrattonOakmontModels.Securities;
using System.Collections.Generic;

namespace StrattonOakmontModels 
{
    public class Stoсk 
    {
        public int Id { get; set; }
        public bool Divisibility { get; set; }
        public int SecurityId { get; set; }
        public Security Security { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }
        public User UserSec { get; set; }
        public List<PriceСhange> PriceСhanges { get; set; }
    }
}
