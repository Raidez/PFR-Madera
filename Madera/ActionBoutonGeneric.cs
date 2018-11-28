﻿/*
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
    		pile.Pop().Show();
    		frm.Hide();
		}
		
		public static void GoNextForm(Form current, Form next) {
			pile.Push(current);
			next.Show();
			current.Hide();
		}
		
		public static void Deconnexion() {
			Application.Exit();
		}
 	}
}