using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NebsojiPVPTrainer.Models;
using NebsojiPVPTrainer.Services;

namespace NebsojiPVPTrainer
{
    public partial class Form1 : Form
    {
        private List<PokemonEntry> allPokemon = new();

        public Form1()
        {
            InitializeComponent();

            leagueDropdown.Items.Add("Great League");
            leagueDropdown.Items.Add("Master League");
            leagueDropdown.SelectedIndexChanged += OnLeagueChanged;
            leagueDropdown.SelectedIndex = 0;

            foreach (var cb in new[] { myTeam1, myTeam2, myTeam3, enemyTeam1, enemyTeam2, enemyTeam3 })
                cb.SelectedIndexChanged += (_, __) => RecalculateMatchups();

            resetMyTeamButton.Click += (_, __) => ResetMyTeam();
            resetEnemyTeamButton.Click += (_, __) => ResetEnemyTeam();
        }

        private void OnLeagueChanged(object? sender, EventArgs? e)
        {
            var dataDir = Path.Combine(Application.StartupPath, "Data");
            var dexPath = Path.Combine(dataDir, "pokemon.json");
            var movesFile = leagueDropdown.SelectedItem!.ToString() == "Master League"
                ? "move_sets_master_league.json"
                : "move_sets_great_league.json";
            var movesPath = Path.Combine(dataDir, movesFile);

            allPokemon = PokemonDataService.LoadPokemonEntries(dexPath, movesPath);

            object[] names = allPokemon
            .Select(p => p.Name!)
            .OrderBy(n => n)
            .Cast<object>()
            .ToArray();

            foreach (var cb in new[] { myTeam1, myTeam2, myTeam3, enemyTeam1, enemyTeam2, enemyTeam3 })
            {
                cb.Items.Clear();
                cb.Items.AddRange(names);
                cb.Text = "";
            }

            coverageBox.Clear();
            RecalculateMatchups();
        }

        private void ResetMyTeam()
        {
            myTeam1.Text = myTeam2.Text = myTeam3.Text = "";
            coverageBox.Clear();
        }

        private void ResetEnemyTeam()
        {
            enemyTeam1.Text = enemyTeam2.Text = enemyTeam3.Text = "";
            coverageBox.Clear();
        }

        private void RecalculateMatchups()
        {
            coverageBox.Clear();

            var myEntries = new[]
            {
                allPokemon.FirstOrDefault(p => p.Name == myTeam1.Text),
                allPokemon.FirstOrDefault(p => p.Name == myTeam2.Text),
                allPokemon.FirstOrDefault(p => p.Name == myTeam3.Text)
            }
            .Where(p => p is not null)
            .Cast<PokemonEntry>()
            .ToList();

            var enemyEntries = new[]
            {
                allPokemon.FirstOrDefault(p => p.Name == enemyTeam1.Text),
                allPokemon.FirstOrDefault(p => p.Name == enemyTeam2.Text),
                allPokemon.FirstOrDefault(p => p.Name == enemyTeam3.Text)
            }
            .Where(p => p is not null)
            .Cast<PokemonEntry>()
            .ToList();

            if (myEntries.Count < 3)
            {
                coverageBox.AppendText("Please select all 3 of your Pokémon.\n");
                return;
            }
            if (enemyEntries.Count < 1)
            {
                coverageBox.AppendText("Please select at least one enemy Pokémon.\n");
                return;
            }

            foreach (var defender in enemyEntries)
            {
                coverageBox.AppendText($"-- vs {defender.Name} --\n");
                foreach (var attacker in myEntries)
                {
                    var pct = MatchupCalculator.Calculate(attacker, defender);
                    string symbol = pct switch
                    {
                        >= 75 => "👍",
                        >= 60 => "👌",
                        >= 50 => "➖",
                        _ => "👎"
                    };

                    var movesText = (attacker.Defaults?.MoveTypes?.Count ?? 0) > 0
                        ? string.Join(", ", attacker.Defaults!.MoveTypes!)
                        : string.Join(", ", attacker.Types!);

                    var defenderTypesText = defender.Types != null
                        ? string.Join(", ", defender.Types)
                        : "unknown";

                    coverageBox.AppendText(
                        $"{attacker.Name} [{movesText}] vs {defender.Name} [{defenderTypesText}]: {pct:N0}% {symbol}\n"
                    );
                }
                coverageBox.AppendText(Environment.NewLine);
            }
        }
    }
}
