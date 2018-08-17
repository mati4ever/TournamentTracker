using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        ///  the unique identyfier of the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents team who won a matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents round number
        /// </summary>
        public int MatchupRounds { get; set; }

    }
}
