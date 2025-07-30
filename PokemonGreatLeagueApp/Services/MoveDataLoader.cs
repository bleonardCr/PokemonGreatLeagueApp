using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public static class MoveDataLoader
    {
        public static List<PokemonMoveSet> LoadAll()
        {
            var json = File.ReadAllText("Data/pokemon.json");
            return JsonConvert.DeserializeObject<List<PokemonMoveSet>>(json);
        }
    }
}
