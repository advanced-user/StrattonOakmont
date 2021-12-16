using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels;
using StrattonOakmontModels.Securities;
using StrattonOakmontModels.Securities.Main;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces.Securities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Purchase
{
    public class PurchaseBondModel : PageModel
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPriceChangeRepository _priceChangeRepository;
        private readonly UserManager<User> _userManager;
        private readonly AppDBContext _appDBContext;

        public PurchaseBondModel(ICompanyRepository companyRepository,
                             UserManager<User> userManager, AppDBContext appDBContext,
                             IPriceChangeRepository priceChangeRepository)
        {
            _companyRepository = companyRepository;
            _userManager = userManager;
            _appDBContext = appDBContext;
            _priceChangeRepository = priceChangeRepository;
        }


        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public Bond Bonds { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public Price—hange Price—hange { get; set; }

        public void OnGet(int companyId)
        {
            Company = _companyRepository.FindCompany(companyId);
            Bonds = Company.Security.Bonds;

            if (Bonds != null)
            {
                Price—hange = _priceChangeRepository.GetLatestBondPriceChage(Bonds.Id);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            Company = _companyRepository.FindCompany(Company.Id);
            Bonds = Company.Security.Bonds;
            Price—hange = _priceChangeRepository.GetPrice—hange(Price—hange.Id);

            if (Bonds != null && Price—hange.Amount >= Amount)
            {
                var user = await _userManager.Users.Include(x => x.Bond).ThenInclude(x => x.Bond)
                                                   .ThenInclude(x => x.Security).ThenInclude(x => x.Bonds)
                                                   .ThenInclude(x => x.CompanySec).Include(x => x.Receipts).ThenInclude(x => x.Bond)
                                                   .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);
                var receipt = new Receipt();

                receipt.Date = DateTime.Now;
                receipt.Company = Company;
                receipt.User = user;
                receipt.Bond = Bonds;
                receipt.Amount = Amount;
                receipt.Price = Price—hange.Price * Amount;
                receipt.Tax = receipt.Price * 0.05;
                Price—hange.Amount -= Amount;

                if (user.Bond == null)
                {
                    user.Bond = new List<UserBond>() { new UserBond { Bond = Bonds, Amount = Amount } };
                }
                else
                {
                    var userBond = user.Bond.FirstOrDefault(x => x.Bond.Security.Bonds.CompanySec.Id == Company.Id);
                    if (userBond != null)
                    {
                        userBond.Amount += Amount;
                    }
                    else
                    {
                        user.Bond.Add(new UserBond { Bond = Bonds, Amount = Amount });
                    }
                }

                await _appDBContext.Receipts.AddAsync(receipt);
                await _appDBContext.SaveChangesAsync();
            }



            return RedirectToPage("/Company/View", new { id = Company.Id });
        }
    }
}
