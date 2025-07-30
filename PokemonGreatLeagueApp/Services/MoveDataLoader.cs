using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using PokemonGreatLeagueApp.Models;

namespace PokemonGreatLeagueApp.Services
{
    public class MoveDataLoader
    {
        public List<PokemonMoveSet> LoadMoveSets(string filePath)
        {
            if (!File.Exists(filePath)) return new List<PokemonMoveSet>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<PokemonMoveSet>>(json) ?? new List<PokemonMoveSet>();
        }
    }
}
