namespace NebsojiPVPTrainer.Models
{
    public class PokemonEntry
    {
        public string Name { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string? Type2 { get; set; }   // optional secondary type
    }
}
