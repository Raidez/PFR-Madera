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
    public partial class GestionGamme : Form
    {
        public GestionGamme() {
            InitializeComponent();
            reloadGammes();
        }
    	
    	public void reloadGammes() {
    		// vidage des combobox
    		comboBox1.Items.Clear();
    		comboBox2.Items.Clear();
    		comboBox1.Text = "";
    		comboBox2.Text = "";
			
			if (Gamme.listGamme.Count > 0) {
    			// ajout des valeurs
				ComboxItem item;
				foreach (Gamme g in Gamme.listGamme) {
					item = new ComboxItem(g.gamLibelle, g.gamId);
					comboBox1.Items.Add(item);
					comboBox2.Items.Add(item);
				}
    			
				// sélection du 1er élément
				comboBox1.SelectedIndex = 0;
				comboBox2.SelectedIndex = 0;
    		}
    	}
    	
    	private void BtnAjoutGamme_Click(object sender, EventArgs e) {
    		if (!textBox1.Text.Any()) {
            	MessageBox.Show("Vous devez renseigner le nom de la gamme !");
    		} else {
    			// ajout de la gamme
    			new Gamme(textBox1.Text).ajoutGamme();
    			MessageBox.Show("La gamme a été créer !");
    			this.textBox1.Text = "";
    			reloadGammes();
    		}
        }
    	
    	private void BtnModificationGamme_Click(object sender, EventArgs e) {
    		if (!textBox2.Text.Any() || Gamme.listGamme.Count <= 0) {
    			MessageBox.Show((!textBox2.Text.Any())? "Vous devez renseigner le nouveau nom de la gamme sélectionnée" : "Il n'y a pas de gammes !");
    		} else {
    			// modification de la gamme
    			Guid id = (Guid) (comboBox1.SelectedItem as ComboxItem).Value;
    			Gamme.afficherGamme(id).gamLibelle = textBox2.Text;
    			MessageBox.Show("La gamme a été modifiée !");
    			textBox2.Text = "";
    			reloadGammes();
    		}
        }

        private void BtnSupprimerGamme_Click(object sender, EventArgs e) {
    		if (Gamme.listGamme.Count <= 0) {
    			MessageBox.Show("Il n'y a pas de gammes !");
    		} else {
	            ComboxItem item = (ComboxItem) comboBox2.SelectedItem;
	            if (Gamme.supprimeGamme((Guid) item.Value)) {
	            	MessageBox.Show("La gamme a été supprimée !");
	    			reloadGammes();
	            }
    		}
        }
        
		void BtnRetourClick(object sender, EventArgs e) {
        	ActionButtonGeneric.GoBack(this);
		}
        
		void BtnExitClick(object sender, EventArgs e) {
        	ActionButtonGeneric.Deconnexion();
		}
    }
}
