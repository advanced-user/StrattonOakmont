using StrattonOakmontModels.Securities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices.Interfaces
{
    public interface IReceiptRepository
    {
        public IEnumerable<Receipt> GetReceipts();
        public Receipt GetReceipt(int id);
    }
}
