using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// nome del torneo
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Fee di ingresso al torneo 
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Lista teams nel torneo
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Lista premi del torneo
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// lista dei match per ogni round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
