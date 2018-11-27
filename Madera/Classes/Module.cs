using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Module
	{
		public int modID { get; set; }
		public string modLibele { get; set; }
		public Gamme modGamme { get; set; }
		public Matiere modMatiere { get; set; }
		public double prixBase { get; set; }
		public List<Parametre> modParametres { get; set; }

		public Module(int modID, string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase, List<Parametre> modParametres)
		{
			this.modID = modID;
			this.modLibele = modLibele;
			this.modGamme = modGamme;
			this.modMatiere = modMatiere;
			this.prixBase = prixBase;
			this.modParametres = modParametres;
		}
	}
}
