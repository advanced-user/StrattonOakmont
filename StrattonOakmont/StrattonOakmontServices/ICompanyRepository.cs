using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    class ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }
    }
}
