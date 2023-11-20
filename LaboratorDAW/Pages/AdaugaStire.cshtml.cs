using LaboratorDAW.ContextModels;
using LaboratorDAW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LaboratorDAW.Pages
{
    public class AdaugaStireModel : PageModel
    {
        [BindProperty]
        public Stire Stire { get; set; } = new Stire();
        public List<SelectListItem> categorie {  get; set; }
        private readonly StiriContext _stiriContext;

        public AdaugaStireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
            categorie = _stiriContext.Categorie.Select(x => 
                new SelectListItem { Text = x.Nume, Value = x.Id.ToString() }).ToList();

        }

        public IActionResult OnPost()
        {
            _stiriContext.Add(Stire);
            _stiriContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
