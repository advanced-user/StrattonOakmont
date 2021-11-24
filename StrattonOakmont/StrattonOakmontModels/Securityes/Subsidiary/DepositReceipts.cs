using StrattonOakmontModels.Securityes.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class DepositReceipts : SecuritySub
    {
        public string IMG { get; set; }
        public string FinalTime { get; set; }
        public Stonk Stonk { get; set; }
        public Abligation Abligation { get; set; }  
    }
}
