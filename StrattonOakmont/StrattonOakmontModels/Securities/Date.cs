using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securityes;
using StrattonOakmontModels.Securityes.Type;
using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Date
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; } 
        public int Year { get; set; }
        public int PriceChangeId { get; set; }
        public PriceСhange PriceChange { get; set; }
        public List<Security> Securities { get; set; }
        public List<SecurityInd> SecurityInd { get; set; }
        public List<SecuritySub> SecuritySubs { get; set; }
    }
}
