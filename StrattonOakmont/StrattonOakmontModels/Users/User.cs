using Microsoft.AspNetCore.Identity;
using StrattonOakmontModels.Securityes.Type;

namespace StrattonOakmontModels
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public string Img { get; set; } 
        public SecuritySub SecuritySub { get; set; }   
    }
}
