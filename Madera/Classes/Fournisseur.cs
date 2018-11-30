using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Fournisseur
	{
		public int fouId { get; set; }
		public string fouNom { get; set; }
		public string fouTel { get; set; }
		public int fouAdrNumero { get; set; }
		public string fouAdrRue { get; set; }
		public string fouAdrCodePostal { get; set; }
		public string fouVille { get; set; }
		public string fouPays { get; set; }
		public string fouMail { get; set; }
		public static List<Fournisseur> listFournisseur = new List<Fournisseur>();

		public Fournisseur(string fouNom, string fouTel, int fouAdrNumero, string fouAdrRue, string fouAdrCodePostal, string fouVille, string fouPays, string fouMail)
		{
			this.fouNom = fouNom;
			this.fouTel = fouTel;
			this.fouAdrNumero = fouAdrNumero;
			this.fouAdrRue = fouAdrRue;
			this.fouAdrCodePostal = fouAdrCodePostal;
			this.fouVille = fouVille;
			this.fouPays = fouPays;
			this.fouMail = fouMail;
			this.fouId = listFournisseur.Count;
		}

		public static void _init() {
			listFournisseur.Add(new Fournisseur("YoloLand1", "0123456789", 5, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us"));
			listFournisseur.Add(new Fournisseur("YoloLand2", "0123456789", 10, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us"));
			listFournisseur.Add(new Fournisseur("YoloLand3", "0123456789", 15, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us"));
		}

		public static void ajouterParam(Fournisseur f)
		{
			listFournisseur.Add(f);
		}

		public static void modifierParam(Fournisseur f)
		{
			int i = listFournisseur.FindIndex(x => x.fouId == f.fouId);
			listFournisseur.RemoveAt(i);
			listFournisseur.Insert(i, f);
		}

		public static bool supprimerParam(int fouId)
		{
			try
			{
				listFournisseur.RemoveAt(listFournisseur.FindIndex(x => x.fouId == fouId));
			}
			catch (Exception e)
			{
				return false;
			}

			return true;
		}
	}
}
