using System.Windows.Forms;

namespace PokemonGreatLeagueApp
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.myTeam1 = new ComboBox();
            this.myTeam2 = new ComboBox();
            this.myTeam3 = new ComboBox();
            this.enemyTeam1 = new ComboBox();
            this.enemyTeam2 = new ComboBox();
            this.enemyTeam3 = new ComboBox();
            this.coverageBox = new RichTextBox();
            this.leagueDropdown = new ComboBox();

            this.SuspendLayout();

            // leagueDropdown
            this.leagueDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            this.leagueDropdown.SelectedIndexChanged += LeagueDropdown_SelectedIndexChanged;

            // coverageBox
            this.coverageBox.Location = new System.Drawing.Point(20, 200);
            this.coverageBox.Size = new System.Drawing.Size(400, 200);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.myTeam2);
            this.Controls.Add(this.myTeam3);
            this.Controls.Add(this.enemyTeam1);
            this.Controls.Add(this.enemyTeam2);
            this.Controls.Add(this.enemyTeam3);
            this.Controls.Add(this.leagueDropdown);
            this.Controls.Add(this.coverageBox);
            this.Name = "Form1";
            this.Text = "Pokemon PVP Trainer";

            this.ResumeLayout(false);
        }
    }
}
