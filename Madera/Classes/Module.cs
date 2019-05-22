using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Module
	{
		public Guid modId { get; set; }
		public string modLibele { get; set; }
		public Gamme modGamme { get; set; }
		public Matiere modMatiere { get; set; }
		public double prixBase { get; set; }
		public List<Parametre> modParametres = new List<Parametre>();
        public string uniteUsage { get; set; }
        public int num_module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modLibele"></param>
        /// <param name="modGamme"></param>
        /// <param name="modMatiere"></param>
        /// <param name="prixBase"></param>
        /// <param name="modParametres"></param>
        public Module(Guid modId, string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase, List<Parametre> modParametres, string uniteUsage)
		{
			this.modLibele = modLibele;
			this.modGamme = modGamme;
			this.modMatiere = modMatiere;
			this.prixBase = prixBase;
			this.modParametres = modParametres;
            this.modId = modId;
            this.uniteUsage = uniteUsage;
		}

        public Module(Guid id, string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase)
        {
            this.modLibele = modLibele;
            this.modGamme = modGamme;
            this.modMatiere = modMatiere;
            this.prixBase = prixBase;
            this.modId = id;
        }

        /// <summary>
        /// Changer la gamme d'un module
        /// </summary>
        /// <param name="g">La gamme</param>
        public void changerGamme(Gamme g) {
			this.modGamme = g;
		}

		/// <summary>
		/// Changer la matière d'un module
		/// </summary>
		/// <param name="m">La matière</param>
		public void changerMatiere(Matiere m) {
			this.modMatiere = m;
		}

		/// <summary>
		/// Modifier un paramètre d'un module
		/// </summary>
		/// <param name="p">Le paramètre</param>
		public void modifierParametre(Parametre p) {
			int i = modParametres.FindIndex(x => x.parId == p.parId);
			modParametres.RemoveAt(i);
			modParametres.Insert(i, p);
		}
		
		public object Clone() {
            return this.MemberwiseClone();
        }
	}
}
