using Microsoft.AspNetCore.Identity;
using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securities.Main;
using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public string Img { get; set; } 
        public List<UserStock> Stocks { get; set; }
        public List<UserBond> Bond { get; set; }    
        public IEnumerable<Receipt> Receipts { get; set; }
    }
}
