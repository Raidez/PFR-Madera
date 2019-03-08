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
		
		public static void _init() {
			Fournisseur fou = new Fournisseur("YoloLand1", "0123456789", 5, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us");
			listMatiere.Add(new Matiere("Bois", fou));
			listMatiere.Add(new Matiere("Acier", fou));
			listMatiere.Add(new Matiere("Papier", fou));
		}

		public static Matiere _initOne()
		{
			Fournisseur fou = new Fournisseur("YoloLand1", "0123456789", 5, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us");
			return new Matiere("Bois", fou);
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

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
