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
		public static List<Module> listModule = new List<Module>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="modLibele"></param>
		/// <param name="modGamme"></param>
		/// <param name="modMatiere"></param>
		/// <param name="prixBase"></param>
		/// <param name="modParametres"></param>
		public Module(string modLibele, Gamme modGamme, Matiere modMatiere, double prixBase, List<Parametre> modParametres)
		{
			this.modLibele = modLibele;
			this.modGamme = modGamme;
			this.modMatiere = modMatiere;
			this.prixBase = prixBase;
			this.modParametres = modParametres;
			this.modId = Guid.NewGuid();
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
		

		/// <summary>
		/// Ajout d'un module dans la liste LazyLoad
		/// </summary>
		public void ajouterModule()
		{
			try {
				listModule.FindIndex(x => x.modId == this.modId);
			}
			catch (Exception) {
				throw new Exception("Module déjà existant");
			}

			listModule.Add(this);
		}

		/// <summary>
		/// Cherche un module dans la liste de LazyLoad avec son GUID
		/// </summary>
		/// <param name="modId">GUID du module</param>
		/// <returns>Le module trouvé</returns>
		public static Module afficherModule(Guid modId) {
			return listModule.Find(x => x.modId == modId);
		}

		/// <summary>
		/// Modifier un module
		/// </summary>
		/// <param name="m">Le module</param>
		public static void modifierModule(Module m)
		{
			int i = listModule.FindIndex(x => x.modId == m.modId);
			listModule.RemoveAt(i);
			listModule.Insert(i, m);
		}

		/// <summary>
		/// Suppression d'un module
		/// </summary>
		/// <param name="modId">Le module</param>
		/// <returns>Vrai si réussi | Faux en cas d'erreur</returns>
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
		
		public object Clone() {
            return this.MemberwiseClone();
        }
	}
}
