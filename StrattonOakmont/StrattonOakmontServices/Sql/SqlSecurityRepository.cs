using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;

namespace StrattonOakmontServices.Sql
{
    public class SqlSecurityRepository : ISecurityRepository
    {
        private readonly AppDBContext _context;
        
        public SqlSecurityRepository(AppDBContext context)
        {
            _context = context;
        }
    
        public IEnumerable<Security> GetAllSecurities()
        {
            //return _context.Securities;
            return null;
        }

        public IEnumerable<Security> AllSecurities { get; }
        public Security GetSecurity(int id)
        {
            //var security = _context.Securities.FirstOrDefault(x => x.Id == id);
            //return security;
            return null;
        }

        public async Task<Security> Update(Security updateSecurity)
        {
            //var security = _context.Securities.Attach(updateSecurity);
            //security.State = EntityState.Modified;
            //await _context.SaveChangesAsync();

            //return updateSecurity;
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

		public IEnumerable<Category> GetAllCategories()
		{
            return _context.Categories;
		}
	}
}