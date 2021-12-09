using Microsoft.EntityFrameworkCore;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StrattonOakmontServices.Sql
{
    public class SqlReceiptRepository : IReceiptRepository
    {
        private readonly AppDBContext _context;

        public SqlReceiptRepository(AppDBContext context)
        {
            _context = context;
        }

        public Receipt GetReceipt(int id)
        {
            return _context.Receipts.Include(x => x.User).Include(x => x.Company).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Receipt> GetReceipts()
        {
            return _context.Receipts.Include(x => x.User).Include(x => x.Company);
        }
    }
}
