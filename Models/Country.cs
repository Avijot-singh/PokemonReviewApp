namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; } // A country has a collection of owners who belong to it 
    }
}
