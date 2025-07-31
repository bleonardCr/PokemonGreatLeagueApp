using System.Collections.Generic;
using Newtonsoft.Json;

namespace NebsojiPVPTrainer.Models
{
    public class PokemonMoveSet
    {
        [JsonProperty("speciesId")]
        public string SpeciesId { get; set; } = null!;

        [JsonProperty("fastMove")]
        public string FastMove { get; set; } = null!;

        [JsonProperty("chargedMoves")]
        public List<string> ChargedMoves { get; set; } = new();
    }
}
