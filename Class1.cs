namespace PokemonGreatLeagueApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
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

            this.SuspendLayout();
            // 
            // myTeam1
            // 
            this.myTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam1.Location = new System.Drawing.Point(30, 30);
            this.myTeam1.Size = new System.Drawing.Size(150, 21);
            // 
            // myTeam2
            // 
            this.myTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam2.Location = new System.Drawing.Point(30, 70);
            this.myTeam2.Size = new System.Drawing.Size(150, 21);
            // 
            // myTeam3
            // 
            this.myTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myTeam3.Location = new System.Drawing.Point(30, 110);
            this.myTeam3.Size = new System.Drawing.Size(150, 21);
            // 
            // enemyTeam1
            // 
            this.enemyTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam1.Location = new System.Drawing.Point(250, 30);
            this.enemyTeam1.Size = new System.Drawing.Size(150, 21);
            // 
            // enemyTeam2
            // 
            this.enemyTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam2.Location = new System.Drawing.Point(250, 70);
            this.enemyTeam2.Size = new System.Drawing.Size(150, 21);
            // 
            // enemyTeam3
            // 
            this.enemyTeam3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyTeam3.Location = new System.Drawing.Point(250, 110);
            this.enemyTeam3.Size = new System.Drawing.Size(150, 21);
            // 
            // coverageBox
            // 
            this.coverageBox.Location = new System.Drawing.Point(30, 160);
            this.coverageBox.Size = new System.Drawing.Size(370, 200);
            this.coverageBox.ReadOnly = true;
            this.coverageBox.Font = new System.Drawing.Font("Consolas", 9F);
            // 
            // resetMyTeamButton
            // 
            this.resetMyTeamButton.Text = "Reset My Team";
            this.resetMyTeamButton.Location = new System.Drawing.Point(30, 380);
            this.resetMyTeamButton.Click += new System.EventHandler(this.ResetMyTeam_Click);
            // 
            // resetEnemyTeamButton
            // 
            this.resetEnemyTeamButton.Text = "Reset Enemy Team";
            this.resetEnemyTeamButton.Location = new System.Drawing.Point(150, 380);
            this.resetEnemyTeamButton.Click += new System.EventHandler(this.ResetEnemyTeam_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Text = "Reset All";
            this.resetAllButton.Location = new System.Drawing.Point(300, 380);
            this.resetAllButton.Click += new System.EventHandler(this.ResetAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.myTeam2);
            this.Controls.Add(this.myTeam3);
            this.Controls.Add(this.enemyTeam1);
            this.Controls.Add(this.enemyTeam2);
            this.Controls.Add(this.enemyTeam3);
            this.Controls.Add(this.coverageBox);
            this.Controls.Add(this.resetMyTeamButton);
            this.Controls.Add(this.resetEnemyTeamButton);
            this.Controls.Add(this.resetAllButton);
            this.Text = "Pokémon GO Team Coverage Tool";
            this.ResumeLayout(false);
        }
        #endregion
    }
}
