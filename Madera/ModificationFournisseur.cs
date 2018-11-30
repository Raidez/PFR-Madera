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
        public ModificationFournisseur() {
            InitializeComponent();
        }
    	
    	public ModificationFournisseur(object f) {
    		Fournisseur fournisseur = (Fournisseur) f;
    		TextBoxFournisseur.Text = fournisseur.fouNom;
    		TextBoxTelephone.Text = fournisseur.fouTel;
    		TextBoxRue.Text = fournisseur.fouAdrRue;
    		TextBoxCodePostal.Text = fournisseur.fouAdrCodePostal;
    		TextBoxVille.Text = fournisseur.fouVille;
    		//ComboBoxPays
    		//fournisseur.fouAdrNumero;
    	}
    	
		void BtnModificationFournisseurClick(object sender, EventArgs e) {
    		ActionButtonGeneric.GoBack(this);
		}
    }
}
