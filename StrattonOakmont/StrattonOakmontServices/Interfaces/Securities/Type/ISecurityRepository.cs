using StrattonOakmontModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        public IEnumerable<Stonk> GetAllStonks { get; }
        public IEnumerable<Abligation> GetAllAbligation { get; }
        public IEnumerable<Security> GetAllSecurity { get; }
        public Task<Security> GetSecurityAsync(int id);
        public Task<Security> AddAsync(Security newSecurity);
        public Task<Security> DeleteAsync(int id);
    }
}
