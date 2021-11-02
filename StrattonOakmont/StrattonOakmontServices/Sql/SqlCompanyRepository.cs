using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

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

		public void AddCompany(Company company)
		{
			_context.Companies.Add(company);
			_context.SaveChanges();
		}

		public Company FindCompany(int id)
		{
			return _context.Companies.Find(id);
		}

		public Company GetCompany(int id)
		{
			var company = _context.Companies.Find(id);
			if(company != null)
			{
				_context.Companies.Add(company);
				_context.SaveChanges();
			}

			return company;
		}
	}
}
