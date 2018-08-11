using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents first name of team member.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of team memmber.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents email address of team memmber.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents phone number of team memmber.
        /// </summary>
        public string CellphoneNumber { get; set; }

    }
}
