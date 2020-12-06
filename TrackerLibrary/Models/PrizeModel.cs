using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
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
        /// <summary>
        /// Default constructor
        /// </summary>
        public PrizeModel()
        {
                
        }
        ///<summary> 
        ///Overload del default Costruttore
        /// </summary>
        /// <param name="place_number"> numero posizione </param>
        /// <param name="prize_name">nome del posto</param>
        /// <param name="prize_amount">ammontare premio in denaro</param>
        /// <param name="prize_percentage">ammontare premio in percentuale</param>
        public PrizeModel(string place_number, string prize_name, string prize_amount, string prize_percentage)
        {
            this.PlaceNumeber = int.Parse(place_number);
            this.PrizeName = prize_name;
            this.PrizeAmount = decimal.Parse(prize_amount);
            this.PrizePercentage = double.Parse(prize_percentage);
        }
        
    }
}
