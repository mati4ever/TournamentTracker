using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// 
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
