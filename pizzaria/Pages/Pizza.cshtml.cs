using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaria.Models;

namespace pizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<pizzasModel> FakePizzaDb = new List<pizzasModel> {
            
            new pizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", TomatoSauce=true, Cheese=true, FinalPrice=60},
            new pizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", TomatoSauce=true, Cheese=true, Ham=true, Pepperoni=true, FinalPrice=65},
            new pizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", TomatoSauce=true, Cheese=true, Pepperoni=true, FinalPrice=65}
        };
        public void OnGet()
        {
        }
    }
}
