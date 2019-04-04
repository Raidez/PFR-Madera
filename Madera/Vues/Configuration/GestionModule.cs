/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 10:24
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Madera.Classes;

namespace Madera.Vues.Configuration
{
	/// <summary>
	/// Description of GestionModule.
	/// </summary>
	public partial class GestionModule : Form
	{
		List<List<TextBox>> Paramètres = new List<List<TextBox>>();
    	
        public GestionModule()
        {
            InitializeComponent();
            reloadModules();
        }
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
    		ActionButtonGeneric.Deconnexion();
		}
    	
    	void BtnRetour_Click(object sender, EventArgs e)
    	{
    		ActionButtonGeneric.GoBack(this);
		}
    	
    	public void reloadModules() {
    		// vidage des combobox
    		CbxModuleModifier.Items.Clear();
    		CbxModuleSupprimer.Items.Clear();
    		CbxModuleModifier.Text = "";
    		CbxModuleSupprimer.Text = "";
			
			// ajout des valeurs
			ComboxItem item;
			foreach (Module m in BDDExterne.GetAllModules()) {
				item = new ComboxItem(m.modLibele, m.modId);
				CbxModuleModifier.Items.Add(item);
				CbxModuleSupprimer.Items.Add(item);
			}
    	}
    	
    	public void ResetControls() {
    		TbxLibelleAjout.Text = "";
    		TbxPrixAjout.Text = "";
    		CbxGammeAjout.Text = "";
    		CbxGammeAjout.SelectedIndex = -1;
    		CbxMatièreAjout.Text = "";
    		CbxMatièreAjout.SelectedIndex = -1;
    		Paramètres.Clear();
    	}
    	
    	public bool CheckControls() {
    		bool isOK = !string.IsNullOrWhiteSpace(TbxLibelleAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(TbxPrixAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(CbxGammeAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(CbxMatièreAjout.Text);
    		isOK &= Paramètres.Count > 0;
    		foreach (var param in Paramètres) {
    			isOK &= !string.IsNullOrWhiteSpace(param[0].Text);
    			isOK &= !string.IsNullOrWhiteSpace(param[1].Text);
    		}
    		return isOK;
    	}
    	
    	private void BtnAjouter_Click(object sender, EventArgs e) {
    		if (!CheckControls()) {
    			MessageBox.Show("Renseignez tout les champs !");
    		} else {
    			try {
    				// récupération de la gamme
    				Gamme gam = BDDExterne.GetAllGammes().Find(x => x.gamId == (Guid) (CbxGammeAjout.SelectedItem as ComboxItem).Value);
    				
    				// récupération de la matière
    				Matiere mat = BDDExterne.GetAllMatiere().Find(x => x.matId == (Guid) (CbxMatièreAjout.SelectedItem as ComboxItem).Value);
    				
    				// conversion du prix en double
    				double prix = Convert.ToDouble(TbxPrixAjout.Text);
    				
    				// récupération des paramètres
    				List<Parametre> paramètres = new List<Parametre>();
    				foreach  (var param in Paramètres) {
    					paramètres.Add(new Parametre(param[0].Text, param[1].Text));
    				}
    				
    				// enregistrement dans la BDD
    				BDDExterne.AjouterModule(new Module(TbxLibelleAjout.Text, gam, mat, prix, paramètres));
    			} catch (FormatException ex) {
    				MessageBox.Show("Le champ prix n'est pas correctement rempli !");
    			}
    			ResetControls();
    			
    		}
        }
    	
    	private void BtnModifier_Click(object sender, EventArgs e) {
    		if (BDDExterne.GetAllModules().Count <= 0) {
    			MessageBox.Show("Il n'y a pas de modules !");
    		} else {
    			ComboxItem item = (ComboxItem) CbxModuleModifier.SelectedItem;
    			Module modu = BDDExterne.GetAllModules().Find(x => x.modId == (Guid) item.Value);
    			ActionButtonGeneric.GoNextForm(this, new ModificationModule(modu));
    		}
        }

        private void BtnSupprimer_Click(object sender, EventArgs e) {
    		if (BDDExterne.GetAllModules().Count <= 0) {
    			MessageBox.Show("Il n'y a pas de module !");
    		} else {
    			 ComboxItem item = (ComboxItem) CbxModuleSupprimer.SelectedItem;
    			 if (BDDExterne.SupprimerModule(Convert.ToString(item.Value))) {
    			 	MessageBox.Show("Le module a été supprimée !");
    			 	reloadModules();
    			 }
    		}
        }
    	
    	void BtnAjoutParamClick(object sender, EventArgs e)
		{
    		// paramètrage des textbox à ajouter
    		TextBox TbxNom = new TextBox();
    		TbxNom.Top = 0;
    		TbxNom.Left = TbxNom.Width * Paramètres.Count;
    		
    		TextBox TbxValeur = new TextBox();
    		TbxValeur.Top = TbxNom.Height + 5;
    		TbxValeur.Left = TbxValeur.Width * Paramètres.Count;
    		
    		// ajout des textbox dans la liste
    		Paramètres.Add(new List<TextBox>() { TbxNom, TbxValeur });
    		PanParams.Controls.Add(TbxNom);
    		PanParams.Controls.Add(TbxValeur);
		}
	}
}
