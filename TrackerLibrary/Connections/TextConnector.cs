using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using System.Linq;
using System.Configuration;


namespace TrackerLibrary.Connections
{
    /* Il connettore e' come quello di boomi,
     siccome stiamo andando a scrivere allora dobbiamo passargli un profilo,
    e in questo caso specifico ci viene anche ritornato un profilo*/ 
    public class TextConnector1 : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PersonModel CreatePerson(PersonModel person)
        {
            throw new NotImplementedException();
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
         

            return model; 
        }
    }
}
