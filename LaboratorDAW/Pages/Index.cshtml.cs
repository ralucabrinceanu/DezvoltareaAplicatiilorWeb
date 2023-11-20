using LaboratorDAW.ContextModels;
using LaboratorDAW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LaboratorDAW.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StiriContext _stiriContext;
        public List<Stire> stiri {  get; set; }

        public IndexModel(ILogger<IndexModel> logger, StiriContext stiriContext) 
        {
            _logger = logger;
            _stiriContext = stiriContext;
        }

        public void OnGet()
        {
            stiri = _stiriContext.Stire.ToList();
        }
    }
}