using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera.Vues
{
    public partial class CreerClient : Form
    {
        public CreerClient()
        {
            InitializeComponent();
        }

        #region CodeFront
        private void textBoxPrenom_Click(object sender, EventArgs e)
        {
            if (textBoxPrenom.Text == "Prenom")
            {
                textBoxPrenom.Text = "";
            }
        }

        private void textBoxNom_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == "Nom")
            {
                textBoxNom.Text = "";
            }
        }

        private void textBoxRue_Click(object sender, EventArgs e)
        {
            if (textBoxRue.Text == "Rue")
            {
                textBoxRue.Text = "Rue";
            }
        }

        private void textBoxCodePostal_Click(object sender, EventArgs e)
        {
            if (textBoxCodePostal.Text == "Code postal")
            {
                textBoxCodePostal.Text = "";
            }
        }

        private void textBoxVille_Click(object sender, EventArgs e)
        {

            if (textBoxVille.Text == "Ville")
            {
                textBoxVille.Text = "";
            }
        }

        private void textBoxTelephone_Click(object sender, EventArgs e)
        {
            if (textBoxTelephone.Text == "Téléphone")
            {
                textBoxTelephone.Text = "";
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Courriel")
            {
                textBoxEmail.Text = "";
            }
        }
        #endregion
               
        private void buttonValidationCreation_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
