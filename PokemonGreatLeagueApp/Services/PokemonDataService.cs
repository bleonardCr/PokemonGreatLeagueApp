using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public static class PokemonDataService
    {
        /// <summary>
        /// Loads pokemon.json (with types + defaults) and merges in the moveset JSON.
        /// </summary>
        public static List<PokemonEntry> LoadPokemonEntries(string dexJsonPath, string movesJsonPath)
        {
            // 1) Read and parse the root object, then pull out the "pokemon" array
            var dexText = File.ReadAllText(dexJsonPath);
            var dexRoot = JsonConvert.DeserializeObject<JObject>(dexText)
                          ?? new JObject();
            var dexList = dexRoot["pokemon"]?
                          .ToObject<List<PokemonEntry>>()
                          ?? new List<PokemonEntry>();

            // 2) Load the movesets
            var movesText = File.ReadAllText(movesJsonPath);
            var moveList = JsonConvert
                .DeserializeObject<List<PokemonMoveSet>>(movesText)
                ?? new List<PokemonMoveSet>();

            // 3) Index movesets by speciesId for fast lookup
            var moveMap = moveList
                .GroupBy(m => m.SpeciesId, System.StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.First(), System.StringComparer.OrdinalIgnoreCase);

            // 4) Merge moves into dex entries
            foreach (var dex in dexList)
            {
                if (dex.Id != null && moveMap.TryGetValue(dex.Id, out var ms))
                {
                    dex.FastMove = ms.FastMove;
                    dex.ChargedMoves = ms.ChargedMoves;
                }
                else
                {
                    dex.FastMove = null;
                    dex.ChargedMoves = new List<string>();
                }
            }

            return dexList;
        }
    }
}
