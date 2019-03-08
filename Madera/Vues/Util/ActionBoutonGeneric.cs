/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 27/11/2018
 * Heure: 13:15
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Madera
{
	/// <summary>
	/// Description of ActionButtonGeneric.
	/// </summary>
	public static class ActionButtonGeneric
	{
		public static Stack<Form> pile = new Stack<Form>();
		
		public static void GoBack(Form frm) {
			if (pile.Count > 0) {
				Form next = pile.Pop();
	    		next.Show();
	    		next.WindowState = frm.WindowState;
	    		frm.Hide();
			}
		}
		
		public static void GoNextForm(Form current, Form next) {
			next.WindowState = current.WindowState;
			pile.Push(current);
			next.Show();
			current.Hide();
		}
		
		public static void GoHome() {
			while(pile.Count > 1) {
				pile.Pop();
			}
			pile.Pop().Show();
			
			//Application.Run();
			
			/*
			pile.Clear();
			new Projet();
			*/
		}
		
		public static void Deconnexion() {
			Application.Exit();
		}
 	}
}
