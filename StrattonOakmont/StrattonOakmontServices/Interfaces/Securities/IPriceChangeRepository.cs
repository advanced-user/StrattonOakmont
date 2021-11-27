using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces.Securities
{
    public interface IPriceChangeRepository
    {
        public Task<PriceСhange> DeletePriceСhangeAsync(int priceChangeId);
        public Task<PriceСhange> UpdatePriceChange(PriceСhange priceChange);
        public Task<Stoсk> DeleteStockPriceChages(int stockId);
        public Task<Bond> DeleteBondPriceChages(int bondId);
        public PriceСhange GetPriceСhange(int priceChangeId);
        public PriceСhange GetLatestStockPriceChage(int stockId);
        public PriceСhange GetLatestBondPriceChage(int bondId);
    }
}

