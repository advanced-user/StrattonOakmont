using StrattonOakmontModels.Securityes.Type;
using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes
{
    public class Bill 
    {
        public int Id { get; set; }
        public string IMG { get; set; }
        public string FinalTime { get; set; }
        public string PerSent { get; set; }
        public string Getter { get; set; }
        public string Setter { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public int LifeCycle { get; set; }
        public SecuritySub SecuritySub { get; set; }
        public Category CategorySec { get; set; }
        public User UserSec { get; set; }
        public List<Date> DateTimesChanges { get; set; }
    }
}
