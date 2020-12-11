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
    public partial class PlayersForm : Form
    {
        private WeAreTheChampionsContext db;

        public PlayersForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            ListPlayers();
            ListTeam();
        }

        private void ListTeam()
        {
            var teams = db.Teams.ToList();
            teams.Insert(0, new Team { TeamName = "All" });
            teams.Insert(1, new Team { TeamName = "Non-Team Players" });
            cboTeams.DataSource = teams;
        }

        private void ListPlayers()
        {
            var players = db.Teams.ToList();
            players.Insert(0, new Team { TeamName = "Select Team" });
            players.Insert(1, new Team { TeamName = "Non-Team" });
            cboPlayersTeam.DataSource = players;
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPlayersTeam();
        }

        private void ListPlayersTeam()
        {
            Team selectedTeam = (Team)cboTeams.SelectedItem;
            var selectedTeamId = selectedTeam.Id;
            if (cboTeams.SelectedIndex == 0)
                lstPlayers.DataSource = db.Players.ToList();
            else if (cboTeams.SelectedIndex == 1)
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == null);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
            else
            {
                var selectedTeamPlayers = db.Players.ToList().Where(x => x.TeamId == selectedTeamId);
                lstPlayers.DataSource = selectedTeamPlayers.ToList();
            }
        }
        private void ResetPlayersForm()
        {
            lstPlayers.Enabled = true;
            btnAdd.Text = "Add";
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAdd.BackColor = System.Drawing.Color.OrangeRed;
            btnEdit.Text = "Edit";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            txtPlayerName.Clear();
            cboPlayersTeam.SelectedIndex = 0;
            cboTeams.SelectedIndex = 0;
            ListPlayersTeam();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboPlayersTeam.SelectedIndex == 0 || txtPlayerName.Text == "")
            {
                MessageBox.Show("Please fill all cells correctly.");
                return;
            }
            if (btnAdd.Text == "Save")
            {
                var selectedPlayer = (Player)lstPlayers.SelectedItem;
                selectedPlayer.PlayerName = txtPlayerName.Text.UpperCaseFirst();
                var teamEdit = (Team)cboPlayersTeam.SelectedItem;
                selectedPlayer.Team = cboPlayersTeam.SelectedIndex == 1 ? null : teamEdit;
                db.SaveChanges();
                ListPlayers();
                ResetPlayersForm();
                return;
            }
            string playerName = txtPlayerName.Text.UpperCaseFirst();
            Team team = (Team)cboPlayersTeam.SelectedItem;
            db.Players.Add(new Player()
            {
                PlayerName = playerName,
                Team = cboPlayersTeam.SelectedIndex == 1 ? null : team
            });
            db.SaveChanges();
            ListPlayers();
            ResetPlayersForm();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
                return;
            if (btnEdit.Text == "Cancel")
            {
                ResetPlayersForm();
                return;
            }
            btnEdit.Text = "Cancel";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Undo;
            btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            lstPlayers.Enabled = false;
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            btnAdd.Text = "Save";
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            txtPlayerName.Text = selectedPlayer.PlayerName;
            cboPlayersTeam.SelectedItem = selectedPlayer.Team;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
                return;
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            db.Players.Remove(selectedPlayer);
            db.SaveChanges();
            ResetPlayersForm();
            ListPlayers();
        }
    }
}
