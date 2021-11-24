using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes
{
    public class Forward 
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string NameIndastry { get; set; }
        public int FinalPrice { get; set; }
        public string FinalTime { get; set; }
        public string Active { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
        public Indastrial IndastrialSec { get; set; }
        public SecurityInd SecurityInd { get; set; }
    }
}
