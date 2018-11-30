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
            reloadFourn();
        }
    	
    	public void reloadFourn() {
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
    		reloadFourn();
		}
    	
    	public bool CheckControls() {
    		bool isOK = TextBoxNom.Text.Any();
    		isOK &= TextBoxTelephone.Text.Any();
    		isOK &= TextBoxRue.Text.Any();
    		isOK &= TextBoxCodePostal.Text.Any();
    		isOK &= ComboBoxPays.SelectedIndex >= 0;
    		
    		return isOK;
    	}
		
		void BtnAjoutFournisseurClick(object sender, EventArgs e) {
    		if (!CheckControls()) {
    			MessageBox.Show("Renseignez tout les champs !");
    		} else {
    			new Fournisseur(TextBoxNom.Text, TextBoxTelephone.Text, 31, TextBoxRue.Text, TextBoxCodePostal.Text, "ville", ComboBoxPays.SelectedText, "a@a.ab").ajouterFourni();
    			TextBoxNom.Text = "";
    			TextBoxTelephone.Text = "";
    			TextBoxCodePostal.Text = "";
    			ComboBoxPays.Text = "";
    			reloadFourn();
    		}
		}
    	
		void BtnModificationFournisseurClick(object sender, EventArgs e) {
    		if (Fournisseur.listFournisseur.Count <= 0) {
    			MessageBox.Show("Il n'y a pas de fournisseurs !");
    		} else {
    			ComboxItem item = (ComboxItem) ComboBoxModifierFournisseur.SelectedItem;
    			Fournisseur fournisseur = Fournisseur.afficher((Guid) item.Value);
    			ActionButtonGeneric.GoNextForm(this, new ModificationFournisseur(fournisseur));
    		}
		}
    	
		void BtnSupprimerFournisseurClick(object sender, EventArgs e) {
			if (Fournisseur.listFournisseur.Count <= 0) {
    			MessageBox.Show("Il n'y a pas de fournisseurs !");
    		} else {
    			ComboxItem item = (ComboxItem) ComboBoxSupprimerFournisseur.SelectedItem;
    			Fournisseur fournisseur = Fournisseur.afficher((Guid) item.Value);
    			if (Fournisseur.supprimer(fournisseur)) {
	            	MessageBox.Show("Le fournisseur a été supprimé !");
	            	reloadFourn();
    			}
    		}
		}
		
		void BtnRetourClick(object sender, EventArgs e) {
    		ActionButtonGeneric.GoBack(this);
		}
    }
}
