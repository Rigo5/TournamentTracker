using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Connections;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //validazione dei campi non serve in quanto sono tutti stringhe
                //posso subito creare la persona 
                PersonModel persona = new PersonModel(
                        FirstNameValue.Text,
                        LastNameValue.Text,
                        EmailAddressValue.Text,
                        PhoneNumberValue.Text
                    );
                foreach (IDataConnection id in GlobalConfig.Connections)
                {
                    //salvo in db e text mi torna il form con l id
                    id.CreatePerson(persona);
                }

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailAddressValue.Text = "";
                PhoneNumberValue.Text = "";
            }
            else
            {
                MessageBox.Show("The format of something is not right pls review");
            }
        }
        private bool ValidateForm()
        {

            if (FirstNameValue.Text.Length == 0 ||
               LastNameValue.Text.Length == 0 ||
               EmailAddressValue.Text.Length == 0 ||
               PhoneNumberValue.Text.Length == 0
               )
            {
                return false;
            }
            return true;
    }
    }
}
