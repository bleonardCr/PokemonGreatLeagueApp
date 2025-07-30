using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public static class LeagueDataLoader
    {
        public static List<PokemonEntry> LoadLeague(string leagueKey)
        {
            string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", $"{leagueKey}.json");

            if (!File.Exists(dataPath))
            {
                throw new FileNotFoundException($"Missing {leagueKey}.json in Data folder.");
            }

            string json = File.ReadAllText(dataPath);
            return JsonSerializer.Deserialize<List<PokemonEntry>>(json) ?? new List<PokemonEntry>();
        }
    }
}
