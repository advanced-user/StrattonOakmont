using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ISecurityRepository
    {
        public IEnumerable<Security> GetAllSecurities();
        public IEnumerable<Category> GetAllCategories();
        public IEnumerable<Security> AllSecurities { get; }
        public Security GetSecurity(int id);
        public Task<Security> Update(Security updatedSecurity);
        public Security Add(Security newSecurity);
        public Security Delete(int id);
    }
}
