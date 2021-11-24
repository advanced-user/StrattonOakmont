using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    public class Abligation : Security
    {
        public int id { get; set; }
        public int Percent { get; set; }
        public DateTime FinalTime { get; set; }
    }
}
