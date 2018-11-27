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

		public Gamme(int gamId, string gamLibelle)
		{
			this.gamId = gamId;
			this.gamLibelle = gamLibelle;
		}
	}
}
