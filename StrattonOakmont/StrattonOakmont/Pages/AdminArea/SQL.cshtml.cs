using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using StrattonOakmontServices.Interfaces;
using System.Data;
using System.Data.Common;

namespace StrattonOakmont.Pages.AdminArea
{
    public class SQLModel : PageModel
    {
        private readonly ISQLRepository _sqlRepository;

        public SQLModel(ISQLRepository sQLRepository)
        {
            _sqlRepository = sQLRepository;
        }


        [BindProperty]
        public string Query { get; set; }

        [BindProperty]
        public DataSet Data { get; set; }

        public void OnGet()
        {
            Data = new DataSet();
        }

        public void OnPost()
        {
            try
            {
                Data = _sqlRepository.DoSql(Query);
            }
            catch
            {

            }
        }
    }
}
