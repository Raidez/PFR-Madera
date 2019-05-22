/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 11:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Madera.Vues.Configuration
{
	/// <summary>
	/// Description of ModificationModule.
	/// </summary>
	public partial class ModificationModule : Form
	{
		Module module;
		Module moduleBak;
    	
		public ModificationModule()
		{
			InitializeComponent();
		}
    	
		public ModificationModule(object m)
		{
			InitializeComponent();
			module = (Module) m;
			moduleBak = (Module) module.Clone();
			ReloadForm();
		}
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
			ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnRetour_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoBack(this);
		}
    	
		public void ReloadForm()
		{
			
		}
    	
		void BtnModifier_Click(object sender, EventArgs e)
		{
			try {
				//BDDExterne.SupprimerModule();
				//BDDExterne.AjouterModule();
				ActionButtonGeneric.GoBack(this);
			} catch (FormatException ex) {
				MessageBox.Show("Le champ numéro de rue n'est pas correctement rempli !");
			}
		}
    	
    	
		void BtnReset_Click(object sender, EventArgs e)
		{
			module = (Module) moduleBak.Clone();
			ReloadForm();
		}
	}
}
