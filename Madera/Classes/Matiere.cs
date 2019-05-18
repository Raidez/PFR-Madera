using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Matiere
	{
		public Guid matId { get; set; }
		public string matLibelle { get; set; }
		public Fournisseur matFournisseur { get; set; }
		public static List<Matiere> listMatiere = new List<Matiere>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matLibelle"></param>
		/// <param name="matFournisseur"></param>
		public Matiere(string matLibelle, Fournisseur matFournisseur)
		{
			this.matLibelle = matLibelle;
			this.matFournisseur = matFournisseur;
			this.matId = Guid.NewGuid();
		}

        public Matiere(Guid id, string matLibelle, Fournisseur matFournisseur)
        {
            this.matLibelle = matLibelle;
            this.matFournisseur = matFournisseur;
            this.matId = id;
        }

        public Matiere(Guid id)
        {
            this.matId = id;
        }


        /// <summary>
        /// 
        /// </summary>
        public void ajouterMatiere()
		{
			try {
				listMatiere.FindIndex(x => x.matId == this.matId);
			} catch (Exception) {
                throw new Exception("Matière déjà existante");
			}

			listMatiere.Add(this);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		public static void modifierMatiere(Matiere m)
		{
			int i = listMatiere.FindIndex(x => x.matId == m.matId);
			listMatiere.RemoveAt(i);
			listMatiere.Insert(i, m);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matId"></param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
		public static bool supprimerMatiere(Guid matId)
		{
			try
			{
				listMatiere.RemoveAt(listMatiere.FindIndex(x => x.matId == matId));
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

	}
}
