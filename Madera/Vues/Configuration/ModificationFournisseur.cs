using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madera.Classes;

namespace Madera
{
	public partial class ModificationFournisseur : Form
	{
		Fournisseur fournisseur;
		Fournisseur fournisseurBak;
    	
		public ModificationFournisseur()
		{
			InitializeComponent();
		}
    	
		public ModificationFournisseur(object f)
		{
			InitializeComponent();
			//fournisseur = Fournisseur.afficher(((Fournisseur)f).fouId);
			fournisseurBak = (Fournisseur)fournisseur.Clone();
			ReloadForm();
		}
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
			ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnRetour_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoBack(this);
		}
    	
		public void ReloadForm()
		{
			TextBoxFournisseur.Text = fournisseur.fouNom;
			TextBoxNumRue.Text = fournisseur.fouAdrNumero.ToString();
			TextBoxRue.Text = fournisseur.fouAdrRue;
			TextBoxCodePostal.Text = fournisseur.fouAdrCodePostal;
			TextBoxVille.Text = fournisseur.fouVille;
			TextBoxTelephone.Text = fournisseur.fouTel;
			TextBoxEmail.Text = fournisseur.fouMail;
			ComboBoxPays.Text = fournisseur.fouPays;
		}
    	
		void BtnModifier_Click(object sender, EventArgs e)
		{
			try {
				fournisseur.fouNom = TextBoxFournisseur.Text;
				fournisseur.fouAdrNumero = Int32.Parse(TextBoxNumRue.Text);
				fournisseur.fouAdrRue = TextBoxRue.Text;
				fournisseur.fouVille = TextBoxVille.Text;
				fournisseur.fouAdrCodePostal = TextBoxCodePostal.Text;
				fournisseur.fouTel = TextBoxTelephone.Text;
				fournisseur.fouMail = TextBoxEmail.Text;
				fournisseur.fouPays = ComboBoxPays.Text;
				ActionButtonGeneric.GoBack(this);
			} catch (FormatException) {
				MessageBox.Show("Le champ numéro de rue n'est pas correctement rempli !");
			}
		}
    	
    	
		void BtnReset_Click(object sender, EventArgs e)
		{
			fournisseur = (Fournisseur)fournisseurBak.Clone();
			ReloadForm();
		}
	}
}
