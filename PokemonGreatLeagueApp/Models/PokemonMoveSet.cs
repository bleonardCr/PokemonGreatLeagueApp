namespace PokemonGreatLeagueApp.Models
{
    public class PokemonMoveSet
    {
        public string PokemonName { get; set; } = string.Empty;
        public string FastMove { get; set; } = string.Empty;
        public string ChargedMove1 { get; set; } = string.Empty;
        public string? ChargedMove2 { get; set; }
    }
}
