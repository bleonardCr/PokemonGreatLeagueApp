using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public static class MoveDataLoader
    {
        private static readonly List<PokemonMoveSet> GreatMoves =
            JsonSerializer.Deserialize<List<PokemonMoveSet>>(File.ReadAllText("Data/great_league_moves.json"))!
            ?? new List<PokemonMoveSet>();

        private static readonly List<PokemonMoveSet> MasterMoves =
            JsonSerializer.Deserialize<List<PokemonMoveSet>>(File.ReadAllText("Data/master_league_moves.json"))!
            ?? new List<PokemonMoveSet>();

        public static PokemonMoveSet GetMoveSet(string speciesId)
        {
            return GreatMoves
                .Concat(MasterMoves)
                .FirstOrDefault(m => m.SpeciesId == speciesId)
                ?? new PokemonMoveSet { SpeciesId = speciesId, FastMove = "", ChargedMoves = new() };
        }
    }
}
