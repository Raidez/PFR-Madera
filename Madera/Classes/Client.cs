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
        public string cliNumRue;
        public string cliRue;
        public string cliCp;
        public string cliVille;
        public string cliTel;
        public string cliEmail;
        public string cliPays;

        public Client(Guid cliId, string cliNom, string cliPrenom,string cliNumRue, string cliRue, string cliCp, string cliVille, string cliTel, string cliEmail)
        {
            this.cliId = cliId;
            this.cliNom = cliNom;
            this.cliPrenom = cliPrenom;
            this.cliNumRue = cliNumRue;
            this.cliRue = cliRue;
            this.cliCp = cliCp;
            this.cliVille = cliVille;
            this.cliTel = cliTel;
            this.cliEmail = cliEmail;
    }

        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}
