using System;
using System.Collections.Generic;
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
            leagueDropdown.SelectedIndexChanged += LeagueDropdown_SelectedIndexChanged;
            leagueDropdown.SelectedIndex = 0;

            resetMyTeamButton.Click += (s, e) =>
            {
                myTeam1.SelectedIndex = -1;
                myTeam2.SelectedIndex = -1;
                myTeam3.SelectedIndex = -1;
            };

            resetEnemyTeamButton.Click += (s, e) =>
            {
                enemyTeam1.SelectedIndex = -1;
                enemyTeam2.SelectedIndex = -1;
                enemyTeam3.SelectedIndex = -1;
            };

            resetAllButton.Click += (s, e) =>
            {
                myTeam1.SelectedIndex = -1;
                myTeam2.SelectedIndex = -1;
                myTeam3.SelectedIndex = -1;
                enemyTeam1.SelectedIndex = -1;
                enemyTeam2.SelectedIndex = -1;
                enemyTeam3.SelectedIndex = -1;
                coverageBox.Clear();
            };

            // Trigger initial load
            LeagueDropdown_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void LeagueDropdown_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var league = leagueDropdown.SelectedItem as string == "Master League"
                ? "master_league" : "great_league";

            allPokemon = LeagueDataLoader.LoadLeague(league);

            myTeam1.Items.Clear();
            myTeam2.Items.Clear();
            myTeam3.Items.Clear();
            enemyTeam1.Items.Clear();
            enemyTeam2.Items.Clear();
            enemyTeam3.Items.Clear();

            foreach (var p in allPokemon)
            {
                myTeam1.Items.Add(p.Name);
                myTeam2.Items.Add(p.Name);
                myTeam3.Items.Add(p.Name);
                enemyTeam1.Items.Add(p.Name);
                enemyTeam2.Items.Add(p.Name);
                enemyTeam3.Items.Add(p.Name);
            }
        }
    }
}
