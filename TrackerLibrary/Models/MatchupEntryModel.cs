using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// rappresenta un team in un matchup 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// rappresenta lo score di questo particolare team nel match 
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// ci dice il match da dove proviene il team 
        /// </summary>
        public MatchupModel ParentMatch { get; set; }
    }
}
