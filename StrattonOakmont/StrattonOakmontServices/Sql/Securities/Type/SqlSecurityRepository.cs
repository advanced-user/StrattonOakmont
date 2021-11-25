using System.Collections.Generic;
using System.Threading.Tasks;
using StrattonOakmontModels;

namespace StrattonOakmontServices.Sql
{
    public class SqlSecurityRepository : ISecurityRepository
    {
        private readonly AppDBContext _context;

        public IEnumerable<Stonk> GetAllStonks => throw new System.NotImplementedException();

        public IEnumerable<Abligation> GetAllAbligation => throw new System.NotImplementedException();

        public IEnumerable<Security> GetAllSecurity => throw new System.NotImplementedException();

        public SqlSecurityRepository(AppDBContext context)
        {
            _context = context;
        }
    
        public Security GetSecurity(int id)
        {
            //var security = _context.Securities.FirstOrDefault(x => x.Id == id);
            //return security;
            return null;
        }

        public Security Add(Security newSecurity)
        {
            //_context.Securities.Add(newSecurity);
            //_context.SaveChanges();

            //return newSecurity;
            return null;
        }

        public Security Delete(int id)
        {
            //var security = _context.Securities.Find(id);

            //if (security != null)
            //{
            //    _context.Securities.Remove(security);
            //    _context.SaveChanges();
            //}

            //return security;
            return null;
        }

        public Task<Security> GetSecurityAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Security> AddAsync(Security newSecurity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Security> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}