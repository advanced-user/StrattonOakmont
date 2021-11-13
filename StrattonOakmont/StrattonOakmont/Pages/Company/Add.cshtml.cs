using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontServices;

namespace StrattonOakmont.Pages.Company
{

    [Authorize(Roles = "admin")]
    public class AddModel : PageModel
    {
        private readonly ICompanyRepository _dbCompany;

        public AddModel(ICompanyRepository dbCompany)
        {
            _dbCompany = dbCompany;
        }

        [BindProperty]
        public StrattonOakmontModels.Company Company { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(Company != null)
			{
                _dbCompany.AddCompany(Company);
			}

            return RedirectToPage("Index");
        }
    }
}
