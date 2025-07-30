using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using PokemonGreatLeagueApp.Models;

namespace PokemonGreatLeagueApp.Services
{
    public static class LeagueDataLoader
    {
        public static List<PokemonEntry> LoadGreatLeague()
            => Load("Data/great_league.json");

        public static List<PokemonEntry> LoadMasterLeague()
            => Load("Data/master_league.json");

        public static List<PokemonEntry> LoadLeague(string league)
        {
            return league switch
            {
                "Great" => LoadGreatLeague(),
                "Master" => LoadMasterLeague(),
                _ => new List<PokemonEntry>()
            };
        }

        private static List<PokemonEntry> Load(string path)
        {
            if (!File.Exists(path))
                return new List<PokemonEntry>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<PokemonEntry>>(json)
                   ?? new List<PokemonEntry>();
        }
    }
}
