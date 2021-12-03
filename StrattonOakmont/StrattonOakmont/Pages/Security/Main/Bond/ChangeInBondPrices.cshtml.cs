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
        public List<StrattonOakmontModels.Securities.PriceÑhange> PriceÑhanges { get; set; }
        
        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int Sort { get; set; }

        [BindProperty]
        public int BondId { get; set; }


        public void OnGet(int companyId, int bondId)
        {
            PriceÑhanges = _bondRepository.GetBond(bondId).PriceÑhanges;
            Company = _companyRepository.FindCompany(companyId);
            BondId = bondId;
        }
        public void OnPostSort(string fill)
        {
            PriceÑhanges = _bondRepository.GetBond(BondId).PriceÑhanges;
            Company = _companyRepository.FindCompany(Company.Id);

            switch (fill)
            {
                case "Price":
                    if (Sort == -1)
                    {
                        PriceÑhanges = PriceÑhanges.OrderBy(x => x.Price).ToList();
                    }
                    else
                    {
                        PriceÑhanges = PriceÑhanges.OrderByDescending(x => x.Price).ToList();
                    }
                    break;
                case "Volume":
                    if (Sort == -1)
                    {
                        PriceÑhanges = PriceÑhanges.OrderBy(x => x.Volume).ToList();
                    }
                    else
                    {
                        PriceÑhanges = PriceÑhanges.OrderByDescending(x => x.Volume).ToList();
                    }
                    break;
                case "Amount":
                    if (Sort == -1)
                    {
                        PriceÑhanges = PriceÑhanges.OrderBy(x => x.Amount).ToList();
                    }
                    else
                    {
                        PriceÑhanges = PriceÑhanges.OrderByDescending(x => x.Amount).ToList();
                    }
                    break;
                case "Date":
                    if (Sort == -1)
                    {
                        PriceÑhanges = PriceÑhanges.OrderBy(x => x.Date).ToList();
                    }
                    else
                    {
                        PriceÑhanges = PriceÑhanges.OrderByDescending(x => x.Date).ToList();
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
