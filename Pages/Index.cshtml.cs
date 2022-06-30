using Dsd602PizzaAsp.Model;
using Dsd602PizzaAsp.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsd602PizzaAsp.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public Pizza? pizza { get; set; }


        public bool FirstLoad { get; set; } = false;




        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                FirstLoad = true;
                pizza = Factory.GetAPizza(pizza.PizzaTypeSelected);
            }
            return Page();
        }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;


        }


        public void OnGet()
        {

        }
    }
}