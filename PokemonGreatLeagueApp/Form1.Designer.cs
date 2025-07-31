using System.ComponentModel;
using System.Windows.Forms;

namespace NebsojiPVPTrainer
{
    partial class Form1
    {
        private IContainer components = null!;
        private ComboBox leagueDropdown;
        private ComboBox myTeam1, myTeam2, myTeam3;
        private ComboBox enemyTeam1, enemyTeam2, enemyTeam3;
        private RichTextBox coverageBox;
        private Button resetMyTeamButton, resetEnemyTeamButton;

        private void InitializeComponent()
        {
            this.leagueDropdown = new ComboBox();
            this.myTeam1 = new ComboBox();
            this.myTeam2 = new ComboBox();
            this.myTeam3 = new ComboBox();
            this.enemyTeam1 = new ComboBox();
            this.enemyTeam2 = new ComboBox();
            this.enemyTeam3 = new ComboBox();
            this.coverageBox = new RichTextBox();
            this.resetMyTeamButton = new Button();
            this.resetEnemyTeamButton = new Button();

            // leagueDropdown
            this.leagueDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            this.leagueDropdown.Location = new System.Drawing.Point(20, 20);
            this.leagueDropdown.Size = new System.Drawing.Size(150, 23);

            // myTeam1,2,3
            foreach (var cb in new[] { myTeam1, myTeam2, myTeam3 })
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Size = new System.Drawing.Size(150, 23);
            }
            myTeam1.Location = new System.Drawing.Point(20, 60);
            myTeam2.Location = new System.Drawing.Point(20, 100);
            myTeam3.Location = new System.Drawing.Point(20, 140);

            // enemyTeam1,2,3
            foreach (var cb in new[] { enemyTeam1, enemyTeam2, enemyTeam3 })
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Size = new System.Drawing.Size(150, 23);
            }
            enemyTeam1.Location = new System.Drawing.Point(240, 60);
            enemyTeam2.Location = new System.Drawing.Point(240, 100);
            enemyTeam3.Location = new System.Drawing.Point(240, 140);

            // coverageBox (increased height)
            this.coverageBox.Location = new System.Drawing.Point(20, 200);
            this.coverageBox.Size = new System.Drawing.Size(370, 200);

            // resetMyTeamButton
            this.resetMyTeamButton.Text = "Reset My Team";
            this.resetMyTeamButton.Location = new System.Drawing.Point(20, 420);
            this.resetMyTeamButton.Size = new System.Drawing.Size(120, 30);

            // resetEnemyTeamButton
            this.resetEnemyTeamButton.Text = "Reset Enemy";
            this.resetEnemyTeamButton.Location = new System.Drawing.Point(250, 420);
            this.resetEnemyTeamButton.Size = new System.Drawing.Size(120, 30);

            // Form1
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.leagueDropdown);
            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.myTeam2);
            this.Controls.Add(this.myTeam3);
            this.Controls.Add(this.enemyTeam1);
            this.Controls.Add(this.enemyTeam2);
            this.Controls.Add(this.enemyTeam3);
            this.Controls.Add(this.coverageBox);
            this.Controls.Add(this.resetMyTeamButton);
            this.Controls.Add(this.resetEnemyTeamButton);
            this.Name = "Form1";
            this.Text = "Nebsoji PvP Trainer";

            this.ResumeLayout(false);
        }
    }
}
