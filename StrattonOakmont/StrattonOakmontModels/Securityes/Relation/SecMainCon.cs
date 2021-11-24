using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes.Relation
{
    public class SecMainCon
    {
        public int Id { get; set; }
        public List<Abligation> Abligations { get; set; }
        public List<Stonk> Stonks { get; set; }
    }
}
