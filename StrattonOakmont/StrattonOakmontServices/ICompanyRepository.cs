using StrattonOakmontModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontServices
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies { get; }
    }
}
