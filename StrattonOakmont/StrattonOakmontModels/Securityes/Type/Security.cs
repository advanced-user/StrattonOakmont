using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Security
    {
        public int Id { get; set; }
        public List<Abligation> Abligations { get; set; }
        public List<Stonk> Stonks { get; set; }
    }
}
