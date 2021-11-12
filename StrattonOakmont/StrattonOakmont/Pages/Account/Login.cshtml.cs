using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrattonOakmontModels;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StrattonOakmont.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;

        public LoginModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }

            public string ReturnUrl { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(Input.ReturnUrl) && Url.IsLocalUrl(Input.ReturnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToPage("/Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "������������ ����� � (���) ������");
                }
            }
            return Page();
        }
    }
}
