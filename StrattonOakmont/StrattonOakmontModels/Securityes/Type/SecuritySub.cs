using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes.Type
{
    public class SecuritySub
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public int LifeCycle { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
    }
}
