using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera
{
    static class BDDExterne
    {
        public static string connString;
        public static NpgsqlConnection conn;
        public static void Open()
        {
            conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
            conn.Open();
        }
        #region client
        public static Boolean AjouterClient(Client monClient)
        {
            try
            {
                NpgsqlCommand MyCmd = null;
                // id , nom , prenom, nomRue,codePostal,ville,tel,email,numRue  
                string query = @"INSERT INTO ""Client"" VALUES ('" + monClient.cliId.ToString() + "','" + monClient.cliNom + "','" + monClient.cliPrenom + "','" + monClient.cliRue + "','" + monClient.cliCp + "','" + monClient.cliVille + "','" + monClient.cliTel + "','" + monClient.cliEmail + "','" + monClient.cliNumRue + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static Boolean SupprimerClient(string id)
        {
            try
            {
                string query = "DELETE FROM Client WHERE id = '" + id + "'";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
            finally
            {
                if (conn.State.ToString() == "Open")
                {
                    conn.Close();
                }
            }
        }

        public static List<Client> GetAllClients()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            List<Client> ListeClients = new List<Client>();
            string query = @"select id,nom,prenom,""nomRue"",""codePostal"",ville,tel, email,""numRue"" FROM ""Client""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Debug.WriteLine(dr[0].ToString() + " | " +  dr[1].ToString() + " | " + dr[2].ToString() + " | " + dr[3].ToString() + " | " + dr[4].ToString() + " | " + dr[5].ToString() + " | " + dr[6].ToString() + " | " + dr[7].ToString());
                ListeClients.Add(new Client(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString()));
            }
            conn.Close();
            return ListeClients;

        }
        #endregion

        #region devis 
        #endregion

        #region fournisseur
        public static Boolean AjouterFounisseur(Fournisseur monFournisseur)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                NpgsqlCommand MyCmd = null;
                // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                // id,fouNom fouTel, fouAdrNumero,  fouAdrRue, fouAdrCodePostal,fouVille, fouPays, fouMail
                string query = @"INSERT INTO ""Fournisseur"" VALUES ('" + monFournisseur.fouId.ToString() + "','" + monFournisseur.fouNom + "','" + monFournisseur.fouTel + "','" + monFournisseur.fouAdrRue + "','" + monFournisseur.fouAdrCodePostal + "','" + monFournisseur.fouVille + "','" + monFournisseur.fouPays + "','" + monFournisseur.fouMail + "','" + monFournisseur.fouAdrNumero + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State.ToString() == "Open")
                {
                    conn.Close();
                }
            }
        }

        public static List<Fournisseur> GetAllFournisseur()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            List<Fournisseur> ListeFournisseur = new List<Fournisseur>();
            string query = @"SELECT id,nom,tel,""NUMRUE"",rue,""CODEPOSTAL"",ville,pays,mail FROM ""Fournisseur""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ListeFournisseur.Add(new Fournisseur(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), Int32.Parse(dr[3].ToString()), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString()));
            }
            conn.Close();
            return ListeFournisseur;

        }

        public static Boolean SupprimerFournisseur(string id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            try
            {
                string query = @"DELETE FROM ""Fournisseur"" WHERE id = '" + id + "'";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec supression fournisseur");
                Debug.WriteLine(ex);
                return false;
            }
            finally
            {
                if (conn.State.ToString() == "Open")
                {
                    conn.Close();
                }
            }
        }
            #endregion

        #region Gamme
        public static Boolean AjouterGamme(Gamme maGamme)
        {
            try
            {
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                NpgsqlCommand MyCmd = null;
                // id , nom , prenom, nomRue,codePostal,ville,tel,email,numRue  
                string query = @"INSERT INTO ""Gamme"" VALUES ('" + maGamme.gamId.ToString() + "','" + maGamme.gamLibelle + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State.ToString() == "Open")
                {
                    conn.Close();
                }
            }
        }

        public static List<Gamme> GetAllGammes()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            List<Gamme> ListeGamme = new List<Gamme>();
            string query = @"SELECT id,nom FROM ""Gamme""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ListeGamme.Add(new Gamme(new Guid(dr[0].ToString()), dr[1].ToString()));
            }
            conn.Close();
            return ListeGamme;

        }

        #endregion

        #region Matiere

        #endregion

        #region Module

        #endregion

        #region Parametre

        #endregion

        #region Salarie

        #endregion
    }
    
}
