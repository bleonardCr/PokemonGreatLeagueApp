namespace PokemonGreatLeagueApp.Models
{
    public class PokemonEntry
    {
        public string Name { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string? Type2 { get; set; }
        public int CP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
    }
}
