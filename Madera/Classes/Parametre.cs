using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Parametre
	{
		public int parID { get; set; }
		public string parNom { get; set; }
		public Object parValeur { get; set; }
		public static List<Parametre> listParametre = new List<Parametre>();

		public Parametre(string parNom, object parValeur)
		{
			this.parNom = parNom;
			this.parValeur = parValeur;
			this.parID = listParametre.Count;
		}

		public void ajouterParam(Parametre p) {
			listParametre.Add(p);
		}

		public void modifierParam(Parametre p) {
			listParametre.RemoveAt(p.parID);
			listParametre.Insert(p.parID, p);
		}

		public bool supprimerParam(Parametre p) {
			listParametre.Remove(p);

			return true;
		}
	}
}
