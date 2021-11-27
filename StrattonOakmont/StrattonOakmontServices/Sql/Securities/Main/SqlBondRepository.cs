using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
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
                foreach (var bond in security.Bonds)
                {
                    await _priceChangeRepository.DeleteStockPriceChages(bond.Id); ;
                    _context.Bonds.Remove(bond);
                }
            }

            await _context.SaveChangesAsync();

            return security;
        }

        public Bond GetBond(int bondId)
        {
            return _context.Bonds.Find(bondId);
        }
    }
}
