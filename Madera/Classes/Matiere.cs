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

        /// <summary>
        ///
        /// </summary>
        /// <param name="matLibelle"></param>
        /// <param name="matFournisseur"></param>
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

		}

		public static Matiere afficherMatiere(Guid id)
		{
			return listMatiere.Find(x => x.matId == id);
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="m"></param>
		public static void modifierMatiere(Matiere m)
		{

		}

		/// <summary>
		///
		/// </summary>
		/// <param name="matId"></param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
		public static bool supprimerMatiere(Guid matId)
		{


			return true;
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
