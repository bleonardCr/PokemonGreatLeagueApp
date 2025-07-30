namespace LeagueJsonGenerator.Models
{
    public class PokemonEntry
    {
        public string Name { get; set; } = string.Empty;
        public string FastMove { get; set; } = string.Empty;
        public string ChargeMove1 { get; set; } = string.Empty;
        public string ChargeMove2 { get; set; } = string.Empty;
        public int CP { get; set; }
        public string League { get; set; } = string.Empty;
    }
}
