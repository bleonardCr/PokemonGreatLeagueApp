using System.Collections.Generic;
using PokemonGreatLeagueApp.Models;

namespace PokemonGreatLeagueApp.Services
{
    public static class MatchupCalculator
    {
        public static string Calculate(List<PokemonEntry> myTeam, List<PokemonEntry> enemyTeam)
        {
            if (myTeam == null || enemyTeam == null || myTeam.Count == 0 || enemyTeam.Count == 0)
                return "No matchup available";

            return "Draw";
        }
    }
}
