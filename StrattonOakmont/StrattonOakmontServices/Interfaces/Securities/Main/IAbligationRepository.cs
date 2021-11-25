using StrattonOakmontModels;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Interfaces
{
    public interface IAbligationRepository
    {
        public Task<Abligation> AddAbligationAsync { get; set; }
        public Task<Abligation> DeleteAbligationAsync { get; set; }
    }
}
