﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<StrattonOakmontModels.Securities.PriceСhange> GetLatestBondPriceChageAsync(int bondId)
        {
            var latestId = await _context.PriceСhanges.Where(x => x.Bond.Id == bondId)
                                                      .MaxAsync(p => p.Id);

            return await _context.PriceСhanges.FindAsync(latestId);
        }

        public async Task<StrattonOakmontModels.Securities.PriceСhange> GetLatestStockPriceChageAsync(int stockId)
        {
            var latestId = await _context.PriceСhanges.Where(x => x.Stoсk.Id == stockId)
                                                      .MaxAsync(p => p.Id);

            return await _context.PriceСhanges.FindAsync(latestId);
        }
    }
}