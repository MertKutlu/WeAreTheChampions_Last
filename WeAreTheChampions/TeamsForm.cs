using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class TeamsForm : Form
    {
        public event EventHandler HasBeenChanged;
        private WeAreTheChampionsContext db;

        public TeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListTeams();
            ListColor();
            cboColor1.SelectedIndex = cboColor2.SelectedIndex = -1;
        }
        protected virtual void WhenChanged(EventArgs args)
        {
            HasBeenChanged?.Invoke(this, args);
        }

        private void ListColor()
        {
            cboColor1.DataSource = db.Colors.ToList();
            cboColor2.DataSource = db.Colors.ToList();
        }

        private void ListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "")
            {
                MessageBox.Show("Please fill teamname field");
                return;
            }
            var teamName = (txtTeamName.Text).UpperCaseFirst();
            var color1 = (Models.Color)cboColor1.SelectedItem;
            var color2 = (Models.Color)cboColor2.SelectedItem;
            if (color1 == null || color2 == null)
            {
                MessageBox.Show("Have to choose two colors.");
                return;
            }
            List<Models.Color> colors = new List<Models.Color>{ color1, color2 };
            if (btnAdd.Text == "Save")
            {
                var selectedTeam = (Team)lstTeams.SelectedItem;
                if (db.Teams.ToList().Any(x => x.TeamName.ToLower() == teamName.ToLower().Replace(" ", "")))
                {
                    MessageBox.Show("There already a team in this team name");
                    return;
                }
                selectedTeam.TeamName = teamName;
                selectedTeam.TeamColors = colors;
                db.SaveChanges();
                ListTeams();
                TeamsFormReset();
                WhenChanged(EventArgs.Empty);
                return;
            }
            if (db.Teams.ToList().Any(x => x.TeamName.ToLower() == teamName.ToLower().Replace(" ", "")))
            {//zxc!= zxc
                MessageBox.Show("There already a team in this team name");
                return;
            }

            db.Teams.Add(new Team() { TeamName = teamName, TeamColors = colors});
            db.SaveChanges();
            ListTeams();
            TeamsFormReset();
            WhenChanged(EventArgs.Empty);
        }

        private void TeamsFormReset()
        {
            btnEdit.Text = "Edit";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            txtTeamName.Clear();
            lstTeams.Enabled = true;
            btnAdd.Text = "Add";
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAdd.BackColor = System.Drawing.Color.OrangeRed;
            lblColor1.BackColor = lblColor2.BackColor = System.Drawing.Color.White;
            cboColor1.SelectedIndex = cboColor2.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (btnEdit.Text == "Cancel")
            {
                TeamsFormReset();
                return;
            }
            btnEdit.Text = "Cancel";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Undo;
            btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            lstTeams.Enabled = false;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            btnAdd.Text = "Save";
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            txtTeamName.Text = selectedTeam.TeamName;
            var colors = selectedTeam.TeamColors.ToList();
            if (colors.Count == 1)
                cboColor1.SelectedItem = colors[0];
            else if (colors.Count == 2)
            {
                cboColor1.SelectedItem = colors[0];
                cboColor2.SelectedItem = colors[1];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTeams.SelectedIndex < 0) return;
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                db.Teams.Remove(selectedTeam);
                db.SaveChanges();
                ListTeams();
                WhenChanged(EventArgs.Empty);
            }
            catch (Exception)
            {
                MessageBox.Show("You can't delete this team. Because there are available players and matches!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            var frmPlayers = new PlayersForm(db);
            frmPlayers.ShowDialog();
        }

        private void cboColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColor1.SelectedIndex == -1)
            {
                lblColor1.BackColor = System.Drawing.Color.White;
                return;
            }
            var selectedColor = (Models.Color)cboColor1.SelectedItem;
            lblColor1.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void cboColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboColor2.SelectedIndex == -1)
            {
                lblColor2.BackColor = System.Drawing.Color.White;
                return;
            }
            var selectedColor = (Models.Color)cboColor2.SelectedItem;
            lblColor2.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = (Team)lstTeams.SelectedItem;
            List<Models.Color> colors = team.TeamColors.ToList();
            if (colors.Count == 0 || colors == null)
            {
                lblColor3.BackColor = System.Drawing.Color.Transparent;
                lblColor4.BackColor = System.Drawing.Color.Transparent;
            }
            else if (colors.Count == 1)
            {
                lblColor3.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lblColor4.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                lblColor3.BackColor = System.Drawing.Color.FromArgb(colors[0].Red, colors[0].Green, colors[0].Blue);
                lblColor4.BackColor = System.Drawing.Color.FromArgb(colors[1].Red, colors[1].Green, colors[1].Blue);
            }
        }
    }
}
