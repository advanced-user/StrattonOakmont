using System.Collections.Generic;

namespace StrattonOakmontModels.Securityes
{
    public class SecurityInd
    {
        public int Id { get; set; }
        public List<Forward> Forwards { get; set; }
        public List<Futures> Futures { get; set; }
        public List<Option> Options { get; set; }
        public List<Wright> Wrights { get; set; }
    }
}
