using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Module
	{
		public Guid modId { get; set; }
		public string modLibele { get; set; }
		public Gamme modGamme { get; set; }
		public Matiere modMatiere { get; set; }
		public double prixBase { get; set; }
		public List<Parametre> modParametres { get; set; } = new List<Parametre>();
		public static List<Module> listModule = new List<Module>();

		public Module(string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase, List<Parametre> modParametres)
		{
			this.modLibele = modLibele;
			this.modGamme = modGamme;
			this.modMatiere = modMatiere;
			this.prixBase = prixBase;
			this.modParametres = modParametres;
			this.modId = Guid.NewGuid();
		}

		public void changerGamme(Gamme g) {
			this.modGamme = g;
		}

		public void changerMatiere(Matiere m) {
			this.modMatiere = m;
		}

		public void modifierParametre(Parametre p) {
			int i = modParametres.FindIndex(x => x.parId == p.parId);
			modParametres.RemoveAt(i);
			modParametres.Insert(i, p);
		}

		public static void _init() {
			Gamme g = new Gamme("Yolo");
			Matiere m = new Matiere("Ouaiche", Fournisseur._initOne());
			listModule.Add(new Module("Home Sweet Home", g, m, 11.5, Parametre.listParametre));
		}

		public void ajouterModule()
		{
			try
			{
				listModule.FindIndex(x => x.modId == this.modId);
			}
			catch (Exception e)
			{
				throw new Exception("Module déjà existant");
			}

			listModule.Add(this);
		}

		public static void modifierModule(Module m)
		{
			int i = listModule.FindIndex(x => x.modId == m.modId);
			listModule.RemoveAt(i);
			listModule.Insert(i, m);
		}

		public static bool supprimerModule(Guid modId)
		{
			try
			{
				listModule.RemoveAt(listModule.FindIndex(x => x.modId == modId));
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}
	}
}
