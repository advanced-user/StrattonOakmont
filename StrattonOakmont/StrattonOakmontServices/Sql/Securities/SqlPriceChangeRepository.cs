using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces.Securities;
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
                foreach (var item in bond.PriceСhanges)
                {
                    var priceChange = await _context.PriceСhanges.Include(x => x.Date).FirstOrDefaultAsync(x => x.Id == item.Id);

                    _context.PriceСhanges.Remove(priceChange);
                }
            }

            await _context.SaveChangesAsync();

            return bond;
        }

        public async Task<Stoсk> DeleteStockPriceChages(int stockId)
        {
            var stock = await _context.Stocks.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == stockId);

            if (stock != null)
            {
                foreach (var item in stock.PriceСhanges)
                {
                    var priceChange = await _context.PriceСhanges.Include(x => x.Date).FirstOrDefaultAsync(x => x.Id == item.Id);

                    _context.PriceСhanges.Remove(priceChange);
                }
            }

            await _context.SaveChangesAsync();

            return stock;
        }
    }
}
