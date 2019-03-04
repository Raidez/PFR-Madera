using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Parametre
	{
		public Guid parId { get; set; }
		public string parNom { get; set; }
		public Object parValeur { get; set; }
		public static List<Parametre> listParametre = new List<Parametre>();

		/// <summary>
		/// Constructeur d'un paramètre
		/// </summary>
		/// <param name="parNom">Nom du paramètre</param>
		/// <param name="parValeur">Valeur du paramètre</param>
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

		/// <summary>
		/// Ajout du paramètre dans la liste de LazyLoad
		/// </summary>
		public void ajouterParam() {
			try {
				listParametre.FindIndex(x => x.parId == this.parId);
			}
			catch (Exception) {
				throw new Exception("Paramètre déjà existant");
			}

			listParametre.Add(this);
		}

		/// <summary>
		/// Modification d'un paramètre
		/// </summary>
		/// <param name="p">Le paramètre à modifier</param>
		public static void modifierParam(Parametre p) {
			int i = listParametre.FindIndex(x => x.parId == p.parId);
			listParametre.RemoveAt(i);
			listParametre.Insert(i, p);
		}

		/// <summary>
		/// Suppression d'un paramètre
		/// </summary>
		/// <param name="parId">GUID du paramètre à supprimer</param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
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
