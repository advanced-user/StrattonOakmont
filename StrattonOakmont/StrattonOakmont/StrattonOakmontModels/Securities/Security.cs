using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Security
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }  
        public Company Company { get; set; }
        public Bond Bonds { get; set; }
        public Stoсk Stocks { get; set; }
    }
}
