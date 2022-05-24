using Dsd602PizzaAsp.Model;
using Dsd602PizzaAsp.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dsd602PizzaAsp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public Pizza? pizza { get; set; }


        public List<SelectListItem> PizzaTypesList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Hawaiian" },
            new SelectListItem { Value = "2", Text = "Margherita" },
            new SelectListItem { Value = "3", Text = "Salmon"  },
        };



        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;


        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                pizza = Factory.GetAPizza(pizza.PizzaType);



            }
            return Page();
        }





        public void OnGet()
        {

        }
    }
}