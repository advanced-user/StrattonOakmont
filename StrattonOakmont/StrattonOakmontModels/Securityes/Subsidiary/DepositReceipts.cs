using StrattonOakmontModels.Securityes.Relation;
using StrattonOakmontModels.Securityes.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class DepositReceipts 
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string FinalTime { get; set; }
        public Stonk Stonk { get; set; }
        public Abligation Abligation { get; set; }  
        public SecSubCon SecSubCon { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public int LifeCycle { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
    }
}
