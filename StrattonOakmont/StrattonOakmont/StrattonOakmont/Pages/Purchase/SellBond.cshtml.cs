using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Purchase
{
    public class SellBondModel : PageModel
    {
        private readonly ISecurityRepository _dbSecurity;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly AppDBContext _appDBContext;

        public SellBondModel(ISecurityRepository dbSecurity,
                         IPriceChangeRepository priceChangeRepository,
                         AppDBContext appDBContext)
        {
            _dbSecurity = dbSecurity;
            _priceChangeRepository = priceChangeRepository;
            _appDBContext = appDBContext;
        }

        public StrattonOakmontModels.Securities.Main.UserBond UserBond { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public int UserBondId { get; set; }

        [BindProperty]
        public int BondId { get; set; }

        public void OnGet(int userBondId)
        {
            UserBond = _dbSecurity.GetUserBond(User.Identity.Name).FirstOrDefault(x => x.Id == userBondId);
            UserBondId = userBondId;
            BondId = UserBond.Bond.Id;
        }

        public async Task<IActionResult> OnPost()
        {
            UserBond = _dbSecurity.GetUserBond(User.Identity.Name).FirstOrDefault(x => x.Id == UserBondId);
            var Price—hange = _priceChangeRepository.GetLatestStockPriceChage(BondId);

            if (Price—hange != null && UserBond.Amount < Amount)
            {
                return RedirectToPage("/Profile");
            }

            UserBond.Amount -= Amount;
            Price—hange.Amount += Amount;

            await _appDBContext.SaveChangesAsync();

            return RedirectToPage("/Profile");
        }
    }
}
