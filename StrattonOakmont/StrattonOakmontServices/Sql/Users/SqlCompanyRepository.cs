﻿using StrattonOakmontModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace StrattonOakmontServices.Sql
{
	public class SqlCompanyRepository : ICompanyRepository
	{
		private readonly AppDBContext _context;
		private readonly ISecurityRepository _securityRepository;

		public SqlCompanyRepository(AppDBContext context, ISecurityRepository securityRepository)
		{
			_context = context;
			_securityRepository = securityRepository;
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
			return _context.Companies.Include(x => x.Security).FirstOrDefault(x => x.Id == id);
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

        public IEnumerable<Company> FilterCompanies(List<string> categoryNames)
        {
			return _context.Companies.Include(x => x.Security)
												.ThenInclude(x => x.Bonds)
												.ThenInclude(x => x.CategorySec)
												.Include(x => x.Security)
												.ThenInclude(x => x.Stocks)
												.ThenInclude(x => x.CategorySec)
												.Where(x => x.Security.Bonds.Where(b => categoryNames.Contains(b.CategorySec.CategoryName)) != null)
												.Where(x => x.Security.Stocks.Where(b => categoryNames.Contains(b.CategorySec.CategoryName)) != null)
												.ToList();
        }
    }
}
