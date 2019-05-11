using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Salarie
	{
		public Guid salId { get; set; }
		public string salNom { get; set; }
		public string salPrenom { get; set; }
		public string salMail { get; set; }
		public string salTel { get; set; }
		public bool salCommercial { get; set; }

		public Salarie(Guid salId, string salNom, string salPrenom, string salMail, string salTel, bool salCommercial) {
			this.salNom = salNom;
			this.salPrenom = salPrenom;
			this.salMail = salMail;
			this.salTel = salTel;
			this.salCommercial = salCommercial;
			this.salId = Guid.NewGuid();
		}
	}
}
