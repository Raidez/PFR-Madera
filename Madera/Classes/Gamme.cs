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
		public static List<Gamme> listGamme { get; set; }

		public Gamme(int gamId, string gamLibelle)
		{
			this.gamId = gamId;
			this.gamLibelle = gamLibelle;
		}

		public void ajoutGamme(Gamme g) {
			listGamme.Add(g);
		}

		public void modifierGamme(Gamme g) {

		}

		public bool supprimeGamme(Gamme g) {
			

			return true;
		}
	}
}
