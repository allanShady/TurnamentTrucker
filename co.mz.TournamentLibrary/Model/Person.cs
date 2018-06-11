using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.mz.TournamentLibrary.Model
{
    public class Person
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
        /// Fist name of a person used while tryng contact the person.
        /// </summary>
        private string firstName;

        /// <summary>
        /// Set or Get the first name of a person.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Last name of a person used while tryng contact the person.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Set or Get the last name of a person
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Email used to contact the person about everythinh«g in the system. 
        /// </summary>
        private string email;

        /// <summary>
        /// Set or Get email.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Phone number used to contact the person about everythinh«g in the system.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Set or get the person phone number.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// CellPhone used to contact the person about everythinh«g in the system.
        /// </summary>
        private string cellPhoneNumber;

        /// <summary>
        /// Set or Get the person phone number.
        /// </summary>
        public string CellPhoneNumber
        {
            get { return cellPhoneNumber; }
            set { cellPhoneNumber = value; }
        }

        /// <summary>
        /// Get FullName of the person.
        /// </summary>
        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }
    }
}
