using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Fournisseur : ICloneable
	{
		public Guid fouId { get; set; }
		public string fouNom { get; set; }
		public string fouTel { get; set; }
		public int fouAdrNumero { get; set; }
		public string fouAdrRue { get; set; }
		public string fouAdrCodePostal { get; set; }
		public string fouVille { get; set; }
		public string fouPays { get; set; }
		public string fouMail { get; set; }
		public static List<Fournisseur> listFournisseur = new List<Fournisseur>();

        /// <summary>
		/// Constructeur du fournisseur
		/// </summary>
		/// <param name="fouNom">Nom du fournisseur</param>
		/// <param name="fouTel">Numéro de téléphone du fournisseur</param>
		/// <param name="fouAdrNumero">Numéro de rue du fournisseur</param>
		/// <param name="fouAdrRue">Nom de rue du fournisseur</param>
		/// <param name="fouAdrCodePostal">Code postal du fournisseur</param>
		/// <param name="fouVille">Nom de ville du fournisseur</param>
		/// <param name="fouPays">Pays du fournisseur</param>
		/// <param name="fouMail">Mail du fournisseur</param>
		public Fournisseur(string fouNom, string fouTel, int fouAdrNumero, string fouAdrRue, string fouAdrCodePostal, string fouVille, string fouPays, string fouMail) {
			this.fouNom = fouNom;
			this.fouTel = fouTel;
			this.fouAdrNumero = fouAdrNumero;
			this.fouAdrRue = fouAdrRue;
			this.fouAdrCodePostal = fouAdrCodePostal;
			this.fouVille = fouVille;
			this.fouPays = fouPays;
			this.fouMail = fouMail;
			this.fouId = Guid.NewGuid();
		}


		public static void _init() {
			new Fournisseur("YoloLand1", "0123456789", 5, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us").ajouterFourni();
			new Fournisseur("YoloLand2", "0123456789", 10, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us").ajouterFourni();
			new Fournisseur("YoloLand3", "0123456789", 15, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us").ajouterFourni();
		}

		public static Fournisseur _initOne() {
			return new Fournisseur("YoloLand3", "0123456789", 15, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us");
		}

		/// <summary>
		/// Ajout du fournisseur dans la liste de LazyLoad
		/// </summary>
		public void ajouterFourni()
		{
			try {
				listFournisseur.FindIndex(x => x.fouId == this.fouId);
			}
			catch (Exception) {
				throw new Exception("Fournisseur déjà existant");
			}

			listFournisseur.Add(this);
		}

		public static Fournisseur afficher(Guid id) {
			return listFournisseur.Find(x => x.fouId == id);
		}


        /// <summary>
		/// Modification d'un fournisseur
		/// </summary>
		/// <param name="f">Le fournisseur</param>
		public static void modifier(Fournisseur f)
		{
			int i = listFournisseur.FindIndex(x => x.fouId == f.fouId);
			listFournisseur.RemoveAt(i);
			listFournisseur.Insert(i, f);
		}

		/// <summary>
		/// Suppression d'un fournisseur
		/// </summary>
		/// <param name="fouId">GUID du fournisseur à supprimer</param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
		public static bool supprimerFourni(Guid fouId)
		{
			try
			{
				listFournisseur.RemoveAt(listFournisseur.FindIndex(x => x.fouId == fouId));
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		public object Clone() {
			return this.MemberwiseClone();
		}
	}
}
