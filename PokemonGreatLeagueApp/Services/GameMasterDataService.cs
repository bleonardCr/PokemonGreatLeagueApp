using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public class MoveDef
    {
        [JsonProperty("moveId")]
        public string MoveId { get; set; } = null!;

        [JsonProperty("type")]
        public string Type { get; set; } = null!;

        [JsonProperty("power")]
        public int Power { get; set; }

        // energyDelta for quickMoves
        [JsonProperty("energyDelta")]
        public int? EnergyDelta { get; set; }

        // energyCost for chargedMoves
        [JsonProperty("energyCost")]
        public int? EnergyCost { get; set; }

        // unified energy value
        [JsonIgnore]
        public int Energy => EnergyDelta ?? EnergyCost ?? 0;

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }
    }

    public static class GameMasterDataService
    {
        private static JObject? _gm;

        /// <summary>
        /// Call once to load the huge gamemaster.json into memory.
        /// </summary>
        public static void Initialize(string gamemasterJsonPath)
        {
            var text = File.ReadAllText(gamemasterJsonPath);
            _gm = JObject.Parse(text);
        }

        /// <summary>
        /// All Pokémon entries (types, stats, defaults, etc.).
        /// </summary>
        public static List<PokemonEntry> DexEntries
            => _gm?["pokemon"]?.ToObject<List<PokemonEntry>>()
               ?? new List<PokemonEntry>();

        /// <summary>
        /// Full 18×18 type chart.
        /// </summary>
        public static Dictionary<string, Dictionary<string, double>> TypeChartData
            => _gm?["typeEffective"]?.ToObject<Dictionary<string, Dictionary<string, double>>>()
               ?? new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// All fast moves (quickMoves in JSON).
        /// </summary>
        public static List<MoveDef> FastMoveDefs
            => _gm?["quickMoves"]?.ToObject<List<MoveDef>>()
               ?? new List<MoveDef>();

        /// <summary>
        /// All charged moves.
        /// </summary>
        public static List<MoveDef> ChargedMoveDefs
            => _gm?["chargedMoves"]?.ToObject<List<MoveDef>>()
               ?? new List<MoveDef>();
    }
}
