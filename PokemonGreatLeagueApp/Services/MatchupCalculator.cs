using System.Collections.Generic;
using System.Linq;
using NebsojiPVPTrainer.Models;

namespace NebsojiPVPTrainer.Services
{
    public static class MatchupCalculator
    {
        public static double Calculate(PokemonEntry attacker, PokemonEntry defender)
        {
            var atkTypes = (attacker.Defaults?.MoveTypes?.Any() == true)
                ? attacker.Defaults!.MoveTypes!
                : attacker.Types ?? new List<string>();

            var defTypes = defender.Types ?? new List<string>();

            var multiplier = TypeChart.GetMultiplier(atkTypes, defTypes);
            return multiplier * 100.0;
        }
    }
}
