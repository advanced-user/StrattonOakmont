using System;

namespace StrattonOakmontModels.Securities
{
    public class Receipt
    {
        public int Id { get; set; } 
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public Stoсk Stock { get; set; }
        public Bond Bond { get; set; }
        public Company Company { get; set; }    
        public User User { get; set; }
    }
}
