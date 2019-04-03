using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Gamme
	{
		public Guid gamId { get; set; }
		public string gamLibelle { get; set; }
		
		/// <summary>
		/// Constructeur d'une gamme
		/// </summary>
		/// <param name="gamLibelle">Libellé d'une gamme</param>
		public Gamme(Guid id,string gamLibelle)
		{
			this.gamLibelle = gamLibelle;
            this.gamId = id;
		}

        
	}
}
