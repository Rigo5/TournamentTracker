using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Nome del team 
        /// </summary>
        public string TeamName { get; set; }
        //e' come facessimo con il construttore da C# 6
        /// <summary>
        /// Membri del team che sono oggetti Pearson
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
