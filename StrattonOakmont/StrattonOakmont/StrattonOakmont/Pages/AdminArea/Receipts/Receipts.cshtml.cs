using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;

namespace StrattonOakmont.Pages.Receipts
{
    public class ReceiptsModel : PageModel
    {
        private readonly IReceiptRepository _receiptRepository;

        public ReceiptsModel(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }

        [BindProperty]
        public IEnumerable<Receipt> Receipts { get; set; }

        public void OnGet()
        {
            Receipts = _receiptRepository.GetReceipts();
        }
    }
}
