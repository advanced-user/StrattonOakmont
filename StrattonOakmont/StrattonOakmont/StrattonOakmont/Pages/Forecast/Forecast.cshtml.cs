using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices;
using StrattonOakmontServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

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
        public string Prices { get; set; }

        [BindProperty]
        public List<DateTime> Dates { get; set; }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }

        [BindProperty]
        public int StockId { get; set; }

        public void OnGet(int companyId, int stockId)
        {
            Dates = _stockRepository.GetStoñk(stockId).PriceÑhanges.Select(x => x.Date).ToList();

            Prices = JsonSerializer.Serialize(_stockRepository.GetStoñk(stockId).PriceÑhanges.Select(x => x.Price).ToList());

            Company = _companyRepository.FindCompany(companyId);
        }
    }
}
