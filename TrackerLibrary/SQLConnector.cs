using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            /// <summary>
            /// Salva premio nel database
            /// </summary><param name="model"> 
            /// Caratteristiche premio
            /// </param><returns>
            /// Caratteristiche premio includendo anche la key creata
            /// </returns>
            model.Id = 1;
            return model; 
        }
    }
}
