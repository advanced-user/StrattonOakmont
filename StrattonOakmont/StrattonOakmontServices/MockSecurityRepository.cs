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

        public Security GetSecurity(int Id)
        {
            return AllSecurities.FirstOrDefault(x => x.Id == Id);
        }

        public Security Update(Security UpdatedSecurity)
        {
            Security security = AllSecurities.FirstOrDefault(x => x.Id == UpdatedSecurity.Id);
            if (security != null)
            {
                security.Price = UpdatedSecurity.Price;
                security.PerSent = UpdatedSecurity.PerSent;
            }
            return security;
        }

        public Security Add(Security NewSecurity)
        {
            NewSecurity.Id = AllSecurities.Max(x => x.Id) + 1;
            

            return NewSecurity;
        }
    }
}
