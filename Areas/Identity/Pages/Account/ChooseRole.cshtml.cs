// ChooseRole.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeavyGo_Project_Identity.Areas.Identity.Pages.Account
{
    public class ChooseRoleModel : PageModel
    {
        [BindProperty]
        public string Role { get; set; }

        public void OnGet()
        {
            // Default role if needed
            Role = "Client";
        }

        public IActionResult OnPost()
        {
            if (Role == "Client")
                return RedirectToPage("/Account/Register", new { area = "Identity", role = "Client" });
            else if (Role == "Driver")
                return RedirectToPage("/Account/Register", new { area = "Identity", role = "Driver" });

            return Page();
        }
    }
}
