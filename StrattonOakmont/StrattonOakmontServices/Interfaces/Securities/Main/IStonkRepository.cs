using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IStonkRepository
    {
        public Task<Stonk> AddStonkAsync(int id);
        public Task<Stonk> DeleteStonkAsync(int id);
    }
}
