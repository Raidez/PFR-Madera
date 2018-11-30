using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
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
		
		public static bool supprimer(Fournisseur fourn) {
			return listFournisseur.Remove(fourn);
		}

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
