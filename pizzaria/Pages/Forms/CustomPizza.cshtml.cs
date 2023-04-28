using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaria.Models;

namespace pizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        public pizzasModel Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
