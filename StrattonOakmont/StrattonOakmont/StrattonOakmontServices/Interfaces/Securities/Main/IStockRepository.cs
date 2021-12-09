using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IStockRepository
    {
        public Stoсk GetStoсk(int stockId);
        public List<Stoсk> GetAllStock { get; }
        public List<PriceСhange> GetExpensiveStocks(); 
        public List<PriceСhange> GetСheapStocks(); 
        public Task<Stoсk> GetStockAsync(int stockId);
        public Task<Stoсk> AddStockAsync(Stoсk stock);
        public Task<Stoсk> DeleteStockAsync(int id);
        public Task<Security> DeleteSecurityStocksAsync(Security security);
    }
}
