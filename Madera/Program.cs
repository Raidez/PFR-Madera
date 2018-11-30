/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 25/11/2018
 * Heure: 16:15
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Madera.Classes;

namespace Madera
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			// instancie des données vides
			Gamme._init();
			Fournisseur._init();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Projet());
		}
	}
}
