/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 28/11/2018
 * Heure: 20:17
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Madera.Classes
{
	/// <summary>
	/// Description of ComboxItem.
	/// </summary>
	public class ComboxItem
	{
		public string Text { get; set; }
	    public object Value { get; set; }
	    
	    public ComboxItem() {}
	    public ComboxItem(String Text, object Value) {
	    	this.Text = Text;
	    	this.Value = Value;
	    }
	
	    public override string ToString() {
	        return Text;
	    }
	}
}
