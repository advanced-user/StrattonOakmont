using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmont.Pages.Statistics
{
    public class StatisticsModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;
        private readonly IStockRepository _stockRepository;
        private readonly IBondRepository _bondRepository;

        public StatisticsModel(ICompanyRepository dbCompany, IStockRepository stockRepository, IBondRepository bondRepository)
        {
            _dbCompany = dbCompany;
            _stockRepository= stockRepository;
            _bondRepository = bondRepository;
        }

        [BindProperty]
        public List<StrattonOakmontModels.Company> Companies { get; set; }

        [BindProperty]
        public List<Price—hange> ExpensiveStocks { get; set; }
        
        [BindProperty]
        public List<Price—hange> —heapeStocks { get; set; }  
        
        [BindProperty]
        public List<Price—hange> ExpensiveBonds { get; set; }
        
        [BindProperty]
        public List<Price—hange> —heapeBonds { get; set; }


        public void OnGet()
        {
            Companies = _dbCompany.GetAllCompanies.OrderByDescending(x => x.—apitalization).Take(5).ToList();

            ExpensiveStocks = _stockRepository.GetExpensiveStocks();
            —heapeStocks = _stockRepository.Get—heapStocks();

            ExpensiveBonds = _bondRepository.GetExpensiveBonds();
            —heapeBonds = _bondRepository.Get—heapBonds();
        }
    }
}
