namespace StrattonOakmontModels.Securities.Main
{
    public class UserBond
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public Bond Bond { get; set; }
        public User User { get; set; }

    }
}
