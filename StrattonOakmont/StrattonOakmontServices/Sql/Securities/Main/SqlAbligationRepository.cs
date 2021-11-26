using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql.Securities.Main
{
    public class SqlAbligationRepository : IAbligationRepository
    {
        private readonly AppDBContext _context;
        private readonly IDateRepository _dateRepository;

        public SqlAbligationRepository(AppDBContext context, IDateRepository dateRepository)
        {
            _context = context;
            _dateRepository = dateRepository;
        }

        public Task<Abligation> AddAbligationAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Abligation> DeleteAbligationAsync(int bondId)
        {
            var bond = await _context.Abligations.Include(x => x.DateTimesChanges).FirstOrDefaultAsync(x => x.Id == bondId);

            if (bond != null)
            {
                await _dateRepository.DeleteAbligationDatesAsync(bond);
                _context.Abligations.Remove(bond);

                await _context.SaveChangesAsync();
            }

            return bond;
        }

        public async Task<Security> DeleteSecurityAbligationsAsync(Security security)
        {
            if (security != null && security.Abligations != null)
            {
                foreach (var abligation in security.Abligations)
                {
                    await _dateRepository.DeleteAbligationDatesAsync(abligation);
                    _context.Abligations.Remove(abligation);
                }
            }

            await _context.SaveChangesAsync();

            return security;
        }
    }
}
