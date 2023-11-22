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
        public DateTime DataAdaugarii { get; set; }

        
        public Stire(int id, string titlu, string lead, string continut, string autor, Categorie categoriee, int categorie, DateTime dataAdaugarii)
        {
            Id = id;
            Titlu = titlu;
            Lead = lead;
            Continut = continut;
            Autor = autor;
            Categorie = categoriee;
            CategorieId = categorie;
            DataAdaugarii = dataAdaugarii;
        }

        public Stire()
        {
            
        }
        
    }
}
