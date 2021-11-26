using System;

namespace StrattonOakmontModels.Securities
{
    public class PriceСhange
    {
        public int Id { get; set; } 
        public double Price { get; set; }
        public Bond Bond { get; set; } 
        public Stoсk Stoсk { get; set; }
        public DateTime Date { get; set; }
    }
}
