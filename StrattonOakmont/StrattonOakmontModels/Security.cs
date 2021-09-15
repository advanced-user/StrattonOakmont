using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class Security
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int PerSent { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }

    }
}
