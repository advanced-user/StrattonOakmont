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

        public Task<Abligation> DeleteAbligationAsync()
        {
            throw new System.NotImplementedException();
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
