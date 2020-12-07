using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;
using TrackerLibrary.Connections;

namespace TrackerUI
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// File path 
        /// </summary>
        /// <param name="filename">
        /// filename .csv
        /// </param>
        /// <returns></returns>
        public static string FullFilePath(this string filename) //PrizeModel.csv
        {
            //c:\data\TournamentTracker\filename.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }
        //vale per tutti i model 
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file)) //File.exist ritorna un bool
            {
                /*
                  non serve creare il file in quanto viene creato in automatico 
                  quando andiamo a scrivere
                 */
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<IModel> ConvertToPrizeModel(this List<string> lines) {
            List<IModel> output = new List<IModel>();
            foreach (string line in lines)
            {
                //splitto la linea utilizzando la comma 
                //mi esce quindi un array si stringhe 
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumeber = int.Parse(cols[1]);
                p.PrizeName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);

            }
            return output;
        }
        //convert to person list 
        public static List<IModel> ConvertToPersonModel(this List<string> lines)
        {
            List<IModel> output = new List<IModel>();
            foreach (string line in lines)
            {
                //splitto la linea utilizzando la comma 
                //mi esce quindi un array si stringhe 
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.PhoneNumber = cols[4];

                output.Add(p);

            }
            //ritorna la lista di persone trvate 
            return output;
        }

        //Ritorno id da mettere. Vale per tutti i modelli 
        public static int GetId(this List<IModel> ModelList)
        {
            int id = 1;
            if(ModelList.Count() > 0)
            {
                return ModelList.OrderByDescending(x => x.Id).First().Id + 1;
            }
            return id; 
        }
        public static void SaveToPrizeFile(this List<IModel> models, string filename) {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumeber },{ p.PrizeName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }
        public static void SaveToPersonFile(this List<IModel> person, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in person)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.PhoneNumber }");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        }
    }
}
