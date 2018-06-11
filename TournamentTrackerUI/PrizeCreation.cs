using co.mz.TournamentLibrary;
using co.mz.TournamentLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using co.mz.TournamentLibrary.Utilities;
using TournamentTrackerUI.Utilities.Interfaces;

namespace TournamentTrackerUI
{
    public partial class PrizeCreation : Form
    {
        private IPrizeRequestor _callerForm;

        public PrizeCreation(IPrizeRequestor caller)
        {
            InitializeComponent();
            _callerForm = caller;
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Prize _prize = new Prize(
                    PlaceNamberTextBox.Text,
                    PlaceNameTextBox.Text,
                    PrizeAmountTextBox.Text,
                    PrizePercentageTextBox.Text);

                   GlobalConfig.Connection.CreatePrize(_prize);
                
                PlaceNamberTextBox.Text = "";
                PlaceNameTextBox.Text = "";
                PrizeAmountTextBox.Text = "0";
                PrizePercentageTextBox.Text = "0";

                //Call the completed method
                _callerForm.PrizeCompleted(_prize);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter with the valid datas");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            bool placeNamberValid = int.TryParse(PlaceNamberTextBox.Text, out int placeNumber);

            if (!placeNamberValid ) 
            {
                output = false;
            }
            
            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            bool prazeAmountValid = decimal.TryParse(PrizeAmountTextBox.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageTextBox.Text, out double prizePercentage);

            if ((!prazeAmountValid) || (!prizePercentageValid))
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(!(prizePercentage >= 0 && prizePercentage <= 100))
            {
                output = false;
            }

            return output;
        }
    }
}
