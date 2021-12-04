using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.AdminArea.Receipts
{
    public class IncomeModel : PageModel
    {
        private readonly IReceiptRepository _receiptRepository;

        public IncomeModel(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }

        [BindProperty]
        public IEnumerable<Receipt> Receipts { get; set; }

        [BindProperty]
        public double Income { get; set; }

        public void OnGet()
        {
            Receipts = _receiptRepository.GetReceipts();

            foreach(var r in Receipts)
            {
                Income += r.Tax;
            }
        }
    }
}
