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

        public PersonModel CreatePerson(PersonModel person)
        {
            //Leggo le persone nel mio registro 
            //Da List<string> lo porto a List<Person>
            //Leggo id 
            //Metto nel corrente l'id 
            //riconverto a List<string> 
            //salvo
            return person; 
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Wire up the connection for text file 
            // Load text file e ci entra una list<string> 
            // Convert text to list of prize model
            //abbiamo creato extension methods 
            List<IModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            // Find max id 
            //settig the new Id
            model.Id = prizes.GetId();
            // Add new record with new id (max + 1)
            prizes.Add(model);
            // Convert the prizes to a list<string>
            // Save list of string to text file 
            prizes.SaveToPrizeFile(PrizesFile);

            return model; 
        }
    }
}
