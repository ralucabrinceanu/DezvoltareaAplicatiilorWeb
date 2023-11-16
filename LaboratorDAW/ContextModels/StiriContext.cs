using LaboratorDAW.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorDAW.ContextModels
{
    public class StiriContext : DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options) : base(options) { }
        
        public DbSet<Stire> Stire {  get; set; }
        public DbSet<Categorie> Categorie { get; set; }
    }
}
