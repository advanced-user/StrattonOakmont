using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }
        Company GetCompany(int id);
        void AddCompany(Company company);
        Company FindCompany(int id);
    }
}
