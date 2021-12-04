using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmont.Pages.AdminArea.Receipts
{
    public class ReceiptModel : PageModel
    {
        private readonly IReceiptRepository _receiptRepository;

        public ReceiptModel(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }

        [BindProperty]
        public Receipt Receipt { get; set; }

        public void OnGet(int id)
        {
            Receipt = _receiptRepository.GetReceipt(id);
        }
    }
}
