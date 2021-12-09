using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmont.Pages.Security.Main.Bond
{
    public class ChangeInBondPricesModel : PageModel
    {
        private readonly IBondRepository _bondRepository;
        private readonly ICompanyRepository _companyRepository;

        public ChangeInBondPricesModel(IBondRepository bondRepository, ICompanyRepository companyRepository)
        {
            _bondRepository = bondRepository;
            _companyRepository = companyRepository;
        }


        [BindProperty]
        public List<StrattonOakmontModels.Securities.Price�hange> Price�hanges { get; set; }
        
        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int Sort { get; set; }

        [BindProperty]
        public int BondId { get; set; }


        public void OnGet(int companyId, int bondId)
        {
            Price�hanges = _bondRepository.GetBond(bondId).Price�hanges;
            Company = _companyRepository.FindCompany(companyId);
            BondId = bondId;
        }
        public void OnPostSort(string fill)
        {
            Price�hanges = _bondRepository.GetBond(BondId).Price�hanges;
            Company = _companyRepository.FindCompany(Company.Id);

            switch (fill)
            {
                case "Price":
                    if (Sort == -1)
                    {
                        Price�hanges = Price�hanges.OrderBy(x => x.Price).ToList();
                    }
                    else
                    {
                        Price�hanges = Price�hanges.OrderByDescending(x => x.Price).ToList();
                    }
                    break;
                case "Volume":
                    if (Sort == -1)
                    {
                        Price�hanges = Price�hanges.OrderBy(x => x.Volume).ToList();
                    }
                    else
                    {
                        Price�hanges = Price�hanges.OrderByDescending(x => x.Volume).ToList();
                    }
                    break;
                case "Amount":
                    if (Sort == -1)
                    {
                        Price�hanges = Price�hanges.OrderBy(x => x.Amount).ToList();
                    }
                    else
                    {
                        Price�hanges = Price�hanges.OrderByDescending(x => x.Amount).ToList();
                    }
                    break;
                case "Date":
                    if (Sort == -1)
                    {
                        Price�hanges = Price�hanges.OrderBy(x => x.Date).ToList();
                    }
                    else
                    {
                        Price�hanges = Price�hanges.OrderByDescending(x => x.Date).ToList();
                    }
                    break;
            }

            if (Sort == 1)
            {
                Sort = -1;
            }
            else
            {
                Sort = 1;
            }
        }

    }
}
