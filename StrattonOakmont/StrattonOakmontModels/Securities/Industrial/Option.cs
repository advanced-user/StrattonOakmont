using StrattonOakmontModels.Securities;
using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes
{
    public class Option 
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string NameIndastry { get; set; }
        public int FinalPrice { get; set; }
        public string FinalTime { get; set; }
        public string Active { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public SecurityInd SecurityInd { get; set; }
        public Indastrial IndastrialSec { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<PriceСhange> PriceСhanges { get; set; }
    }
}
