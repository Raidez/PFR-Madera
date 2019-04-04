﻿using Madera.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera.Vues.Devis
{
	public partial class CreerClient : Form
	{
		public CreerClient()
		{
			InitializeComponent();

            // ajout des valeurs
            ComboxItem item;
            foreach (Client f in BDDExterne.GetAllClients())
            {
                item = new ComboxItem(f.cliNom + " " + f.cliPrenom, f.cliId);
                comboBox1.Items.Add(item);
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
			Client client = BDDExterne.GetAllClients().Find(x => x.cliId == (Guid) comboBox1.SelectedValue);
			ActionButtonGeneric.GoNextForm(this, new DevisModule(client));
		}
	}
}