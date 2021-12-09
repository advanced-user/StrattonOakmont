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
    public class SqlBondRepository : IBondRepository
    {
        private readonly AppDBContext _context;
        private readonly IPriceChangeRepository _priceChangeRepository;

        public SqlBondRepository(AppDBContext context, IPriceChangeRepository priceChangeRepository)
        {
            _context = context;
            _priceChangeRepository = priceChangeRepository;
        }

        public List<Bond> GetAllBonds
        {
            get
            {
                return _context.Bonds.ToList();
            }
        }

        public Task<Bond> AddBondAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Bond> DeleteBondAsync(int bondId)
        {
            var bond = await _context.Bonds.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == bondId);

            if (bond != null)
            {
                await _priceChangeRepository.DeleteBondPriceChages(bondId);
                _context.Bonds.Remove(bond);

                await _context.SaveChangesAsync();
            }

            return bond;
        }

        public async Task<Security> DeleteSecurityBondsAsync(Security security)
        {
            if (security != null && security.Bonds != null)
            {
                await _priceChangeRepository.DeleteBondPriceChages(security.Bonds.Id); ;
                _context.Bonds.Remove(security.Bonds);
            }

            await _context.SaveChangesAsync();

            return security;
        }

        public Bond GetBond(int bondId)
        {
            return _context.Bonds.Include(x => x.PriceСhanges).FirstOrDefault(x => x.Id == bondId);
        }

        public async Task<Bond> GetBondAsync(int bondId)
        {
            return await _context.Bonds.Include(x => x.PriceСhanges).FirstOrDefaultAsync(x => x.Id == bondId);
        }

        public List<PriceСhange> GetСheapBonds()
        {
            var bonds = GetAllBonds;

            var priceChanges = new List<PriceСhange>();

            foreach (var bond in bonds)
            {
                var price = _priceChangeRepository.GetLatestBondPriceChage(bond.Id);
                priceChanges.Add(price);
            }

            return priceChanges.OrderBy(x => x.Price).Take(5).ToList();
        }

        public List<PriceСhange> GetExpensiveBonds()
        {
            var bonds = GetAllBonds;

            var priceChanges = new List<PriceСhange>();

            foreach (var bond in bonds)
            {
                var price = _priceChangeRepository.GetLatestBondPriceChage(bond.Id);
                priceChanges.Add(price);
            }

            return priceChanges.OrderByDescending(x => x.Price).Take(5).ToList();
        }
    }
}
