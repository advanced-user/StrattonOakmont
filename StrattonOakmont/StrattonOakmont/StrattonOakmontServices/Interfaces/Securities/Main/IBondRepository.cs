using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IBondRepository
    {
        public Bond GetBond(int bondId);
        public List<Bond> GetAllBonds { get; }
        public List<PriceСhange> GetExpensiveBonds();
        public List<PriceСhange> GetСheapBonds();
        public Task<Bond> GetBondAsync(int bondId);
        public Task<Bond> AddBondAsync();
        public Task<Bond> DeleteBondAsync(int bondId);
        public Task<Security> DeleteSecurityBondsAsync (Security security);
    }
}
