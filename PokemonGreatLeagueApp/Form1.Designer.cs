namespace NebsojiPVPTrainer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox leagueDropdown;
        private System.Windows.Forms.ComboBox myTeam1;
        private System.Windows.Forms.ComboBox myTeam2;
        private System.Windows.Forms.ComboBox myTeam3;
        private System.Windows.Forms.ComboBox enemyTeam1;
        private System.Windows.Forms.ComboBox enemyTeam2;
        private System.Windows.Forms.ComboBox enemyTeam3;
        private System.Windows.Forms.RichTextBox coverageBox;
        private System.Windows.Forms.Button resetMyTeamButton;
        private System.Windows.Forms.Button resetEnemyTeamButton;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.CheckBox myShield1;
        private System.Windows.Forms.CheckBox myShield2;
        private System.Windows.Forms.CheckBox enemyShield1;
        private System.Windows.Forms.CheckBox enemyShield2;

        private void InitializeComponent()
        {
            this.leagueDropdown = new System.Windows.Forms.ComboBox();
            this.myTeam1 = new System.Windows.Forms.ComboBox();
            this.myTeam2 = new System.Windows.Forms.ComboBox();
            this.myTeam3 = new System.Windows.Forms.ComboBox();
            this.enemyTeam1 = new System.Windows.Forms.ComboBox();
            this.enemyTeam2 = new System.Windows.Forms.ComboBox();
            this.enemyTeam3 = new System.Windows.Forms.ComboBox();
            this.coverageBox = new System.Windows.Forms.RichTextBox();
            this.resetMyTeamButton = new System.Windows.Forms.Button();
            this.resetEnemyTeamButton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.myShield1 = new System.Windows.Forms.CheckBox();
            this.myShield2 = new System.Windows.Forms.CheckBox();
            this.enemyShield1 = new System.Windows.Forms.CheckBox();
            this.enemyShield2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            // leagueDropdown
            this.leagueDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueDropdown.Location = new System.Drawing.Point(20, 20);
            this.leagueDropdown.Size = new System.Drawing.Size(150, 23);

            // myTeam1
            this.myTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam1.Location = new System.Drawing.Point(20, 60);
            this.myTeam1.Size = new System.Drawing.Size(150, 23);

            // myTeam2
            this.myTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam2.Location = new System.Drawing.Point(20, 100);
            this.myTeam2.Size = new System.Drawing.Size(150, 23);

            // myTeam3
            this.myTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam3.Location = new System.Drawing.Point(20, 140);
            this.myTeam3.Size = new System.Drawing.Size(150, 23);

            // enemyTeam1
            this.enemyTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam1.Location = new System.Drawing.Point(200, 60);
            this.enemyTeam1.Size = new System.Drawing.Size(150, 23);

            // enemyTeam2
            this.enemyTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam2.Location = new System.Drawing.Point(200, 100);
            this.enemyTeam2.Size = new System.Drawing.Size(150, 23);

            // enemyTeam3
            this.enemyTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam3.Location = new System.Drawing.Point(200, 140);
            this.enemyTeam3.Size = new System.Drawing.Size(150, 23);

            // myShield1
            this.myShield1.Text = "My Shield 1";
            this.myShield1.Location = new System.Drawing.Point(20, 180);
            this.myShield1.AutoSize = true;

            // myShield2
            this.myShield2.Text = "My Shield 2";
            this.myShield2.Location = new System.Drawing.Point(20, 210);
            this.myShield2.AutoSize = true;

            // enemyShield1
            this.enemyShield1.Text = "Enemy Shield 1";
            this.enemyShield1.Location = new System.Drawing.Point(200, 180);
            this.enemyShield1.AutoSize = true;

            // enemyShield2
            this.enemyShield2.Text = "Enemy Shield 2";
            this.enemyShield2.Location = new System.Drawing.Point(200, 210);
            this.enemyShield2.AutoSize = true;

            // coverageBox
            this.coverageBox.Location = new System.Drawing.Point(20, 250);
            this.coverageBox.Size = new System.Drawing.Size(330, 120);

            // resetMyTeamButton
            this.resetMyTeamButton.Text = "Reset My Team";
            this.resetMyTeamButton.Location = new System.Drawing.Point(20, 390);
            this.resetMyTeamButton.Size = new System.Drawing.Size(100, 30);

            // resetEnemyTeamButton
            this.resetEnemyTeamButton.Text = "Reset Enemy";
            this.resetEnemyTeamButton.Location = new System.Drawing.Point(130, 390);
            this.resetEnemyTeamButton.Size = new System.Drawing.Size(100, 30);

            // resetAllButton
            this.resetAllButton.Text = "Reset All";
            this.resetAllButton.Location = new System.Drawing.Point(240, 390);
            this.resetAllButton.Size = new System.Drawing.Size(100, 30);

            // Form1
            this.ClientSize = new System.Drawing.Size(380, 440);
            this.Controls.Add(this.leagueDropdown);
            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.myTeam2);
            this.Controls.Add(this.myTeam3);
            this.Controls.Add(this.enemyTeam1);
            this.Controls.Add(this.enemyTeam2);
            this.Controls.Add(this.enemyTeam3);
            this.Controls.Add(this.myShield1);
            this.Controls.Add(this.myShield2);
            this.Controls.Add(this.enemyShield1);
            this.Controls.Add(this.enemyShield2);
            this.Controls.Add(this.coverageBox);
            this.Controls.Add(this.resetMyTeamButton);
            this.Controls.Add(this.resetEnemyTeamButton);
            this.Controls.Add(this.resetAllButton);
            this.Name = "Form1";
            this.Text = "Nebsoji PvP Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
