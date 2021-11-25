using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes.Type
{
    public class SecuritySub
    {
        public int Id { get; set; }
        public List<Bill> Bills { get; set; }
        public List<DepositReceipts> DepositReceipts { get; set; }
    }
}
