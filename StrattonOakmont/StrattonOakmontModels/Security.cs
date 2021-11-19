namespace StrattonOakmontModels
{
    public class Security
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Percent { get; set; }
        public int Volume { get; set; }
        public int Amount { get; set; }
        public Category CategorySec { get; set; }
        public Company CompanySec { get; set; }
        public User UserSec { get; set; }
    }
}
