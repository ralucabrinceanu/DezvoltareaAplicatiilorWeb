using LaboratorDAW.ContextModels;
using LaboratorDAW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LaboratorDAW.Pages
{
    public class StireModel : PageModel
    {
        public Stire stire;

        private readonly StiriContext _stiriContext;
       
        public StireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }

        public IActionResult OnGet(int stireId)
        {
            stire = _stiriContext.Stire.Find(stireId);

            if(stire == null)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }
    }
}
