using StrattonOakmontModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }
        Task<Company> FindCompanyAsync(int id);
        Task<Company> AddCompanyAsync(Company company);
        Task<Company> DeleteCompanyAsync(int id);
        Task<Company> UpdateCompanyAsync(Company company);
        Company FindCompany(int id);
    }
}
