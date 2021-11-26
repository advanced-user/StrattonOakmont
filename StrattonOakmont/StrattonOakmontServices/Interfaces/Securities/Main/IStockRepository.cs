using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IStockRepository
    {
        public Task<Stoсk> AddStockAsync(Stoсk stock);
        public Task<Stoсk> DeleteStockAsync(int id);
        public Task<Security> DeleteSecurityStocksAsync(Security security);
    }
}
