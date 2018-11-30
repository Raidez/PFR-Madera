using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Gamme
	{
		public Guid gamId { get; set; }
		public string gamLibelle { get; set; }
		public static List<Gamme> listGamme = new List<Gamme>();
		

		public Gamme(string gamLibelle)
		{
			this.gamLibelle = gamLibelle;
			this.gamId = Guid.NewGuid();
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

		public void ajoutGamme() {
			try
			{
				listGamme.FindIndex(x => x.gamId == this.gamId);
			}
			catch (Exception e)
			{
				throw new Exception("Gamme déjà existante");
			}

			listGamme.Add(this);
		}

		public static void modifierGamme(Gamme g) {
			int i = listGamme.FindIndex(x => x.gamId == g.gamId);
			listGamme.RemoveAt(i);
			listGamme.Insert(i, g);
		}

		public static bool supprimeGamme(Guid gamId) {
			try {
				listGamme.RemoveAt(listGamme.FindIndex(x => x.gamId == gamId));
			} catch (Exception e) {
				return false;
			}

			return true;
			
		}
	}
}
