﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels.Securityes
{
    public class Wright : SecurityInd
    {
        public string IMG { get; set; }
        public string NameIndastry { get; set; }
        public Indastrial IndastrialSec { get; set; }
        public int FinalPrice { get; set; }
        public string FinalTime { get; set; }
        public Security Active { get; set; }

    }
}
