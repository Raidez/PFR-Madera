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
		public Fournisseur(Guid id,string fouNom, string fouTel, int fouAdrNumero, string fouAdrRue, string fouAdrCodePostal, string fouVille, string fouPays, string fouMail) {
			this.fouNom = fouNom;
			this.fouTel = fouTel;
			this.fouAdrNumero = fouAdrNumero;
			this.fouAdrRue = fouAdrRue;
			this.fouAdrCodePostal = fouAdrCodePostal;
			this.fouVille = fouVille;
			this.fouPays = fouPays;
			this.fouMail = fouMail;
            this.fouId = id;
		}

		
		public object Clone() {
			return this.MemberwiseClone();
		}
	}
}
