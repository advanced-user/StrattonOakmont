using System.Collections.Generic;

namespace StrattonOakmontModels 
{
    public class Stonk 
    {
        public int Id { get; set; }
        public bool Divisibility { get; set; }
        public double Price { get; set; }
        public int Volume { get; set; }
        public int Amount { get; set; }
        public Security Security { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
    }
}
