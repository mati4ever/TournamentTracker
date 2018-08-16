﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {

        public int Id { get; set; }

        /// <summary>
        /// Represents team name.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represnts list of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
              
    }
}
