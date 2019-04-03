using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
    class BDDExterne
    {
        public static string connString;
        public static NpgsqlConnection conn;
        public static void Open()
        {
            conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
            conn.Open();
        }

        public static Boolean AjouterClient()
        {
            return true;
        }

        public static Boolean SupprimerClient()
        {
            return true;
        }
    }

}
