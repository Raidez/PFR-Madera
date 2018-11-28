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
		public static List<Gamme> listGamme { get; set; }

		public Gamme(int gamId, string gamLibelle)
		{
			this.gamId = gamId;
			this.gamLibelle = gamLibelle;
		}

		public static void _init (){
			listGamme = new List<Gamme>();
			listGamme.Add(new Gamme(1, "Basic"));
			listGamme.Add(new Gamme(2, "Standard"));
			listGamme.Add(new Gamme(3, "Premium"));
		}

		public static void ajoutGamme(Gamme g) {
			listGamme.Add(g);
		}

		public static void modifierGamme(Gamme g) {

		}

		public static bool supprimeGamme(Gamme g) {
			

			return true;
		}
	}
}
