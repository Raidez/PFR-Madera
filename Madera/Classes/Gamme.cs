using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Gamme
	{
		public Guid gamId { get; set; }
		public string gamLibelle { get; set; }
		public static List<Gamme> listGamme = new List<Gamme>();
		
		/// <summary>
		/// Constructeur d'une gamme
		/// </summary>
		/// <param name="gamLibelle">Libellé d'une gamme</param>
		public Gamme(string gamLibelle)
		{
			this.gamLibelle = gamLibelle;
			this.gamId = Guid.NewGuid();
		}
		
		public static void _init (){
			listGamme.Add(new Gamme("Basic"));
			listGamme.Add(new Gamme("Standard"));
			listGamme.Add(new Gamme("Premium"));
		}

		/// <summary>
		/// Retourne une gamme trouvée avec son GUID
		/// </summary>
		/// <param name="gamId">GUID de la gamme</param>
		/// <returns>La gamme trouvée</returns>
		public static Gamme afficherGamme(Guid gamId) {
			return listGamme.Find(x => x.gamId == gamId);
		}

		/// <summary>
		/// Ajout d'une gamme dans la liste LazyLoad
		/// </summary>
		public void ajoutGamme() {
			try {
				listGamme.FindIndex(x => x.gamId == this.gamId);
			}
			catch (Exception) {
				throw new Exception("Gamme déjà existante");
			}

			listGamme.Add(this);
		}

		/// <summary>
		/// Modification d'une gamme
		/// </summary>
		/// <param name="g">La gamme à modifier</param>
		public static void modifierGamme(Gamme g) {
			int i = listGamme.FindIndex(x => x.gamId == g.gamId);
			listGamme.RemoveAt(i);
			listGamme.Insert(i, g);
		}

		/// <summary>
		/// Suppression d'une gamme
		/// </summary>
		/// <param name="gamId">GUID de la gamme à supprimer</param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
		public static bool supprimeGamme(Guid gamId) {
			try {
				listGamme.RemoveAt(listGamme.FindIndex(x => x.gamId == gamId));
			} catch (Exception) {
				return false;
			}

			return true;
			
		}
	}
}
