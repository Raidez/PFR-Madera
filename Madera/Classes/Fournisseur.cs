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
		public static List<Fournisseur> listFourniseurs { get; set; } = new List<Fournisseur>();

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
			this.fouId = listFourniseurs.Count;
		}
	}
}
