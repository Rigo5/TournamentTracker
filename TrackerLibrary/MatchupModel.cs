using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// lista dei partecipanti al match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// vincitore del match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Numero del round del match 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
