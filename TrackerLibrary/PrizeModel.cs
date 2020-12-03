using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Keyy value nel DB o text file 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// posizione del premio 
        /// </summary>
        public int PlaceNumeber { get; set; }
        /// <summary>
        /// Nome del premio
        /// </summary>
        public string PrizeName { get; set; }
        /// <summary>
        /// Ammontare del premio in soldi
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Ammontare del premio in percentuale
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
