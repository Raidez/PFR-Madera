using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Gamme
	{
		public int gamId { get; set; }
		public string gamLibelle { get; set; }
		public static List<Gamme> listGamme { get; set; } = new List<Gamme>();
		

		public Gamme(string gamLibelle)
		{
			this.gamLibelle = gamLibelle;
			this.gamId = listGamme.Count;
		}

		public static void _init (){
			listGamme.Add(new Gamme("Basic"));
			listGamme.Add(new Gamme("Standard"));
			listGamme.Add(new Gamme("Premium"));
		}

		public static void ajoutGamme(Gamme g) {
			listGamme.Add(g);
		}

		public static void modifierGamme(Gamme g) {
			listGamme.RemoveAt(g.gamId);
			listGamme.Insert(g.gamId, g);
		}

		public static bool supprimeGamme(Gamme g) {
			listGamme.RemoveAt(g.gamId);

			return true;
		}
	}
}
