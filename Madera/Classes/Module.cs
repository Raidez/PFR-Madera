using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Module
	{
		public int modId { get; set; }
		public string modLibele { get; set; }
		public Gamme modGamme { get; set; }
		public Matiere modMatiere { get; set; }
		public double prixBase { get; set; }
		public List<Parametre> modParametres { get; set; } = new List<Parametre>();
		public static List<Module> listModule { get; set; } = new List<Module>();

		public Module(string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase, List<Parametre> modParametres)
		{
			this.modLibele = modLibele;
			this.modGamme = modGamme;
			this.modMatiere = modMatiere;
			this.prixBase = prixBase;
			this.modParametres = modParametres;
			this.modId = listModule.Count;
		}

		public void changerGamme(Gamme g) {
			this.modGamme = g;
		}

		public void changerMatiere(Matiere m) {
			this.modMatiere = m;
		}
	}
}
