using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Parametre
	{
		public int parID { get; set; }
		public string parNom { get; set; }
		public Object parValeur { get; set; }

		public Parametre(int parID, string parNom, object parValeur)
		{
			this.parID = parID;
			this.parNom = parNom;
			this.parValeur = parValeur;
		}

	}
}
