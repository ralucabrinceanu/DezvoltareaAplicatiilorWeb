using LaboratorDAW.ContextModels;
using LaboratorDAW.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Security;

namespace LaboratorDAW.Pages
{
    public class StergereModel : PageModel
    {
        [BindProperty]
        public Stire Stire { get; set; }
        [TempData]
        public string ConfirmareMesaj { get; set; }

        private readonly StiriContext _stiriContext;

        public StergereModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }

        public IActionResult OnGet(int id, string userConfirmare)
        {
            Stire = _stiriContext.Stire.FirstOrDefault(s => s.Id == id);

            if (userConfirmare == "true")
            {
                _stiriContext.Remove(Stire);
                _stiriContext.SaveChanges();
            }

            return Page();   
        }

    }
}
