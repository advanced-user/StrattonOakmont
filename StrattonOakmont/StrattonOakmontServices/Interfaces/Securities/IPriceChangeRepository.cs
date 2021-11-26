using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces.Securities
{
    public interface IPriceChangeRepository
    {
        public Task<Stoсk> DeleteStockPriceChages(int stockId);
        public Task<Bond> DeleteBondPriceChages(int bondId);
    }
}

