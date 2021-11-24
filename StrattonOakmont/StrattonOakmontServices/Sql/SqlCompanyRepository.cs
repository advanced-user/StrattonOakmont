using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StrattonOakmontServices.Sql
{
	public class SqlCompanyRepository : ICompanyRepository
	{
		private readonly AppDBContext _context;

		public SqlCompanyRepository(AppDBContext context)
		{
			_context = context;
		}

		public IEnumerable<Company> GetAllCompanies
		{
			get
			{
				return _context.Companies;
			}
		}

		public async Task<Company> AddCompanyAsync(Company company)
		{
			await _context.Companies.AddAsync(company);
			await _context.SaveChangesAsync();

			return company;
		}

		public async Task<Company> UpdateCompanyAsync(Company updateCompany)
		{
			var company = _context.Companies.Attach(updateCompany);
			company.State = EntityState.Modified;
			await _context.SaveChangesAsync();

			return updateCompany;
		}

		public async Task<Company> DeleteCompanyAsync(int id)
        {
            var company = await FindCompanyAsync(id);

			if (company == null)
            {
				return company;
            }

			//if (company.Securities != null)
   //         {
			//	foreach (var security in company.Securities)
			//	{
			//		if (security != null)
			//		{
   //                     _context.Securities.Remove(security);
   //                 }
			//	}
			//}

			_context.Companies.Remove(company);
			await _context.SaveChangesAsync();

			return company;
		}

		public Company FindCompany(int id)
		{
			return _context.Companies.Find(id);
		}

		public async Task<Company> FindCompanyAsync(int id)
		{
			return await _context.Companies.Include(x => x.Securities).FirstOrDefaultAsync(x => x.Id == id);
		}
    }
}
