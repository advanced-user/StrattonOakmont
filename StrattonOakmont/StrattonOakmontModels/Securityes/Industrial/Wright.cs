using StrattonOakmontModels.Securityes.Relation;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class Wright 
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string NameIndastry { get; set; }
        public Indastrial IndastrialSec { get; set; }
        public int FinalPrice { get; set; }
        public string FinalTime { get; set; }
        public Security Active { get; set; }
        public SecIndCon SecIndCon { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }

    }
}
