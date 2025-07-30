using System;
using System.IO;
using System.Text.Json;

namespace LeagueJsonGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var leagues = new
            {
                GreatLeague = new
                {
                    MaxCP = 1500,
                    Pokemon = new[]
                    {
                        "Azumarill",
                        "Altaria",
                        "Skarmory",
                        "Bastiodon",
                        "Medicham",
                        "Umbreon",
                        "Stunfisk (Galarian)",
                        "Trevenant",
                        "Lanturn"
                    }
                },
                UltraLeague = new
                {
                    MaxCP = 2500,
                    Pokemon = new[]
                    {
                        "Giratina (Altered)",
                        "Cresselia",
                        "Swampert",
                        "Registeel",
                        "Obstagoon",
                        "Charizard",
                        "Talonflame",
                        "Walrein"
                    }
                },
                MasterLeague = new
                {
                    MaxCP = 9999,
                    Pokemon = new[]
                    {
                        "Dialga",
                        "Mewtwo",
                        "Zacian",
                        "Kyogre",
                        "Groudon",
                        "Lugia",
                        "Dragonite",
                        "Yveltal",
                        "Garchomp"
                    }
                }
            };

            // Convert to JSON
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(leagues, options);

            // Ensure Data folder exists
            var dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            Directory.CreateDirectory(dataDir);

            // Save file
            var filePath = Path.Combine(dataDir, "leagues.json");
            File.WriteAllText(filePath, json);

            Console.WriteLine($"leagues.json generated at: {filePath}");
        }
    }
}
