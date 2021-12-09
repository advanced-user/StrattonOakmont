using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces.Securities;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql.Securities
{
    public class SqlPriceChangeRepository : IPriceChangeRepository
    {
        private readonly AppDBContext _context;

        public SqlPriceChangeRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<Bond> DeleteBondPriceChages(int bondId)
        {
            var bond = await _context.Bonds.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == bondId);

            if (bond != null)
            {
                foreach (var priceChange in bond.PriceСhanges)
                {
                    _context.PriceСhanges.Remove(priceChange);
                }
            }

            await _context.SaveChangesAsync();

            return bond;
        }

        public async Task<StrattonOakmontModels.Securities.PriceСhange> DeletePriceСhangeAsync(int priceChangeId)
        {
            var priceChange = await _context.PriceСhanges.FindAsync(priceChangeId);
            _context.PriceСhanges.Remove(priceChange);
            await _context.SaveChangesAsync();

            return priceChange;
        }

        public async Task<Stoсk> DeleteStockPriceChages(int stockId)
        {
            var stock = await _context.Stocks.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == stockId);

            if (stock != null)
            {
                foreach (var priceChange in stock.PriceСhanges)
                {
                    _context.PriceСhanges.Remove(priceChange);
                }
            }

            await _context.SaveChangesAsync();

            return stock;
        }

        public StrattonOakmontModels.Securities.PriceСhange GetLatestBondPriceChage(int bondId)
        {
            var latestId = _context.PriceСhanges.Where(x => x.Bond.Id == bondId).Max(p => p.Id);

            return _context.PriceСhanges.Include(x => x.Bond).ThenInclude(x => x.CompanySec).FirstOrDefault(x => x.Id == latestId);
        }

        public StrattonOakmontModels.Securities.PriceСhange GetLatestStockPriceChage(int stockId)
        {
            var latestId = _context.PriceСhanges.Where(x => x.Stoсk.Id == stockId).Max(p => p.Id);

            return _context.PriceСhanges.Include(x => x.Stoсk.CompanySec).ThenInclude(x => x.Security).ThenInclude(x => x.Stocks)
                                        .Include(x => x.Bond.CompanySec).ThenInclude(x => x.Security).ThenInclude(x => x.Bonds)
                                        .FirstOrDefault(x => x.Id == latestId);
        }

        public StrattonOakmontModels.Securities.PriceСhange GetPriceСhange(int priceChangeId)
        {
            return _context.PriceСhanges.Find(priceChangeId);
        }

        public async Task<StrattonOakmontModels.Securities.PriceСhange> UpdatePriceChange(StrattonOakmontModels.Securities.PriceСhange priceChange)
        {
            var newPriceChange = await _context.PriceСhanges.FindAsync(priceChange.Id);
            newPriceChange.Volume = priceChange.Volume;
            newPriceChange.Price = priceChange.Price;
            newPriceChange.Amount = priceChange.Amount;

            await _context.SaveChangesAsync();

            return newPriceChange;
        }
    }
}
