using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera
{
	class Client
	{
        public Guid cliId;
        public string cliNom;
        public string cliPrenom;
        public string cliRue;
        public string cliCp;
        public string cliVille;
        public string cliTel;
        public string cliEmail;
        public static List<Client> listeClient = new List<Client>;

        public Client(string cliNom, string cliPrenom, string cliRue, string cliCp, string cliVille, string cliTel, string cliEmail)
        {
            this.cliId = Guid.NewGuid();
            this.cliNom = cliNom;
            this.cliPrenom = cliPrenom;
            this.cliRue = cliRue;
            this.cliCp = cliCp;
            this.cliVille = cliVille;
            this.cliTel = cliTel;
            this.cliEmail = cliEmail;

    }

        public static void _init()
        {
            new Client("YoloLand1", "MonPrenom", "Rue de Miquaël Jacques Son", "72000", "Wonderland", "0123456789", "wallah@salam.us").ajouterClient();
            new Client("YoloLand1", "MonPrenom", "Rue de Miquaël Jacques Son", "72000", "Wonderland", "0123456789", "wallah@salam.us").ajouterClient();
            new Client("YoloLand1", "MonPrenom", "Rue de Miquaël Jacques Son", "72000", "Wonderland", "0123456789", "wallah@salam.us").ajouterClient();
        }

        public static Client _initOne()
        {
            return new Client("YoloLand1", "MonPrenom", "Rue de Miquaël Jacques Son", "72000", "Wonderland", "0123456789", "wallah@salam.us");
        }

		/// <summary>
        /// Ajout du client dans la liste de LazyLoad
        /// </summary>
        public void ajouterClient()
        {
            try {
                listeClient.FindIndex(x => x.cliId == this.cliId);
            }
            catch (Exception) {
                throw new Exception("Client déjà existant");
            }

            listeClient.Add(this);
        }
    }
}
