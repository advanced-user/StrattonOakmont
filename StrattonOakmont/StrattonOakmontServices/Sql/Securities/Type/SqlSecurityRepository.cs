using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmontServices.Sql
{
    public class SqlSecurityRepository : ISecurityRepository
    {
        private readonly AppDBContext _context;
        private readonly IStonkRepository _stonkRepository;
        private readonly IAbligationRepository _abligationRepository;

        public IEnumerable<Stonk> GetAllStonks => throw new System.NotImplementedException();

        public IEnumerable<Abligation> GetAllAbligation => throw new System.NotImplementedException();

        public IEnumerable<Security> GetAllSecurity => throw new System.NotImplementedException();

        public SqlSecurityRepository(AppDBContext context, IStonkRepository stonkRepository, IAbligationRepository abligationRepository)
        {
            _context = context;
            _stonkRepository = stonkRepository;
            _abligationRepository = abligationRepository;
        }
    
        public Security GetSecurity(int id)
        {
            //var security = _context.Securities.FirstOrDefault(x => x.Id == id);
            //return security;
            return null;
        }

        public Security Add(Security newSecurity)
        {
            _context.Securities.Add(newSecurity);
            _context.SaveChanges();

            return newSecurity;
        }

        public Task<Security> GetSecurityAsync(int id)
        {
            return _context.Securities.Include(x => x.Abligations)
                                      .Include(x => x.Stonks)
                                      .Include(x => x.Company).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Security> AddAsync(Security newSecurity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Security> DeleteAsync(int id)
        {
            var security = _context.Securities.Include(x => x.Stonks).Include(x => x.Abligations).FirstOrDefault(x => x.Id == id);

            if (security != null)
            {
                if (security.Stonks != null)
                {
                    await _stonkRepository.DeleteSecurityStonksAsync(security);
                }
                if (security.Abligations != null)
                {
                    await _abligationRepository.DeleteSecurityAbligationsAsync(security); 
                }


                _context.Securities.Remove(security);
                await _context.SaveChangesAsync();
            }

            return security;
        }
    }
}