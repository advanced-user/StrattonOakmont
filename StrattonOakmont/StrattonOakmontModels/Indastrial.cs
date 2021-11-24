using StrattonOakmontModels.Securityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    public class Indastrial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }      
        public string IMG { get; set; }
        public List<Forward> Forwards { get; set; }
        public List<Futures> Futures { get; set; }
        public List<Option> Options { get; set; }
        public List<Wright> Wrights { get; set; }
    }
}
