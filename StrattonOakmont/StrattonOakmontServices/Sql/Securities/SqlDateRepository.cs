using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces.Securities;
using System;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql.Securities
{
    public class SqlDateRepository : IDateRepository
    {
        private readonly AppDBContext _context;

        public SqlDateRepository(AppDBContext context)
        {
            _context = context;
        }

        public Task<Date> AddAsync(Date date)
        {
            throw new NotImplementedException();
        }

        public async Task<Abligation> DeleteAbligationDatesAsync(Abligation abligation)
        {
            if (abligation != null)
            {
                if (abligation.DateTimesChanges != null)
                {
                    foreach (var date in abligation.DateTimesChanges)
                    {
                        _context.Dates.Remove(date);
                    }
                }
            }

            await _context.SaveChangesAsync();

            return abligation;
        }

        public async Task<Stonk> DeleteStoksDatesAsync(Stonk stonk)
        {
            if (stonk != null)
            {
                if (stonk.DateTimesChanges != null)
                {
                    foreach (var date in stonk.DateTimesChanges)
                    {
                        _context.Dates.Remove(date);
                    }
                }
            }

            await _context.SaveChangesAsync();

            return stonk;
        }

        public Task<Date> DeleteDateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Date> GetDateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
