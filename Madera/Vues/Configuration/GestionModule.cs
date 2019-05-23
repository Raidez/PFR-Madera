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
using System.Diagnostics;

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
                List<ComboxItem> dataGamme = new List<ComboxItem>();
               

                foreach (Gamme maGamme in BDDExterne.GetAllGammes())
                {
                    dataGamme.Add(new ComboxItem() { Value = maGamme.gamId, Text = maGamme.gamLibelle });
                }
                CbxGammeAjout.DisplayMember = "Text";
                CbxGammeAjout.ValueMember = "Value";
                CbxGammeAjout.DataSource = dataGamme;

                List<ComboxItem> dataMatiere = new List<ComboxItem>();

                foreach (Matiere maMatiere in BDDExterne.GetAllMatiere())
                {
                    dataMatiere.Add(new ComboxItem() { Value = maMatiere.matId, Text = maMatiere.matLibelle});
                }
            
                CbxMatièreAjout.DisplayMember = "Text";
                CbxMatièreAjout.ValueMember = "Value";
                CbxMatièreAjout.DataSource = dataMatiere;

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
            if (!CheckControls())
            {
                MessageBox.Show("Renseignez tout les champs !");
            }
            else
            {
               
                List<Parametre> maListeParam = new List<Parametre>();
                foreach (var item in LbxParamsAjout.Items)
                {
                    Parametre monParam = new Parametre(Guid.NewGuid(), item.ToString(), 0);
                    maListeParam.Add(monParam);
                }
                Module monModule = new Module(Guid.NewGuid(), TbxLibelleAjout.Text, BDDExterne.GetGamme(CbxGammeAjout.SelectedValue.ToString()), BDDExterne.GetMatiere(CbxMatièreAjout.SelectedValue.ToString()), 0, maListeParam, textBox3.Text);
                string query = @"INSERT INTO public.module(mod_id, mod_libelle, mod_prix_base, ""uniteUsage"", matiere, gamme)VALUES('" + monModule.modId.ToString() + "', '" + monModule.modLibele + "', 0, '" + monModule.uniteUsage+"', '" + monModule.modMatiere.matId + "', '" +monModule.modGamme.gamId + "' )";
                if (BDDExterne.Insert(query) == false)
                {
                    MessageBox.Show("ERREUR INSERT");
                }
                foreach (Parametre monParam in monModule.modParametres)
                {
                    query = @"INSERT INTO public.parametre(par_id, par_nom, mod_id)VALUES ('" + monParam.parId + "', '" + monParam.parNom + "', '" + monModule.modId + "');";
                    if (BDDExterne.Insert(query) == false) 
                    {
                        MessageBox.Show("ERREUR INSERT");
                    }

                }
                query = @"INSERT INTO public.parametre(par_id, par_nom, mod_id)VALUES ('" + Guid.NewGuid().ToString() + "', 'prix', '" + monModule.modId + "');";
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e) {
    		//if (BDDExterne.GetAllModules().Count <= 0) {
    		//	MessageBox.Show("Il n'y a pas de modules !");
    		//} else {
    		//	ComboxItem item = (ComboxItem) CbxModuleModifier.SelectedItem;
    		//	Module modu = BDDExterne.GetAllModules().Find(x => x.modId == (Guid) item.Value);
    		//	ActionButtonGeneric.GoNextForm(this, new ModificationModule(modu));
    		//}
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
            LbxParamsAjout.Items.Add(textBox2.Text);
            textBox2.Text = "";


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

        private void CbxGammeAjout_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine(CbxGammeAjout.SelectedValue);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
