/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 15:20
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Madera.Vues.Devis
{
	/// <summary>
	/// Description of DevisModule.
	/// </summary>
	public partial class DevisModule : Form
	{
		public DevisModule()
		{
			InitializeComponent();
		}
		
		public DevisModule(object e)
		{
			InitializeComponent();
		}
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
			ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnRetour_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoBack(this);
		}

	}
}
