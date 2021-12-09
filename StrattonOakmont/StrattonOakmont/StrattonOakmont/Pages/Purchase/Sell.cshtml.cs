using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Purchase
{
    public class SellModel : PageModel
    {
        private readonly ISecurityRepository _dbSecurity;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly AppDBContext _appDBContext;

        public SellModel(ISecurityRepository dbSecurity,
                         IPriceChangeRepository priceChangeRepository,
                         AppDBContext appDBContext)
        {
            _dbSecurity = dbSecurity;
            _priceChangeRepository = priceChangeRepository;
            _appDBContext = appDBContext;
        }

        public StrattonOakmontModels.Securities.Main.UserStock UserStocks { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public int UserStockId { get; set; }

        [BindProperty]
        public int StockId { get; set; }

        public void OnGet(int userStockId)
        {
            UserStocks = _dbSecurity.GetUserStock(User.Identity.Name).FirstOrDefault(x => x.Id == userStockId);
            UserStockId = userStockId;
            StockId = UserStocks.StoÒk.Id;
        }

        public async Task<IActionResult> OnPost()
        {
            UserStocks = _dbSecurity.GetUserStock(User.Identity.Name).FirstOrDefault(x => x.Id == UserStockId);
            var Price—hange = _priceChangeRepository.GetLatestStockPriceChage(StockId);

            if (Price—hange != null && UserStocks.Amount < Amount)
            {
                return RedirectToPage("/Profile");
            }

            UserStocks.Amount -= Amount;
            Price—hange.Amount += Amount;

            await _appDBContext.SaveChangesAsync();

            return RedirectToPage("/Profile");
        }
    }
}
