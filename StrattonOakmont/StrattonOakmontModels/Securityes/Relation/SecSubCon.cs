using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes.Relation
{
    public class SecSubCon
    {
        public int Id { get; set; }
        public List<Bill> Bills { get; set; }
        public List<DepositReceipts> DepositReceipts { get; set; }
    }
}
