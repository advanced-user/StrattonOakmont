using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IAbligationRepository
    {
        public Task<Abligation> AddAbligationAsync();
        public Task<Abligation> DeleteAbligationAsync(int bondId);
        public Task<Security> DeleteSecurityAbligationsAsync(Security security);
    }
}
