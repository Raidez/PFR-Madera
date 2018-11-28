using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Matiere
	{
		public int matID { get; set; }
		public string matLibelle { get; set; }
		public Fournisseur matFournisseur { get; set; }

		public Matiere(int matID, string matLibelle, Fournisseur matFournisseur)
		{
			this.matID = matID;
			this.matLibelle = matLibelle;
			this.matFournisseur = matFournisseur;
		}

	}
}
