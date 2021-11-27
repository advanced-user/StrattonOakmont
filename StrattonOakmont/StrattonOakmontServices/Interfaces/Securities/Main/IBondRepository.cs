using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IBondRepository
    {
        public Bond GetBond(int bondId);
        public Task<Bond> AddBondAsync();
        public Task<Bond> DeleteBondAsync(int bondId);
        public Task<Security> DeleteSecurityBondsAsync (Security security);
    }
}
