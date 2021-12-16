using StrattonOakmontModels;
using StrattonOakmontModels.Securities.Main;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        public IEnumerable<Security> GetAllSecurities { get; }
        public IEnumerable<Stoсk> GetAllStocks(int securityId);
        public IEnumerable<Bond> GetAllBonds(int securityId);
        public IEnumerable<UserStock> GetUserStock(string userid);
        public IEnumerable<UserBond> GetUserBond(string userid);
        public Task<Security> GetSecurityAsync(int id);
        public Task<Security> AddAsync(Security newSecurity);
        public Task<Security> DeleteAsync(int id);
        User FindUser(string id); 
    }
}
