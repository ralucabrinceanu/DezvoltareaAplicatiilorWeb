using LaboratorDAW.ContextModels;
using LaboratorDAW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LaboratorDAW.Pages
{
    public class EditeazaStireModel : PageModel
    {
        [BindProperty]
        public Stire Stire { get; set; }
        public List<SelectListItem> categorie {  get; set; }
        private readonly StiriContext _stiriContext;

        public EditeazaStireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
            categorie = _stiriContext.Categorie.Select(x =>
                new SelectListItem { Text = x.Nume, Value = x.Id.ToString()}).ToList();
    
        }

        public void OnGet(int id)
        {
            Stire = _stiriContext.Stire.FirstOrDefault(s => s.Id == id);
        }

        public IActionResult OnPost()
        {
            _stiriContext.Update(Stire);
            _stiriContext.SaveChanges();
            return RedirectToPage("index");
        }
    }
}
