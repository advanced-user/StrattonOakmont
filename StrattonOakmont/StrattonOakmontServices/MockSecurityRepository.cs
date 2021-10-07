using StrattonOakmontModels;
using StrattonOakmontServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StrattonOakmontServices
{
    public class MockSecurityRepository : ISecurityRepository
    {
        private List<Security> _securitiesList;

        private readonly ICategoryRepository _categorySec = new MockCategoryRepository();
        private readonly ICompanyRepository _companySec = new MockCompanyRepository();
        public IEnumerable<Security> AllSecurities
        {
            get
            {
                return new List<Security>
                {
                    new Security
                    {
                        Id = 1,
                        Price = 1000,
                        PerSent = 0,
                        CompanySec = _companySec.GetAllCompanies.First(),
                        CategorySec = _categorySec.GetAllCategories.First(),                       
                        CompanyIMG = _companySec.GetAllCompanies.First().IMG
                    },
                    new Security
                    {
                        Id = 2,
                        Price = 3000,
                        PerSent = 0,
                        CompanySec = _companySec.GetAllCompanies.Last(),
                        CategorySec = _categorySec.GetAllCategories.First(),
                        CompanyIMG = _companySec.GetAllCompanies.Last().IMG
                    }

                };
            }
        }

        
        public IEnumerable<Security> GetAllSecurities()
        {
            return AllSecurities;
        }
    }
}
