using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes.Relation
{
    public class SecIndCon
    {
        public int Id { get; set; }
        public List<Forward> Forwards { get; set; }
        public List<Futures> Futures { get; set; }
        public List<Option> Options { get; set; }
        public List<Wright> Wrights { get; set; }
    }
}
