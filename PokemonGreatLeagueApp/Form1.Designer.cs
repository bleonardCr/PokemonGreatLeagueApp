using System.ComponentModel;
using System.Drawing;
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

        // only two shields per team now
        private Label lblMyTeam, lblEnemyTeam;
        private CheckBox shieldMy1, shieldMy2;
        private CheckBox shieldEn1, shieldEn2;

        private void InitializeComponent()
        {
            this.components = new Container();
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

            this.lblMyTeam = new Label();
            this.lblEnemyTeam = new Label();
            this.shieldMy1 = new CheckBox();
            this.shieldMy2 = new CheckBox();
            this.shieldEn1 = new CheckBox();
            this.shieldEn2 = new CheckBox();

            this.SuspendLayout();

            // leagueDropdown
            this.leagueDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            this.leagueDropdown.Location = new Point(20, 20);
            this.leagueDropdown.Size = new Size(150, 23);

            // My Team label
            this.lblMyTeam.Text = "My Team";
            this.lblMyTeam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblMyTeam.Location = new Point(20, 50);
            this.lblMyTeam.Size = new Size(100, 20);

            // Enemy Team label
            this.lblEnemyTeam.Text = "Enemy Team";
            this.lblEnemyTeam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblEnemyTeam.Location = new Point(240, 50);
            this.lblEnemyTeam.Size = new Size(100, 20);

            // myTeam ComboBoxes
            foreach (var cb in new[] { myTeam1, myTeam2, myTeam3 })
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Size = new Size(150, 23);
            }
            myTeam1.Location = new Point(20, 80);
            myTeam2.Location = new Point(20, 120);
            myTeam3.Location = new Point(20, 160);

            // two shield checkboxes for My Team
            this.shieldMy1.Appearance = Appearance.Button;
            this.shieldMy1.Text = "🔰";
            this.shieldMy1.Size = new Size(30, 23);
            this.shieldMy1.Location = new Point(180, 80);

            this.shieldMy2.Appearance = Appearance.Button;
            this.shieldMy2.Text = "🔰";
            this.shieldMy2.Size = new Size(30, 23);
            this.shieldMy2.Location = new Point(180, 120);

            // enemyTeam ComboBoxes
            foreach (var cb in new[] { enemyTeam1, enemyTeam2, enemyTeam3 })
            {
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.Size = new Size(150, 23);
            }
            enemyTeam1.Location = new Point(240, 80);
            enemyTeam2.Location = new Point(240, 120);
            enemyTeam3.Location = new Point(240, 160);

            // two shield checkboxes for Enemy Team
            this.shieldEn1.Appearance = Appearance.Button;
            this.shieldEn1.Text = "🔰";
            this.shieldEn1.Size = new Size(30, 23);
            this.shieldEn1.Location = new Point(420, 80);

            this.shieldEn2.Appearance = Appearance.Button;
            this.shieldEn2.Text = "🔰";
            this.shieldEn2.Size = new Size(30, 23);
            this.shieldEn2.Location = new Point(420, 120);

            // coverageBox (height + anchor + scrollbar)
            this.coverageBox.Location = new Point(20, 200);
            this.coverageBox.Size = new Size(370, 230);
            this.coverageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.coverageBox.ScrollBars = RichTextBoxScrollBars.Vertical;

            // reset buttons
            this.resetMyTeamButton.Text = "Reset My Team";
            this.resetMyTeamButton.Location = new Point(20, 440);
            this.resetMyTeamButton.Size = new Size(120, 30);

            this.resetEnemyTeamButton.Text = "Reset Enemy";
            this.resetEnemyTeamButton.Location = new Point(250, 440);
            this.resetEnemyTeamButton.Size = new Size(120, 30);

            // Form1
            this.ClientSize = new Size(480, 520);
            this.Controls.Add(this.leagueDropdown);
            this.Controls.Add(this.lblMyTeam);
            this.Controls.Add(this.lblEnemyTeam);

            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.myTeam2);
            this.Controls.Add(this.myTeam3);
            this.Controls.Add(this.shieldMy1);
            this.Controls.Add(this.shieldMy2);

            this.Controls.Add(this.enemyTeam1);
            this.Controls.Add(this.enemyTeam2);
            this.Controls.Add(this.enemyTeam3);
            this.Controls.Add(this.shieldEn1);
            this.Controls.Add(this.shieldEn2);

            this.Controls.Add(this.coverageBox);
            this.Controls.Add(this.resetMyTeamButton);
            this.Controls.Add(this.resetEnemyTeamButton);

            this.Name = "Form1";
            this.Text = "Nebsoji PvP Trainer";
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}
