using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces.Securities
{
    public interface IPriceChangeRepository
    {
        public Task<Stoсk> DeleteStockPriceChages(int stockId);
        public Task<Bond> DeleteBondPriceChages(int bondId);
        public Task<PriceСhange> GetLatestStockPriceChageAsync(int stockId);
        public Task<PriceСhange> GetLatestBondPriceChageAsync(int bondId);

    }
}

