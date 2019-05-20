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
    	
    	public void reloadModules()
    	{
    		// vidage des combobox
    		CbxModuleModifier.Items.Clear();
    		CbxModuleSupprimer.Items.Clear();
    		CbxModuleModifier.Text = "";
    		CbxModuleSupprimer.Text = "";
			
			// ajout des modules déjà existant
			ComboxItem item;
			foreach (Module m in BDDExterne.GetAllModules()) {
				item = new ComboxItem(m.modLibele, m.modId);
				CbxModuleModifier.Items.Add(item);
				CbxModuleSupprimer.Items.Add(item);
			}
			
			// ajout des paramètres déjà existant
			//foreach (Parametre p in BDDExterne.GetAllParametre())
			//{
			//	item = new ComboxItem(p.parNom, p.parId);
			//	CbxParamNom.Items.Add(item);
			//}
    	}
    	
    	public void ResetControls() {
    		TbxLibelleAjout.Text = "";
    		TbxPrixAjout.Text = "";
    		CbxGammeAjout.Text = "";
    		CbxGammeAjout.SelectedIndex = -1;
    		CbxMatièreAjout.Text = "";
    		CbxMatièreAjout.SelectedIndex = -1;
    		LbxParamsAjout.Items.Clear();
    		LbxParamsAjout.SelectedIndex = -1;
    	}
    	
    	public bool CheckControls() {
    		bool isOK = !string.IsNullOrWhiteSpace(TbxLibelleAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(TbxPrixAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(CbxGammeAjout.Text);
    		isOK &= !string.IsNullOrWhiteSpace(CbxMatièreAjout.Text);
    		isOK &= LbxParamsAjout.Items.Count > 0;
    		return isOK;
    	}
    	
    	private void BtnAjouter_Click(object sender, EventArgs e) {
    		//if (!CheckControls()) {
    		//	MessageBox.Show("Renseignez tout les champs !");
    		//} else {
    		//	try {
    		//		// récupération de la gamme
    		//		Gamme gam = BDDExterne.GetAllGammes().Find(x => x.gamId == (Guid) (CbxGammeAjout.SelectedItem as ComboxItem).Value);
    				
    		//		// récupération de la matière
    		//		Matiere mat = BDDExterne.GetAllMatiere().Find(x => x.matId == (Guid) (CbxMatièreAjout.SelectedItem as ComboxItem).Value);
    				
    		//		// conversion du prix en double
    		//		double prix = Convert.ToDouble(TbxPrixAjout.Text);
    				
    		//		// récupération des paramètres
    		//		List<Parametre> paramètres = new List<Parametre>();
    		//		foreach  (var param in Paramètres) {
    		//			paramètres.Add(new Parametre(param[0].Text, param[1].Text));
    		//		}
    				
    		//		// enregistrement dans la BDD
    		//		BDDExterne.AjouterModule(new Module(Guid.NewGuid(),TbxLibelleAjout.Text, gam, mat, prix, paramètres));
    		//	} catch (FormatException ex) {
    		//		MessageBox.Show("Le champ prix n'est pas correctement rempli !");
    		//	}
    		//	ResetControls();
    			
    		//}
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
    		if (BDDExterne.GetAllModules().Count <= 0)
    		{
    			MessageBox.Show("Il n'y a pas de module !");
    		} 
    		else
    		{
    			 ComboxItem item = (ComboxItem) CbxModuleSupprimer.SelectedItem;
    			 if (BDDExterne.SupprimerModule(Convert.ToString(item.Value))) {
    			 	MessageBox.Show("Le module a été supprimée !");
    			 	reloadModules();
    			 }
    		}
        }
    	
    	void BtnAjoutParamClick(object sender, EventArgs e)
		{
    		if (CbxParamNom.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TbxParamValeur.Text))
    		{
    			MessageBox.Show("Vous devez rentrez un nom et une valeur au paramètre !");
    		}
    		else
    		{
    			// ajout du paramètre dans la listbox
    			string param = string.Format("{0} = {1}", CbxParamNom.SelectedText, TbxParamValeur.Text);
    			LbxParamsAjout.Items.Add(param);
    			
    			// vidage des champs
    			CbxParamNom.Text = "";
    			CbxParamNom.SelectedIndex = -1;
    			TbxParamValeur.Clear();
    		}
		}
    	
		void BtnSupprimerParamClick(object sender, EventArgs e)
		{
			if (LbxParamsAjout.SelectedIndex == -1)
			{
				MessageBox.Show("Vous devez sélectionner un paramètre !");
			}
			else
			{
				LbxParamsAjout.Items.RemoveAt(LbxParamsAjout.SelectedIndex);
			}
		}
		
		void CbxParamNomSelectedIndexChanged(object sender, EventArgs e)
		{
			//TbxParamValeur.Text = (string) BDDExterne.GetAllParametre().Find(x => x.parId == (Guid) CbxParamNom.SelectedValue).parValeur;
		}
	}
}
