using System;
using System.Collections;
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

		public Gamme(int gamId, string gamLibelle)
		{
			this.gamLibelle = gamLibelle;
			this.gamId = gamId;
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

		public static bool supprimeGamme(int gamId) {
			listGamme.RemoveAt(gamId);

			return true;
		}
	}
}
