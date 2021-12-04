using System.Collections.Generic;

namespace StrattonOakmontModels
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Bond> Bonds { get; set; }
        public List<Stoсk> Stocks { get; set; }
    }
}
