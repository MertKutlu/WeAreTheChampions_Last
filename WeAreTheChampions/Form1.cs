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
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
            ResultMatch();
            ListMatches();
        }

        private void NewMatchList()
        {
            var Team1 = db.Teams.ToList();
            cboNewTeam1.DataSource = Team1;
            Team1.Insert(0, new Team { TeamName = "Select Team" });
            var Team2 = db.Teams.ToList();
            cboNewTeam2.DataSource = Team2;
            Team2.Insert(0, new Team { TeamName = "Select Team" });
        }

        private void ListMatches()
        {
            dgvMatches.DataSource = db.Matches.ToList().OrderByDescending(x => x.MatchTime).Select(x => new
            {
                MatchNo = x.Id,
                Team1 = x.Team1.TeamName,
                Team2 = x.Team2.TeamName,
                Date = x.MatchTime?.ToShortDateString(),
                Time = x.MatchTime?.ToShortTimeString(),
                Score = x.Score1 + "-" + x.Score2,
                Result = x.Result
            }).ToList();
        }

        private void ResultMatch()
        {
            var Matches = db.Matches.ToList();
            foreach (var item in Matches)
            {
                if (item.Score1 > item.Score2)
                    item.Result = Result.Team1;
                else if (item.Score2 > item.Score1)
                    item.Result = Result.Team2;
                else if (item.Score2 == item.Score1 && DateTime.Now > item.MatchTime)
                    item.Result = Result.Draw;
                else
                    item.Result = null;
                db.SaveChanges();
            }
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            var frmTeams = new TeamsForm(db);
            frmTeams.HasBeenChanged += FrmTeams_HasBeenChanged;
            frmTeams.ShowDialog();
        }

        private void FrmTeams_HasBeenChanged(object sender, EventArgs e)
        {
            ResultMatch();
            ListMatches();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            var frmPlayers = new PlayersForm(db);
            frmPlayers.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewMatchList();
            gbNewMatch.Show();
            btnAdd.Hide();
            btnDelete.Hide();
            btnEdit.Hide();
            menuStrip1.Hide();
            pbGif.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Hide();
            btnDelete.Hide();
            gbNewMatch.Hide();
            gbEditMatch.Show();
            pbGif.Hide();
            if (dgvMatches.Rows.Count < 1)
            {
                MessageBox.Show("There is no match for edit");
                btnEditMatchCancel.PerformClick();
                return;
            }
            int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(id);
            if (btnEdit.Text == "Save")
            {
                int index = dgvMatches.SelectedRows[0].Index;
                match.Team1 = (Team)cboEditTeam1.SelectedItem;
                match.Team2 = (Team)cboEditTeam2.SelectedItem;

                match.Score1 = (int)nudScore1.Value;
                match.Score2 = (int)nudScore2.Value;

                match.Result = match.Score1 > match.Score2 ? Result.Team1 : Result.Team2;
                if (match.Score1 == match.Score2)
                    match.Result = Result.Draw;
                match.MatchTime = dtpEditDate.Value;
                db.SaveChanges();
                ListMatches();
                dgvMatches.ClearSelection();
                btnAdd.Show();
                gbEditMatch.Hide();
                btnEdit.Show();
                btnEdit.Text = "Edit";
                btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
                btnDelete.Show();
                pbGif.Show();
                dgvMatches.Rows[index].Selected = true;
                return;
            }
            if (match.Score1 != null && match.Score2 != null)
            {
                nudScore1.Value = (int)match.Score1;
                nudScore2.Value = (int)match.Score2;
            }
            else
            {
                nudScore1.Value = 0;
                nudScore2.Value = 0;
            }
            cboEditTeam1.DataSource = db.Teams.ToList();
            cboEditTeam2.DataSource = db.Teams.ToList();
            cboEditTeam1.SelectedItem = match.Team1;
            cboEditTeam2.SelectedItem = match.Team2;
            dtpEditDate.Value = (DateTime)match.MatchTime;
            btnEdit.Text = "Save";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnEdit.BackColor = System.Drawing.Color.SteelBlue;
        }

        private void btnMatchAdd_Click(object sender, EventArgs e)
        {
            #region Method1
            //Match match = new Match()
            //{
            //    Team1 = (Team)cboNewTeam1.SelectedItem,
            //    Team2 = (Team)cboNewTeam2.SelectedItem,
            //    MatchTime = dtpNewDate.Value,
            //};
            //db.Matches.Add(match); 
            #endregion
            Team Team1 = (Team)cboNewTeam1.SelectedItem;
            Team Team2 = (Team)cboNewTeam2.SelectedItem;
            if (Team1 == Team2)
            {
                MessageBox.Show("You can't choose the same two teams.");
                return;
            }
            DateTime? MatchDate = dtpNewDate.Value;
            db.Matches.Add(new Match() { Team1 = Team1, Team2 = Team2, MatchTime = MatchDate });
            db.SaveChanges(); // Geçmiş tarihli maç eklendiğinde dgv result kısmı için eklendi kod tekrarı değil.
            ResultMatch();
            db.SaveChanges();
            ListMatches();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatches.Rows.Count < 1)
            {
                return;
            }
            int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            var index = dgvMatches.SelectedRows[0].Index;
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
            db.SaveChanges();
            ListMatches();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            var frmColors = new ColorsForm(db);
            frmColors.ShowDialog();
        }

        private void btnNewMatchCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Show();
            gbNewMatch.Hide();
            btnDelete.Show();
            btnEdit.Show();
            menuStrip1.Show();
            pbGif.Show();
        }

        private void btnEditMatchCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Show();
            gbEditMatch.Hide();
            btnDelete.Show();
            btnEdit.Show();
            btnEdit.Text = "Edit";
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEdit.BackColor = System.Drawing.Color.DarkOliveGreen;
            pbGif.Show();
        }

        private void chkHideCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideCompleted.Checked == true)
            {
                dgvMatches.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).Where(x => x.Result == null).ToList().Select(x => new
                {
                    MatchNo = x.Id,
                    Team1 = x.Team1.TeamName,
                    Team2 = x.Team2.TeamName,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + "-" + x.Score2,
                    Result = x.Result
                }).ToList();
            }
            else
            {
                ListMatches();
            }
        }

        private void pbGif_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=goeT7boL1Ks");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show(
                "Are you sure you want to quit the program?",
                "Closing Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            e.Cancel = dr == DialogResult.No;
        }
    }
}
