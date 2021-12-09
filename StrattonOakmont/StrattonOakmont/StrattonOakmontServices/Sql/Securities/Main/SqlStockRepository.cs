using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql.Securities.Main
{
    public class SqlStockRepository : IStockRepository
    {
        private readonly AppDBContext _context;
        private readonly IPriceChangeRepository _priceChangeRepository;


        public SqlStockRepository(AppDBContext context, IPriceChangeRepository priceChangeRepository)
        {
            _context = context;
            _priceChangeRepository = priceChangeRepository; 
        }

        public List<Stoсk> GetAllStock {
            get
            {
                return _context.Stocks.ToList();
            }
        }

        public async Task<Stoсk> AddStockAsync(Stoсk stock)
        {
            await _context.Stocks.AddAsync(stock);
            await _context.SaveChangesAsync();

            return stock;
        }

        public async Task<Security> DeleteSecurityStocksAsync(Security security)
        {
            if (security != null && security.Stocks != null)
            {
                await _priceChangeRepository.DeleteStockPriceChages(security.Stocks.Id);
                _context.Stocks.Remove(security.Stocks);
            }

            await _context.SaveChangesAsync();

            return security;
        }

        public async Task<Stoсk> DeleteStockAsync(int id)
        {
            var stock = await _context.Stocks.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == id);

            if (stock != null)
            {
                await _priceChangeRepository.DeleteStockPriceChages(stock.Id);
                _context.Stocks.Remove(stock);

                await _context.SaveChangesAsync();
            }

            return stock;
        }

        public async Task<Stoсk> GetStockAsync(int stockId)
        {
            return await _context.Stocks.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == stockId);
        }

        public Stoсk GetStoсk(int stockId)
        {
            return _context.Stocks.Include(x => x.PriceСhanges).FirstOrDefault(x => x.Id == stockId);
        }

        public List<PriceСhange> GetСheapStocks()
        {
            var stocks = GetAllStock;

            var priceChanges = new List<PriceСhange>();

            foreach (var stock in stocks)
            {
                var price = _priceChangeRepository.GetLatestStockPriceChage(stock.Id);
                priceChanges.Add(price);
            }

            return priceChanges.OrderBy(x => x.Price).Take(5).ToList();
        }

        public List<PriceСhange> GetExpensiveStocks()
        {
            var stocks = GetAllStock;

            var priceChanges = new List<PriceСhange>();

            foreach (var stock in stocks)
            {
                var price = _priceChangeRepository.GetLatestStockPriceChage(stock.Id);
                priceChanges.Add(price);
            }

            return priceChanges.OrderByDescending(x => x.Price).Take(5).ToList();
        }
    }
}
