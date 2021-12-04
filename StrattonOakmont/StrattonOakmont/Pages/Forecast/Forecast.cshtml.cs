using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmont.Pages.Forecast
{
    public class ForecastModel : PageModel
    {
        private readonly IStockRepository _stockRepository;
        private readonly ICompanyRepository _companyRepository;

        public ForecastModel(IStockRepository stockRepository, ICompanyRepository companyRepository)
        {
            _stockRepository = stockRepository;
            _companyRepository = companyRepository;
        }


        [BindProperty]
        public List<double> Prices { get; set; }

        [BindProperty]
        public List<DateTime> Dates { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int StockId { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Prices = _stockRepository.GetStoñk(stockId).PriceÑhanges.Select(x => x.Price).ToList();
            Dates = _stockRepository.GetStoñk(stockId).PriceÑhanges.Select(x => x.Date).ToList();

            Company = _companyRepository.FindCompany(companyId);
        }
    }
}
