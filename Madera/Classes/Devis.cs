using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Devis
	{
        public Guid devId;
        public int devStatut;
        public DateTime devDateCreation;
        public bool devAccord;
        public DateTime devDateSignature;
        public DateTime devDateFacture;
        public double devMontantFacture;
        public Client client;
        public Salarie salarie;
        
	}
}
