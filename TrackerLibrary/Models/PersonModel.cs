using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Nome
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Cognome
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Indirizzo mail
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Numero di telefono
        /// </summary>
        public string PhoneNumber { get; set; }
        public PersonModel(string name, string surname, string email, string phone)
        {
            this.FirstName = name;
            this.LastName = surname;
            this.EmailAddress = email;
            this.PhoneNumber = phone; 
        }
    }
}
