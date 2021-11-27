using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class AddNewPriceModel : PageModel
    {
        private readonly IBondRepository _bondRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly AppDBContext _context;

        public AddNewPriceModel(AppDBContext context, IBondRepository bondRepository,
                                ICompanyRepository companyRepository)
        {
            _bondRepository = bondRepository;
            _context = context;
            _companyRepository = companyRepository;
        }

        [BindProperty]
        public StrattonOakmontModels.Bond Bond { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        public void OnGet(int companyId, int bondId)
        {
            Bond = _bondRepository.GetBond(bondId);
            Company = _companyRepository.FindCompany(companyId);
        }

        public async Task<IActionResult> OnPost()
        {
            var bond = await _bondRepository.GetBondAsync(Bond.Id);
            if (Bond != null && bond != null && bond.Amount != 0)
            {
                bond.Amount = Bond.Amount;
                bond.Volume = Bond.Volume;
                bond.Price = Bond.Volume / Bond.Amount;

                var priceChange = new StrattonOakmontModels.Securities.Price—hange()
                {
                    Date = DateTime.Now,
                    Price = bond.Price
                };

                bond.Price—hanges.Add(priceChange);

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Company/Edit", new { id = Company.Id });
        }
    }
}
