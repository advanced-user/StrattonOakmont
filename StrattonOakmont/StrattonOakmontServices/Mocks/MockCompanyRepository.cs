using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrattonOakmontServices
{
    class MockCompanyRepository : ICompanyRepository
    {
        public IEnumerable<Company> GetAllCompanies
        {
            get
            {
                return new List<Company>
                {
                    new Company{Name = "Google", Id = 1, IMG ="Google.jpg", Desc = "Google.jpg", Сapitalization = 10000000},
                    new Company{Name = "Amazon", Id = 2, IMG ="Amazon.jpg", Desc = "Amazon.jpg", Сapitalization = 10000000}
                };
            }
        }

		public void AddCompany(Company company)
		{
			throw new NotImplementedException();
		}

        public Company FindCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(int id)
        {
            return GetAllCompanies.FirstOrDefault(x => x.Id == id);
        }
    }
}
