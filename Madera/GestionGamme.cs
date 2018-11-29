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
    		this.comboBox1.Items.Clear();
    		this.comboBox2.Items.Clear();
			
			if (Gamme.listGamme.Count > 0) {
    			// ajout des valeurs
				ComboxItem item;
				foreach (Gamme g in Gamme.listGamme) {
					item = new ComboxItem(g.gamLibelle, g.gamId);
					this.comboBox1.Items.Add(item);
					this.comboBox2.Items.Add(item);
				}
    			
				// sélection du 1er élément
				this.comboBox1.SelectedIndex = 0;
				this.comboBox2.SelectedIndex = 0;
    		}
    	}
    	
    	private void BtnAjoutGamme_Click(object sender, EventArgs e) {
    		if (!this.textBox1.Text.Any()) {
            	MessageBox.Show("Vous devez renseigner le nom de la gamme !");
    		} else {
    			// ajout de la gamme
    			Gamme.ajoutGamme(new Gamme(this.textBox1.Text));
    			MessageBox.Show("La gamme a été créer !");
    			this.textBox1.Text = "";
    			reloadGammes();
    		}
        }
    	
    	private void BtnModificationGamme_Click(object sender, EventArgs e) {
    		if (!this.textBox2.Text.Any()) {
    			MessageBox.Show("Vous devez renseigner le nouveau nom de la gamme sélectionnée");
    		} else {
    			// modification de la gamme
    			int id = (int) (comboBox1.SelectedItem as ComboxItem).Value;
    			Gamme.modifierGamme(new Gamme(id, this.textBox2.Text));
    			MessageBox.Show("La gamme a été modifiée !");
    			this.textBox2.Text = "";
    			reloadGammes();
    		}
        }

        private void BtnSupprimerGamme_Click(object sender, EventArgs e) {
            ComboxItem item = (ComboxItem) comboBox1.SelectedItem;
            Gamme.supprimeGamme((int) item.Value);
            MessageBox.Show("La gamme a été supprimée !");
    		reloadGammes();
        }
        
		void BtnRetourClick(object sender, EventArgs e) {
        	ActionButtonGeneric.GoBack(this);
		}
        
		void BtnDeconnexionClick(object sender, EventArgs e) {
        	ActionButtonGeneric.Deconnexion();
		}
    }
}
