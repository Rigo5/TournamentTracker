﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }
        // Probabilmente questa cosa ha piu' senso farla all intenro della classe PrizeModel 
        // e poi utilizzare il try/catch 
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            //int.TryParse(PlaceNameValue.Text, out placeNumber) di per se la funzione converte una string in int
            //torna un boolean in base ala riuscita o meno 
            //abbiamo anche un out parameter che butta fuori informazioni nella variabile placeNumber
            //informazioni che in questo caso sono il nostro numero convertito in int32
            if (!int.TryParse(PlaceNumberValue.Text, out placeNumber))
            {
                output = false;
                MessageBox.Show("Valore Place Number non numerico");
            }

            if(placeNumber < 1)
            {
                output = false;
                MessageBox.Show("Valore Place number non valido");

            }

            if(PlaceNameValue.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Inserire nome piazzamento");
            }

            decimal amount = 0; 
            if (!decimal.TryParse(PrizeAmountValue.Text, out amount ))
            {
                output = false;
            }


            return output; 
        }
    }
}