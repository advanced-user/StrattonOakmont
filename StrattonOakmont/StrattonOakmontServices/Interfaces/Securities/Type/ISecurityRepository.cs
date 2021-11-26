using StrattonOakmontModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        public IEnumerable<Stoсk> GetAllStocks(int securityId);
        public IEnumerable<Bond> GetAllBonds(int securityId);
        public Task<Security> GetSecurityAsync(int id);
        public Task<Security> AddAsync(Security newSecurity);
        public Task<Security> DeleteAsync(int id);
    }
}
