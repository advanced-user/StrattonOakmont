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
                        //CompanySec = "Google",
                        CategorySec = _categorySec.GetAllCategories.First()
                    }

                };
            }
        }

        //public MockSecurityRepository()
        //{
        //    _securitiesList = new List<Security>()
        //    {
        //        new Security
        //        {
        //            Id = 1,
        //            Price = 1000,
        //            PerSent = 0,
        //            //CompanySec = "Google",
        //            CategorySec = _categorySec.GetAllCategories

        //        }        
        //    };
        //}
        public IEnumerable<Security> GetAllSecurities()
        {
            throw new NotImplementedException();
        }
    }
}
