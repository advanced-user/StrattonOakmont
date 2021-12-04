using Microsoft.AspNetCore.Identity;
using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securityes.Type;
using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public string Img { get; set; } 
        public SecuritySub SecuritySub { get; set; }
        public IEnumerable<Receipt> Receipts { get; set; }
    }
}
