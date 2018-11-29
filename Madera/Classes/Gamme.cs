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
		public static List<Gamme> listGamme = new List<Gamme>();
		

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
			int i = listGamme.FindIndex(x => x.gamId == g.gamId);
			listGamme.RemoveAt(i);
			listGamme.Insert(i, g);
		}

		public static bool supprimeGamme(int gamId) {
			try {
				listGamme.RemoveAt(listGamme.FindIndex(x => x.gamId == gamId));
			} catch (Exception e) {
				return false;
			}

			return true;
			
		}
	}
}
