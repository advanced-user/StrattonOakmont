using StrattonOakmontModels;
using StrattonOakmontServices;
using System;
using System.Collections.Generic;
using System.Text;


namespace StrattonOakmontServices
{
    public class MockSecurityRepository : ISecurityRepository
    {
        private List<Security> _securitiesList;
        public MockSecurityRepository()
        {
            _securitiesList = new List<Security>()
            {
                new Security
                {
                    Id = 1,
                    Price = 1000,
                    PerSent = 0,
                    //CompanySec = "Google",
                   

                }        
            };
        }
        public IEnumerable<Security> GetAllSecurities()
        {
            throw new NotImplementedException();
        }
    }
}
