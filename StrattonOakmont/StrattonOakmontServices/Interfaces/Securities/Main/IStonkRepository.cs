using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IStonkRepository
    {
        public Task<Stonk> AddStonkAsync(Stonk stonk);
        public Task<Stonk> DeleteStonkAsync(int id);
        public Task<Security> DeleteSecurityStonksAsync(Security security);
    }
}
