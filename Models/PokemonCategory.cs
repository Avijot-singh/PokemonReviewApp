namespace PokemonReviewApp.Models
{
    public class PokemonCategory
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
