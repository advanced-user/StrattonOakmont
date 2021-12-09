using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmont.Pages.Purchase.Receipts
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
            Receipts = _receiptRepository.GetReceipts().Where(x => x.User.UserName == User.Identity.Name);
        }
    }
}
