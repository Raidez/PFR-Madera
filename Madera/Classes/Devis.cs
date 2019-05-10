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
        public Guid devId;
        public int devStatut;
        public DateTime devDateCreation;
        public DateTime devDateSignature;
        public DateTime devDateFacture;
        public double devMontantFacture;
        public Client devClient;
        public Salarie devSalarie;
        public List<Module> modules = new List<Module>();

        public Devis(Guid id, int statut, DateTime dateCreation, DateTime dateSignature, DateTime dateFacture, double montantFacture, Client client, Salarie salarie)
        {
            devId = id;
            devStatut = statut;
            devDateCreation = dateCreation;
            devDateSignature = dateSignature;
            devDateFacture = dateFacture;
            devMontantFacture = montantFacture;
            devClient = client;
            devSalarie = salarie;
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
            try
            {
                modules.Add(module);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ajouter module erreur : " + ex);
                return false;
            }
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
