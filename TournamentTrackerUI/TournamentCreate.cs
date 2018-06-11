using co.mz.TournamentBusinessRules;
using co.mz.TournamentLibrary.Model;
using co.mz.TournamentLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTrackerUI.Utilities.Interfaces;

namespace TournamentTrackerUI
{
    public partial class TournamentCreate : Form, IPrizeRequestor, ITeamRequestor
    {
        private List<Team> availableTeams = GlobalConfig.Connection.GetAllTeam();
        private List<Team> selectedTeams = new List<Team>();
        private List<Prize> selectedPrizes = new List<Prize>();

        public TournamentCreate()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamComboBox.DataSource = null;
            SelectTeamComboBox.DataSource = availableTeams;
            SelectTeamComboBox.DisplayMember = "name";

            TournamentPlayersListBox.DataSource = null;
            TournamentPlayersListBox.DataSource = selectedTeams;
            TournamentPlayersListBox.DisplayMember = "name";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "placeName";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TournamentCreate_Load(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            var selectedTeam = (Team)SelectTeamComboBox.SelectedItem;

            if(selectedTeam != null) { 
                availableTeams.Remove(selectedTeam);
                selectedTeams.Add(selectedTeam);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            //TODO - Add comment that really describe the following code  
            PrizeCreation prizeCreationForm = new PrizeCreation(this);
            prizeCreationForm.Show();
        }


        /// <summary>
        /// TODO - Add comment to this line
        /// </summary>
        /// <param name="_team"></param>
        public void TeamCompleted(Team _team)
        {
            availableTeams.Add(_team);
            WireUpLists();
        }

        public void PrizeCompleted(Prize _prize)
        {
            selectedPrizes.Add(_prize);
            WireUpLists();
        }

        private void CreateTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO - Team Add comment that really describe the following code  
            TeamCreator teamCreatorForm = new TeamCreator(this);
            teamCreatorForm.Show();
        }

        private void RemoveSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            Team selectedTeam = (Team)TournamentPlayersListBox.SelectedItem;

            if(selectedTeam != null)
            {
                selectedTeams.Remove(selectedTeam);
                availableTeams.Add(selectedTeam);

                WireUpLists();
            }
        }

        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            Prize selectedPrize = (Prize) PrizesListBox.SelectedItem;

            if (selectedPrize != null)
            {
                selectedPrizes.Remove(selectedPrize);

                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //create a Tournament model
            Tournament _tournament = new Tournament();

            _tournament.Name = TournamentNameTextBox.Text;

            bool validFee = decimal.TryParse(EntryFeeTextBox.Text, out decimal fee);

            if (!validFee)
            {
                MessageBox.Show("Please enter a valid fee.");
                return;
            }

            _tournament.EntryFee = fee;
            _tournament.Prizes = selectedPrizes;
            _tournament.Teams = selectedTeams;

            //TODO - Plan Round and Set how to catch up
            _tournament.CreateRounds();

            GlobalConfig.Connection.CreateTournament(_tournament);
        }
    }
}
