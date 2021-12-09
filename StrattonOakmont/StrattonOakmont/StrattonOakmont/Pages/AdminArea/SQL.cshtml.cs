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

        [BindProperty]
        public string Smile { get; set; }

        public void OnGet()
        {
            Data = new DataSet();
            Query = "SELECT";
            Smile = "";
        }

        public void OnPost()
        {
            try
            {
                Data = _sqlRepository.DoSql(Query);
                Smile = "/admin/IMG/right.gif";
            }
            catch
            {
                Smile = "/admin/IMG/not_right.gif";
            }
        }
    }
}
