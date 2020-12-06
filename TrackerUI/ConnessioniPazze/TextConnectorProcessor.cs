﻿using System;
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
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach(string line in lines)
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
        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename) {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumeber },{ p.PrizeName },{ p.PrizeAmount },{ p.PrizePercentage }");
            }

            File.WriteAllLines(filename.FullFilePath(), lines);
        } 
    }
}
