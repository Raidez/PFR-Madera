using Madera.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            // ajout des valeurs

            try
            {

                List<ComboxItem> data = new List<ComboxItem>();

                foreach (Client unClient in BDDExterne.GetAllClients())
                {
                        data.Add(new ComboxItem() { Value = unClient.cliId, Text = unClient.cliNom + " " + unClient.cliPrenom});                    
                }
                
                comboBoxListeClient.DisplayMember = "Text";
                comboBoxListeClient.DataSource = data;
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }

        }
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
			ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnRetour_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoBack(this);
		}

		#region CodeFront
		private void textBoxPrenom_Click(object sender, EventArgs e)
		{
			if (textBoxPrenom.Text == "Prenom") {
				textBoxPrenom.Text = "";
			}
		}

		private void textBoxNom_Click(object sender, EventArgs e)
		{
			if (textBoxNom.Text == "Nom") {
				textBoxNom.Text = "";
			}
		}

		private void textBoxRue_Click(object sender, EventArgs e)
		{
			if (textBoxRue.Text == "Rue") {
				textBoxRue.Text = "Rue";
			}
		}

		private void textBoxCodePostal_Click(object sender, EventArgs e)
		{
			if (textBoxCodePostal.Text == "Code postal") {
				textBoxCodePostal.Text = "";
			}
		}

		private void textBoxVille_Click(object sender, EventArgs e)
		{

			if (textBoxVille.Text == "Ville") {
				textBoxVille.Text = "";
			}
		}

		private void textBoxTelephone_Click(object sender, EventArgs e)
		{
			if (textBoxTelephone.Text == "Téléphone") {
				textBoxTelephone.Text = "";
			}
		}

		private void textBoxEmail_TextChanged(object sender, EventArgs e)
		{
			if (textBoxEmail.Text == "Courriel") {
				textBoxEmail.Text = "";
			}
		}
		#endregion
        
		void BtnClear_Click(object sender, EventArgs e)
		{
			textBoxNom.Clear();
			textBoxPrenom.Clear();
			textBoxRue.Clear();
			textBoxCodePostal.Clear();
			textBoxVille.Clear();
			textBoxTelephone.Clear();
			textBoxEmail.Clear();
		}
		
		void BtnAjouter_Click(object sender, EventArgs e)
		{
            Client monClient = new Client(Guid.NewGuid(), textBoxNom.Text, textBoxPrenom.Text, textBoxNumRue.Text, textBoxRue.Text, textBoxCodePostal.Text, textBoxVille.Text, textBoxTelephone.Text, textBoxEmail.Text);
            
            if (BDDExterne.AjouterClient(monClient) == false)
            {
                MessageBox.Show("Echec de l'ajout du client");
            }
		}
		
		void BtnChoisirClientClick(object sender, EventArgs e)
		{
            Devis monDevis = new Devis(Guid.NewGuid(),0,DateTime.Now,BDDExterne.GetClient(comboBoxListeClient.SelectedValue.ToString()),BDDExterne.GetSalarie("b807c385-2737-413a-b9b2-c076638275bd"));
            BDDExterne.AjouterDevis(monDevis);
			ActionButtonGeneric.GoNextForm(this, new ListeModuleParDevis(monDevis.devId.ToString()));
		}
        void refresh()
        {
            try
            {

                List<ComboxItem> data = new List<ComboxItem>();

                foreach (Client unClient in BDDExterne.GetAllClients())
                {
                    data.Add(new ComboxItem() { Value = unClient.cliId, Text = unClient.cliNom + " " + unClient.cliPrenom });
                }

                comboBoxListeClient.DisplayMember = "Text";
                comboBoxListeClient.DataSource = data;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
        }
	}
}
