using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaria.Models;

namespace pizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        public pizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Pizza.BasePrice = 50;
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 5;
            if (Pizza.Cheese) PizzaPrice += 5;
            if (Pizza.Pepperoni) PizzaPrice += 10;
            if (Pizza.Mushroom) PizzaPrice += 6;
            if (Pizza.Pineapple) PizzaPrice += 7;
            if (Pizza.Ham) PizzaPrice += 15;
            if (Pizza.Beef) PizzaPrice += 18;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice });
        }
    }
}
