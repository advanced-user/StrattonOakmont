using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces.Securities
{
    public interface IDateRepository
    {
        public Task<Date> AddAsync(Date date);
        public Task<Date> DeleteDateAsync(int id);
        public Task<Date> GetDateAsync(int id);
        public Task<Stonk> DeleteStoksDatesAsync(Stonk stonk);
        public Task<Abligation> DeleteAbligationDatesAsync(Abligation abligation);
    }
}
