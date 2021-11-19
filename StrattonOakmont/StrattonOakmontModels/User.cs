using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace StrattonOakmontModels
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public string Img { get; set; } 
        public List<Security> Securities { get; set; }
    }
}
