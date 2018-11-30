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
    	
        public ModificationFournisseur() {
            InitializeComponent();
        }
    	
    	public ModificationFournisseur(object f) {
            InitializeComponent();
    		fournisseur = Fournisseur.afficher(((Fournisseur) f).fouId);
    		fournisseurBak = (Fournisseur) fournisseur.Clone();
    		reloadForm();
    	}
    	
    	public void reloadForm() {
    		TextBoxFournisseur.Text = fournisseur.fouNom;
    		TextBoxTelephone.Text = fournisseur.fouTel;
    		TextBoxRue.Text = fournisseur.fouAdrRue;
    		TextBoxCodePostal.Text = fournisseur.fouAdrCodePostal;
    		TextBoxVille.Text = fournisseur.fouVille;
    		ComboBoxPays.Text = fournisseur.fouPays;
    	}
    	
		void BtnModificationFournisseurClick(object sender, EventArgs e) {
    		fournisseur.fouNom = TextBoxFournisseur.Text;
    		fournisseur.fouTel = TextBoxTelephone.Text;
    		fournisseur.fouAdrRue = TextBoxRue.Text;
    		fournisseur.fouAdrCodePostal = TextBoxCodePostal.Text;
    		fournisseur.fouVille = TextBoxVille.Text;
    		fournisseur.fouPays = ComboBoxPays.Text;
			ActionButtonGeneric.GoBack(this);
		}
    	
    	
		void BtnResetClick(object sender, EventArgs e) {
    		fournisseur = (Fournisseur) fournisseurBak.Clone();
    		reloadForm();
		}
    	
		void BtnRetourClick(object sender, EventArgs e) {
			ActionButtonGeneric.GoBack(this);
		}
    	
		void BtnExitClick(object sender, EventArgs e) {
    		ActionButtonGeneric.Deconnexion();
		}
    }
}
