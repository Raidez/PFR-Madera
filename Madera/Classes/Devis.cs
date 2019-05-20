using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Devis
	{
        public Guid devId { get; set; }
        public int devStatut { get; set; }
        public DateTime devDateCreation { get; set; }
        public bool devAccord { get; set; }
        public DateTime devDateSignature { get; set; }
        public DateTime devDateFacture { get; set; }
        public double devMontantFacture { get; set; }
        public Client client { get; set; }
        public Salarie salarie { get; set; }
        public List<Module> listeModules { get; set; }

        public void ajouterModule(Module aAjouter)
        {
			this.listeModules.Add(aAjouter);
        }

        public void retirerModule(Module aSupprimer)
        {
			this.listeModules.Remove(aSupprimer);
        }

        public void associerClient(Client aAssocier)
        {
			this.client = aAssocier;
        }

        public void associerSalarie(Salarie aAssocier)
        {
			this.salarie = aAssocier;
        }

        public void creerDevis()
        {
			this.devDateCreation = DateTime.Now;
        }

        public void signerDevis()
        {
			this.devDateSignature = DateTime.Now;
			this.devAccord = true;
        }

        public void facturerDevis()
        {
			this.devDateFacture = DateTime.Now;
        }
	}
}
