using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class SecurityInd
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }     
        public Category CategorySec { get; set; }      
        public User UserSec { get; set; }
        
        public List<DateTime> DateTimesChanges { get; set; }
    }
}
