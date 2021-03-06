using StrattonOakmontModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StrattonOakmontServices
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }
        IEnumerable<Company> GetCompaniesByName(string Name);
        List<Company> FilterCompanies(List<string> categoryNames);
        List<Company> FilterPrice(int more, int less);
        Task<Company> FindCompanyAsync(int id);
        Task<Company> AddCompanyAsync(Company company);
        Task<Company> DeleteCompanyAsync(int id);
        Task<Company> UpdateCompanyAsync(Company company, int companyId);       
        Company FindCompany(int id);
        Company FindCompanyFilter(string Name);

    }
}
