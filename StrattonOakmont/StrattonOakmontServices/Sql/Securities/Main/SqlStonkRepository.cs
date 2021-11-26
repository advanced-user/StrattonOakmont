using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;
using StrattonOakmontServices.Interfaces.Securities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql.Securities.Main
{
    public class SqlStonkRepository : IStonkRepository
    {
        private readonly AppDBContext _context;
        private readonly IDateRepository _dateRepository;

        public SqlStonkRepository(AppDBContext context, IDateRepository dateRepository)
        {
            _context = context;
            _dateRepository = dateRepository;
        }

        public async Task<Stonk> AddStonkAsync(Stonk stonk)
        {
            await _context.Stonks.AddAsync(stonk);
            await _context.SaveChangesAsync();

            return stonk;
        }

        public async Task<Security> DeleteSecurityStonksAsync(Security security)
        {
            if (security != null && security.Stonks != null)
            {
                foreach (var stonk in security.Stonks)
                {
                    await _dateRepository.DeleteStoksDatesAsync(stonk);
                    _context.Stonks.Remove(stonk);
                }
            }

            await _context.SaveChangesAsync();

            return security;
        }

        public async Task<Stonk> DeleteStonkAsync(int id)
        {
            var stock = await _context.Stonks.Include(x => x.DateTimesChanges).FirstOrDefaultAsync(x => x.Id == id);

            if (stock != null)
            {
                await _dateRepository.DeleteStoksDatesAsync(stock);
                _context.Stonks.Remove(stock);

                await _context.SaveChangesAsync();
            }

            return stock;
        }
    }
}
