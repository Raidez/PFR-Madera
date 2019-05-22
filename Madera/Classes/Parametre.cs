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
        public Guid parIdValeur { get; set; }

		/// <summary>
		/// Constructeur d'un paramètre
		/// </summary>
		/// <param name="parNom">Nom du paramètre</param>
		/// <param name="parValeur">Valeur du paramètre</param>
		public Parametre(Guid id, string parNom, object parValeur)
		{
			this.parNom = parNom;
			this.parValeur = parValeur;
            this.parId = id;
		}

		/// <summary>
		/// Ajout du paramètre dans la liste de LazyLoad
		/// </summary>
		public void ajouterParam() {

		}

		/// <summary>
		/// Modification d'un paramètre
		/// </summary>
		/// <param name="p">Le paramètre à modifier</param>
		public static void modifierParam(Parametre p) {

		}

		/// <summary>
		/// Suppression d'un paramètre
		/// </summary>
		/// <param name="parId">GUID du paramètre à supprimer</param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
		public static bool supprimerParam(Guid parId) {

			return true;
		}
	}
}
