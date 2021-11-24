using StrattonOakmontModels.Securityes.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class Bill : SecuritySub
    {
        public int id { get; set; }
        public string IMG { get; set; }
        public DateTime FinalTime { get; set; }
        public string PerSent { get; set; }
        public string Getter { get; set; }
        public string Setter { get; set; }
    }
}
