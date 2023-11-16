namespace LaboratorDAW.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public Categorie(int id, string nume)
        {
            Id = id;
            Nume = nume;
        }
    }
}
