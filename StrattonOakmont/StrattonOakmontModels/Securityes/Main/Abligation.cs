using StrattonOakmontModels.Securityes.Relation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    public class Abligation
    {
        public int Id { get; set; }
        public int Percent { get; set; }
        public string FinalTime { get; set; }
        public SecMainCon SecMainCon { get; set; }
        public double Price { get; set; }
        public int Volume { get; set; }
        public int Amount { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
    }
}
