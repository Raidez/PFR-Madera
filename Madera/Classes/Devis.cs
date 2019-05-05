using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
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
        public List<Module> modules = new List<Module>();

        public Devis()
        {

        }

        public void CreerDevis()
        {
            
        }

        public bool signerDevis()
        {

            return true;
        }

        public bool ajouterModule(Module module)
        {

            return true;
        }

        public bool retirerModule(Module module)
        {

            return true;
        }

        public void associerClient(Client client)
        {

        }

        public void associerSalarie(Salarie salarie)
        {

        }
        
	}
}
