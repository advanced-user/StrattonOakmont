using StrattonOakmontModels.Securities;
using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Bond
    {
        public int Id { get; set; }
        public int Percent { get; set; }
        public string FinalTime { get; set; }
        public Security Security { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }
        public User UserSec { get; set; }
        public List<PriceСhange> PriceСhanges { get; set; }
    }
}
