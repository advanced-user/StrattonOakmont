using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Profile
{
    public class SecuritiesModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSellBond()
        {

            return Page();
        }

        public async Task<IActionResult> OnPostSellStock()
        {

            return Page();
        }
    }
}
