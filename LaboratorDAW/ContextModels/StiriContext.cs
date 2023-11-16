using LaboratorDAW.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace LaboratorDAW.ContextModels
{
    public class StiriContext : DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options) : base(options) { }
        
        public DbSet<Stire> Stire {  get; set; }
        public DbSet<Categorie> Categorie { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stire>()
                .HasOne(s => s.Categorie)
                .WithMany(c => c.Stiri)
                .HasForeignKey(s => s.CategorieId);
        }
       
    }
}
