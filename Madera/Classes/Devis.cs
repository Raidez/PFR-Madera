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

        public void ajouterModule(Module module);
        public void retirerModule(Guid guidModule);
        public void associerClient(Client client);
        public void associerSalarie(Salarie salarie);
        public void creerDevis();
        public void signerDevis();
        public void facturerDevis();
	}
}
