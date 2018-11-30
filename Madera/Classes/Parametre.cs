using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Parametre
	{
		public Guid parId { get; set; }
		public string parNom { get; set; }
		public Object parValeur { get; set; }
		public static List<Parametre> listParametre = new List<Parametre>();

		public Parametre(string parNom, object parValeur)
		{
			this.parNom = parNom;
			this.parValeur = parValeur;
			this.parId = Guid.NewGuid();
		}

		public static void _init(){
			listParametre.Add(new Parametre("Longueur", 15));
			listParametre.Add(new Parametre("Largeur", 10));
			listParametre.Add(new Parametre("Profondeur", 14));
		}

		public void ajouterParam() {
			try
			{
				listParametre.FindIndex(x => x.parId == this.parId);
			}
			catch (Exception e)
			{
				throw new Exception("Paramètre déjà existant");
			}

			listParametre.Add(this);
		}

		public static void modifierParam(Parametre p) {
			int i = listParametre.FindIndex(x => x.parId == p.parId);
			listParametre.RemoveAt(i);
			listParametre.Insert(i, p);
		}

		public static bool supprimerParam(Guid parId) {
			try
			{
				listParametre.RemoveAt(listParametre.FindIndex(x => x.parId == parId));
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}
	}
}
