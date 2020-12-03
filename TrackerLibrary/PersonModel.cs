using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
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
    }
}
