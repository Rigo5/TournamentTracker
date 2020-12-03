using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /* Il connettore e' come quello di boomi,
     siccome stiamo andando a scrivere allora dobbiamo passargli un profilo,
    e in questo caso specifico ci viene anche ritornato un profilo*/ 
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Wire up the connection for text file 
            model.Id = 1;

            return model; 
        }
    }
}
