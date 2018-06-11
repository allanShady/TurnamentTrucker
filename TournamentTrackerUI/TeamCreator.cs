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
    public partial class TeamCreator : Form
    {
        private List<Person> availableTeamMembers = GlobalConfig.Connection.GetAllpeople();
        private List<Person> selectedTeamMembers = new List<Person>();
        private ITeamRequestor _callerForm;

        public TeamCreator(ITeamRequestor caller)
        {
            InitializeComponent();

            _callerForm = caller;
            //TestMyListsBehaviors();
            WireUpLists();
        }

        private void WireUpLists()
        {
            // TODO - Search for cool way to refresh listbox and dropdown fields
            SelectMemberComboBox.DataSource = null;
            SelectMemberComboBox.DataSource = availableTeamMembers;
            SelectMemberComboBox.DisplayMember = "FullName";

            TeamMemberListBox.DataSource = null;
            TeamMemberListBox.DataSource = selectedTeamMembers;
            TeamMemberListBox.DisplayMember = "FullName";

        }

        private void TestMyListsBehaviors()
        {
            availableTeamMembers.Add(new Person { FirstName = "Allan", LastName = "Camilo" });
            availableTeamMembers.Add(new Person { FirstName = "Salman", LastName = "Camilo" });

            selectedTeamMembers.Add(new Person { FirstName = "Ana", LastName = "Atija" });
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            //TODO - Validate the form
            // * 1. If the input values is valid create a Person object
            // * 2. Add Id to the Person table.
            // 3. Change the IDataConnection by Adding a methodo to create Person
            // 4. Implement the CreatePerson() method in the SQLConnector class
            // 4. Implement the CreatePerson() method in the TextConnector class

            if(ValidateForm())
            {
                var _person = new Person
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    CellPhoneNumber = CellPhoneTextBox.Text,
                    Email = EmailTextBox.Text
                };

                _person = GlobalConfig.Connection.CreatePerson(_person);

                //Add member in the list selected team and refresh the list
                selectedTeamMembers.Add(_person);
                WireUpLists();

                //Clear inputs
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                CellPhoneTextBox.Text = "";
                EmailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please you need to fill in the all Person input.");
            }
        }

        private bool ValidateForm()
        {
            var output = true;

            if(FirstNameTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (LastNameTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (EmailTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (CellPhoneTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person) SelectMemberComboBox.SelectedItem;

            if (selectedPerson != null)
            {
                availableTeamMembers.Remove(selectedPerson);
                selectedTeamMembers.Add(selectedPerson);

                WireUpLists(); 
            }
        }

        private void DeleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person) TeamMemberListBox.SelectedItem;

            if (selectedPerson != null)
            {
                selectedTeamMembers.Remove(selectedPerson);
                availableTeamMembers.Add(selectedPerson);

                WireUpLists();
            }

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            if (TeamNameTextBox.Text.Length != 0)
            {
                Team _team = new Team
                {
                    Name = TeamNameTextBox.Text,
                    Members = selectedTeamMembers
                };

                GlobalConfig.Connection.CreateTeam(_team);

                selectedTeamMembers.Clear();
                TeamNameTextBox.Text = "";
                WireUpLists();

                _callerForm.TeamCompleted(_team);
                this.Close();
            }
            else
            {
                MessageBox.Show("The new team must have a name. Please type a name.");
            }
        }
    }
}
