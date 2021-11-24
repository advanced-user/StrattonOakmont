using StrattonOakmontModels.Securityes;
using StrattonOakmontModels.Securityes.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Security> Securities { get; set; }
        public List<SecurityInd> SecuritiesInd { get; set; }
        public List<SecuritySub> SecuritiesSub { get; set; }
    }
}
