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
    public partial class GestionFournisseur : Form
    {
        public GestionFournisseur() {
            InitializeComponent();
            ReloadFourn();
        }
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
    		ActionButtonGeneric.Deconnexion();
		}
    	
    	void BtnRetour_Click(object sender, EventArgs e)
    	{
    		ActionButtonGeneric.GoBack(this);
		}
    	
    	public void ReloadFourn() {
    		// vidage des combox
    		ComboBoxModifierFournisseur.Items.Clear();
    		ComboBoxSupprimerFournisseur.Items.Clear();
    		ComboBoxModifierFournisseur.Text = "";
    		ComboBoxSupprimerFournisseur.Text = "";
    		
    		if (Fournisseur.listFournisseur.Count > 0) {
    			// ajout des valeurs
    			ComboxItem item;
    			foreach (Fournisseur f in Fournisseur.listFournisseur) {
    				item = new ComboxItem(f.fouNom, f.fouId);
    				ComboBoxModifierFournisseur.Items.Add(item);
    				ComboBoxSupprimerFournisseur.Items.Add(item);
    			}
    			
    			// sélection du 1er élement
				ComboBoxModifierFournisseur.SelectedIndex = 0;
				ComboBoxSupprimerFournisseur.SelectedIndex = 0;
    		}
    		
    	}
    	
    	void GestionFournisseurPaint(object sender, PaintEventArgs e) {
    		ReloadFourn();
		}
    	
    	public void ResetControls() {
    		TextBoxNom.Text = "";
			TextBoxNumRue.Text = "";
			TextBoxRue.Text = "";
			TextBoxCodePostal.Text = "";
			TextBoxVille.Text = "";
			TextBoxTelephone.Text = "";
			TextBoxEmail.Text = "";
			ComboBoxPays.Text = "";
			ComboBoxPays.SelectedIndex = -1;
    	}
    	
    	public bool CheckControls() {
    		bool isOK = TextBoxNom.Text.Any();
    		isOK &= TextBoxNumRue.Text.Any();
    		isOK &= TextBoxRue.Text.Any();
    		isOK &= TextBoxCodePostal.Text.Any();
    		isOK &= TextBoxVille.Text.Any();
    		isOK &= TextBoxTelephone.Text.Any();
    		isOK &= TextBoxEmail.Text.Any();
    		isOK &= ComboBoxPays.SelectedIndex >= 0;
    		
    		return isOK;
    	}
		
		void BtnAjouter_Click(object sender, EventArgs e) {
    		if (!CheckControls()) {
    			MessageBox.Show("Renseignez tout les champs !");
    		} else {
    			try {
    				new Fournisseur(TextBoxNom.Text, TextBoxTelephone.Text, Int32.Parse(TextBoxNumRue.Text), TextBoxRue.Text, TextBoxCodePostal.Text, TextBoxVille.Text, (string) ComboBoxPays.SelectedItem, TextBoxEmail.Text).ajouterFourni();
    			} catch (FormatException ex) {
    				MessageBox.Show("Le champ numéro de rue n'est pas correctement rempli !");
    			}
    			ResetControls();
    			ReloadFourn();
    			
    		}
		}
    	
		void BtnModifier_Click(object sender, EventArgs e) {
    		if (Fournisseur.listFournisseur.Count <= 0) {
    			MessageBox.Show("Il n'y a pas de fournisseurs !");
    		} else {
    			ComboxItem item = (ComboxItem) ComboBoxModifierFournisseur.SelectedItem;
    			Fournisseur fournisseur = Fournisseur.afficher((Guid) item.Value);
    			ActionButtonGeneric.GoNextForm(this, new ModificationFournisseur(fournisseur));
    		}
		}
    	
		void BtnSupprimer_Click(object sender, EventArgs e) {
			if (Fournisseur.listFournisseur.Count <= 0) {
    			MessageBox.Show("Il n'y a pas de fournisseurs !");
    		} else {
    			ComboxItem item = (ComboxItem) ComboBoxSupprimerFournisseur.SelectedItem;
    			Fournisseur fournisseur = Fournisseur.afficher((Guid) item.Value);
    			if (Fournisseur.supprimerFourni(fournisseur.fouId)) {
	            	MessageBox.Show("Le fournisseur a été supprimé !");
	            	ReloadFourn();
    			}
    		}
		}
    }
}
