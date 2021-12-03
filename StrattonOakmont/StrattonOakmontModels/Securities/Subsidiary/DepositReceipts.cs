using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securityes.Type;
using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes
{
    public class DepositReceipts
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string FinalTime { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public int LifeCycle { get; set; }
        public Stoсk Stoсk { get; set; }
        public Bond Bond { get; set; }
        public SecuritySub SecuritySub { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<PriceСhange> PriceСhanges { get; set; }
    }
}
