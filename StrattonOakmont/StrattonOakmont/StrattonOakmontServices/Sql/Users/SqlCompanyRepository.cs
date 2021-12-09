using StrattonOakmontModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using StrattonOakmontModels.Securities;
using StrattonOakmontServices.Interfaces.Securities;
using StrattonOakmontServices.Interfaces;

namespace StrattonOakmontServices.Sql
{
	public class SqlCompanyRepository : ICompanyRepository
	{
		private readonly AppDBContext _context;
		private readonly ISecurityRepository _securityRepository;
		private readonly IPriceChangeRepository _priceChangeRepository;
		private readonly IStockRepository _stockRepository;

		public SqlCompanyRepository(AppDBContext context, ISecurityRepository securityRepository,
									IPriceChangeRepository priceChangeRepository,
									IStockRepository stockRepository)
		{
			_context = context;
			_securityRepository = securityRepository;
			_priceChangeRepository = priceChangeRepository;
			_stockRepository = stockRepository;
		}

		public IEnumerable<Company> GetAllCompanies
		{
			get
			{
				return _context.Companies.Include(x => x.Security);
			}
		}

		public async Task<Company> AddCompanyAsync(Company company)
		{
			await _context.Companies.AddAsync(company);
			await _context.SaveChangesAsync();

			return company;
		}

		public async Task<Company> UpdateCompanyAsync(Company updateCompanym, int companyId)
		{
			var company = FindCompany(companyId);

			if (company != null)
            {
				company.IMG = updateCompanym.IMG;
				company.Desc = updateCompanym.Desc;
				company.Name = updateCompanym.Name;
				company.Сapitalization = updateCompanym.Сapitalization;

				await _context.SaveChangesAsync();
			}

			return company;
		}

		public async Task<Company> DeleteCompanyAsync(int id)
        {
            var company = await FindCompanyAsync(id);

			if (company == null)
            {
				return company;
            }

            if (company.Security != null)
            {
				await _securityRepository.DeleteAsync(company.Security.Id);
            }

            _context.Companies.Remove(company);
			await _context.SaveChangesAsync();

			return company;
		}

		public Company FindCompany(int id)
		{
			return _context.Companies.Include(x => x.Security).ThenInclude(x => x.Stocks).ThenInclude(x => x.UserSec).FirstOrDefault(x => x.Id == id);
		}

		public async Task<Company> FindCompanyAsync(int id)
		{
			return await _context.Companies.Include(x => x.Security).FirstOrDefaultAsync(x => x.Id == id);
		}

        public IEnumerable<Company> GetCompaniesByName(string Name)
        {
			
			return _context.Companies.Include(x => x.Security).Where(o => o.Name == Name);
			
		}

        public Company FindCompanyFilter(string Name)
        {
            throw new System.NotImplementedException();
        }

        public List<Company> FilterCompanies(List<string> categoryNames)
        {
			List<Company> companies = new List<Company>();
			if (categoryNames.Count() == 2)
            {
				return _context.Companies.Include(x => x.Security)
										 .ThenInclude(x => x.Stocks)
										 .ThenInclude(x => x.CategorySec)
										 .Include(x => x.Security)
										 .ThenInclude(x => x.Bonds)
										 .ThenInclude(x => x.CategorySec).ToList();
			}
			else if (categoryNames[0] == "Stock")
            {
				return _context.Companies.Include(x => x.Security)
						 .ThenInclude(x => x.Stocks)
						 .ThenInclude(x => x.CategorySec).Where(x => x.Security.Stocks != null).ToList();
			}
			else if (categoryNames[0] == "Bond")
            {
				return _context.Companies.Include(x => x.Security)
						 .ThenInclude(x => x.Bonds)
						 .ThenInclude(x => x.CategorySec).Where(x => x.Security.Bonds != null).ToList();
			}
            else
            {
				return new List<Company>();
            }
        }

        public List<Company> FilterPrice(int more, int less)
        {
			var stocks = _stockRepository.GetAllStock;
			
			var priceChanges = new List<PriceСhange>();

			foreach (var stock in stocks)
            {
				var price = _priceChangeRepository.GetLatestStockPriceChage(stock.Id);
				if (price.Price >= more && price.Price <= less)
                {
					priceChanges.Add(price);
				}
				
            }

			return priceChanges.Select(x => x.Stoсk.CompanySec).ToList();
			//return _context.Companies.Include(x => x.Security)
			//							.ThenInclude(x => x.Stocks)
			//							.Include(x => x.Security)
			//							.ThenInclude(x => x.Bonds).Where(x => x.Security.Stocks.PriceСhanges.Contains()).ToList();
        }
    }
}
