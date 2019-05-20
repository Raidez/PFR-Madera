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
	public partial class ModificationClient : Form
	{
		Client client;
		Client clientBak;
    	
		public ModificationClient()
		{
			InitializeComponent();
		clientBak = (Client)client.Clone();
			ReloadForm();
		}
    	
		public void ReloadForm()
		{
			textBoxNom.Text = client.cliNom;
			textBoxPrenom.Text = client.cliPrenom;
			textBoxRue.Text = client.cliRue;
			textBoxCodePostal.Text = client.cliCp;
			textBoxVille.Text = client.cliVille;
			textBoxTelephone.Text = client.cliTel;
			textBoxEmail.Text = client.cliEmail;
		}
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
			ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnRetour_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoBack(this);
		}
    	
		void BtnSupprimer_Click(object sender, EventArgs e)
		{
            BDDExterne.SupprimerClient(client.cliId.ToString());
			BtnRetour_Click(sender, e);
		}
		
		void BtnReset_Click(object sender, EventArgs e)
		{
			client = (Client)clientBak.Clone();
			ReloadForm();
		}
		
		void BtnModifierClick(object sender, EventArgs e)
		{
			client.cliNom = textBoxNom.Text;
			client.cliPrenom = textBoxPrenom.Text;
			client.cliRue = textBoxRue.Text;
			client.cliCp = textBoxCodePostal.Text;
			client.cliVille = textBoxVille.Text;
			client.cliTel = textBoxTelephone.Text;
			client.cliEmail = textBoxEmail.Text;
			ActionButtonGeneric.GoBack(this);
		}
	}
}
