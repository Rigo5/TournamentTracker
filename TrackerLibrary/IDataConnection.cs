using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /*
     Questa interfaccia ti dice semplicemnte che il profilo verra salvato e verrra' tornato un profilo, 
     ma come tutto questo accade viene implementato nelle classi successivamente
    */
    public interface IDataConnection
    {
        /// <summary>
        /// salva il premio dal modello dato 
        /// e lo torna con l ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        PrizeModel CreatePrize(PrizeModel model);
    }
}
