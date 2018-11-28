using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera
{
    public partial class GestionGamme : Form
    {
        public GestionGamme() {
            InitializeComponent();
            reloadGammes();
        }
    	
    	public void reloadGammes() {
    		Dictionary<string, string> data = new Dictionary<string, string>();
            foreach (Classes.Gamme g in Classes.Gamme.listGamme) {
            	data.Add(g.gamId.ToString(), g.gamLibelle);
            }
            this.comboBox1.DataSource = new BindingSource(data, null);
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.ValueMember = "Key";
    	}
    	
    	private void BtnAjoutGamme_Click(object sender, EventArgs e) {
    		if (!this.textBox1.Text.Any()) {
            	MessageBox.Show("Vous devez renseigner le nom de la gamme !");
    		} else {
    			// ajout de la gamme
    			Classes.Gamme.ajoutGamme(new Classes.Gamme(42, this.textBox1.Text));
    			MessageBox.Show("La gamme a été créer !");
    			this.textBox1.Text = "";
    			reloadGammes();
    		}
        }
    	
    	private void BtnModificationGamme_Click(object sender, EventArgs e) {
            MessageBox.Show("Gamme modifié !");
        }

        private void BtnSupprimerGamme_Click(object sender, EventArgs e) {
            MessageBox.Show("Gamme supprimé !");
        }
        
		void BtnRetourClick(object sender, EventArgs e) {
        	ActionButtonGeneric.GoBack(this);
		}
        
		void BtnDeconnexionClick(object sender, EventArgs e) {
        	ActionButtonGeneric.Deconnexion();
		}
    }
}
