using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Security
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }  
        public Company Company { get; set; }
        public List<Bond> Bonds { get; set; }
        public List<Stoсk> Stocks { get; set; }
    }
}
