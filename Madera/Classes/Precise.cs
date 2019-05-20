using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
    class Precise
    {
        public Guid _id;
        public Parametre _paremetre;
        public Devis _devis;
        public double _valeur;

        public Precise(Guid id, Parametre parametre, Devis devis, double valeur)
        {
            _id = id;
            _paremetre = parametre;
            _devis = devis;
            _valeur = valeur;
        }
    }
}
