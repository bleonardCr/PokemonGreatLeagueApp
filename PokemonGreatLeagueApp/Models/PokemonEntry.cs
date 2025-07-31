using System.Collections.Generic;
using Newtonsoft.Json;

namespace NebsojiPVPTrainer.Models
{
    public class PokemonEntry
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("types")]
        public List<string>? Types { get; set; }

        [JsonProperty("stats")]
        public Stats? Stats { get; set; }

        [JsonProperty("defaults")]
        public EntryDefaults? Defaults { get; set; }

        // added for moveset merging
        public string? FastMove { get; set; }
        public List<string>? ChargedMoves { get; set; }
    }
}
