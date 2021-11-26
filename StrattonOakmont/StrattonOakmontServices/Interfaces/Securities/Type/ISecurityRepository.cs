using StrattonOakmontModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        public IEnumerable<Stonk> GetAllStonks(int securityId);
        public IEnumerable<Abligation> GetAllAbligation(int securityId);
        public Task<Security> GetSecurityAsync(int id);
        public Task<Security> AddAsync(Security newSecurity);
        public Task<Security> DeleteAsync(int id);
    }
}
