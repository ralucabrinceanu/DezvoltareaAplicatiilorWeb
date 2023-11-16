namespace LaboratorDAW.Models
{
    public class Stire
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Lead { get; set; }
        public string Continut { get; set; }
        public string Autor { get; set; }
        public Categorie Categorie { get; set; }
        public int CategorieId { get; set; }

        public Stire(int id, string titlu, string lead, string continut, string autor, int categorie)
        {
            Id = id;
            Titlu = titlu;
            Lead = lead;
            Continut = continut;
            Autor = autor;
            CategorieId = categorie;
        }

        public Stire()
        {
            
        }
    }
}
