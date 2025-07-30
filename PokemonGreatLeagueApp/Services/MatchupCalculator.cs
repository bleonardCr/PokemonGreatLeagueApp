using NebsojiPVPTrainer.Models;
using PokemonGreatLeagueApp.Models;
using System.Collections.Generic;

namespace PokemonGreatLeagueApp.Services
{
    public class MatchupCalculator
    {
        public string Calculate(PokemonEntry myPokemon, PokemonEntry enemyPokemon)
        {
            // super simple logic placeholder
            if (myPokemon.Type1 == enemyPokemon.Type1) return "Draw";
            return "Win/Lose logic placeholder";
        }
    }
}
