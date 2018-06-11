using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class Prize
    {
        /// <summary>
        /// Unique identifier for a prize into dataBase 
        /// </summary>
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Identifier of the place of the prize (Ex: 1).
        /// </summary>
        private int placeNumber;

        /// <summary>
        /// Set or Get the prize place number.
        /// </summary>
        public int PlaceNumber
        {
            get { return placeNumber; }
            set { placeNumber = value; }
        }

        /// <summary>
        /// Describe the palce name (Ex: First Place).
        /// </summary>
        private string placeName;

        /// <summary>
        /// Set or Get place number.
        /// </summary>
        public string PlaceName
        {
            get { return placeName; }
            set { placeName = value; }
        }

        /// <summary>
        /// Amount reserved for the prize based on the place number and entered fee for the tournament.
        /// </summary>
        private decimal amount;

        /// <summary>
        /// Set or Get prize Amount.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Percentage for the prize based on the place number and entered fee for the tournament.
        /// </summary>
        private double percentage;

        /// <summary>
        /// Set or Get prize Percentage.
        /// </summary>
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public Prize()
        {

        }

        public Prize(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            bool placeNumberValid = int.TryParse(placeNumber, out int placeNumberValue);
            this.placeNumber = placeNumberValue;

            this.placeName = placeName;

            bool plazeAmountValid = decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            this.amount = prizeAmountValue;

            bool prizePercentageValid = double.TryParse(prizePercentage, out double prizePercentageValue);
            this.percentage = prizePercentageValue;
        }
    }
}
