using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using System.Linq;
using System.Configuration;
using TrackerLibrary.Connections;

namespace TrackerUI
{
    /* Il connettore e' come quello di boomi,
     siccome stiamo andando a scrivere allora dobbiamo passargli un profilo,
    e in questo caso specifico ci viene anche ritornato un profilo*/ 
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Wire up the connection for text file 
            // Load text file e ci entra una list<string> 
            // Convert text to list of prize model
            //abbiamo creato extension methods 
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            // Find max id 
            int currentId = 1;

            if(prizes.Count() > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            //settig the new Id
            model.Id = currentId;
            // Add new record with new id (max + 1)
            prizes.Add(model);
            // Convert the prizes to a list<string>
            // Save list of string to text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model; 
        }
    }
}
