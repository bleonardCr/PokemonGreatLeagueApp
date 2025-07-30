using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PokemonGreatLeagueApp.Services;
using PokemonGreatLeagueApp.Models;

namespace PokemonGreatLeagueApp
{
    public partial class Form1 : Form
    {
        private ComboBox myTeam1 = null!;
        private ComboBox myTeam2 = null!;
        private ComboBox myTeam3 = null!;
        private ComboBox enemyTeam1 = null!;
        private ComboBox enemyTeam2 = null!;
        private ComboBox enemyTeam3 = null!;
        private RichTextBox coverageBox = null!;
        private ComboBox leagueDropdown = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnLeagueChanged(object? sender, EventArgs e)
        {
            string league = leagueDropdown.SelectedItem?.ToString() ?? "Great";
            var data = LeagueDataLoader.LoadLeague(league);

            myTeam1.DataSource = new List<PokemonEntry>(data);
            myTeam2.DataSource = new List<PokemonEntry>(data);
            myTeam3.DataSource = new List<PokemonEntry>(data);
            enemyTeam1.DataSource = new List<PokemonEntry>(data);
            enemyTeam2.DataSource = new List<PokemonEntry>(data);
            enemyTeam3.DataSource = new List<PokemonEntry>(data);
        }

        private void OnMatchupClicked(object? sender, EventArgs e)
        {
            var myTeam = new List<PokemonEntry>
            {
                (PokemonEntry)myTeam1.SelectedItem!,
                (PokemonEntry)myTeam2.SelectedItem!,
                (PokemonEntry)myTeam3.SelectedItem!
            };

            var enemyTeam = new List<PokemonEntry>
            {
                (PokemonEntry)enemyTeam1.SelectedItem!,
                (PokemonEntry)enemyTeam2.SelectedItem!,
                (PokemonEntry)enemyTeam3.SelectedItem!
            };

            string result = MatchupCalculator.Calculate(myTeam, enemyTeam);
            coverageBox.Text = result;
        }
    }
}
