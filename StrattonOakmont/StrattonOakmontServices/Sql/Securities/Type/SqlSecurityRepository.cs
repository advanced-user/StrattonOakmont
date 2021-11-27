using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmontServices.Sql
{
    public class SqlSecurityRepository : ISecurityRepository
    {
        private readonly AppDBContext _context;
        private readonly IStockRepository _stockRepository;
        private readonly IBondRepository _bondRepository;

        public IEnumerable<Security> GetAllSecurities
        {
            get 
            {
                return _context.Securities.Include(x => x.Bonds)
                                          .ThenInclude(bond => bond.CategorySec)
                                          .Include(x => x.Stocks)
                                          .ThenInclude(stock => stock.CategorySec)
                                          .Include(x => x.Company);
            }
        }

        public SqlSecurityRepository(AppDBContext context, IStockRepository stockRepository, IBondRepository bondRepository)
        {
            _context = context;
            _stockRepository = stockRepository;
            _bondRepository = bondRepository;
        }

        public Security Add(Security newSecurity)
        {
            _context.Securities.Add(newSecurity);
            _context.SaveChanges();

            return newSecurity;
        }

        public async Task<Security> GetSecurityAsync(int id)
        {
            return await _context.Securities.Include(x => x.Bonds)
                                      .Include(x => x.Stocks)
                                      .Include(x => x.Company).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Security> AddAsync(Security newSecurity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Security> DeleteAsync(int id)
        {
            var security = _context.Securities.Include(x => x.Stocks).Include(x => x.Bonds).FirstOrDefault(x => x.Id == id);

            if (security != null)
            {
                if (security.Stocks != null)
                {
                    await _stockRepository.DeleteSecurityStocksAsync(security);
                }
                if (security.Bonds != null)
                {
                    await _bondRepository.DeleteSecurityBondsAsync(security); 
                }


                _context.Securities.Remove(security);
                await _context.SaveChangesAsync();
            }

            return security;
        }

        public IEnumerable<Stoсk> GetAllStocks(int securityId)
        {
            return _context.Stocks.Include(x => x.CategorySec).Include(x => x.CompanySec).Where(x => x.Security.Id == securityId);
        }

        public IEnumerable<Bond> GetAllBonds(int securityId)
        {
            return _context.Bonds.Include(x => x.CategorySec).Include(x => x.CompanySec).Where(x => x.Security.Id == securityId);
        }
    }
}