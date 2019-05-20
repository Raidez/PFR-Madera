﻿using Npgsql;
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
        public static string chaineConnection = "Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001";
        public static void Open()
        {

        }
        #region client
        public static Boolean AjouterClient(Client monClient)
        {
            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id , nom , prenom, nomRue,codePostal,ville,tel,email,numRue  
                string query = @"INSERT INTO ""Client"" VALUES ('" + monClient.cliId.ToString() + "','" + monClient.cliNom + "','" + monClient.cliPrenom + "','" + monClient.cliRue + "','" + monClient.cliCp + "','" + monClient.cliVille + "','" + monClient.cliTel + "','" + monClient.cliEmail + "','" + monClient.cliNumRue + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
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
            foreach (Client item in BDDExterne.GetAllClients())
            {
                if (item.cliId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM ""Client"" CASCADE WHERE id = '" + id + "'";
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }

        public static List<Client> GetAllClients()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
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

        public static Client GetClient(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            
            string query = @"select id,nom,prenom,""nomRue"",""codePostal"",ville,tel, email,""numRue"" FROM ""Client where id = "+id+"";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Client OneClient = new Client(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                return OneClient;
            }
            conn.Close();
            return null;

        }
        
        
        #endregion

        #region devis 
        public static Boolean AjouterDevis(Devis monDevis)
        {
            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                // id,fouNom fouTel, fouAdrNumero,  fouAdrRue, fouAdrCodePostal,fouVille, fouPays, fouMail
                string query = @"INSERT INTO public.devis(id, status, date_creation, ""id_Client"", ""id_Salarie"")VALUES ('" + monDevis.devId.ToString() + "'," + monDevis.devStatut + ", '"+ DateTime.Now.Year + "-" + DateTime.Now.Month + "-"+ DateTime.Now.Day + "',  '" + monDevis.devClient.cliId.ToString() + "','"+monDevis.devSalarie.salId.ToString() + "');";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static List<Devis> GetAllDevis()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            List<Devis> listeDevis = new List<Devis>();
            string query = @"SELECT id,status,date_creation,date_signature,date_facture,montant_facture,""id_Client"",""id_Salarie"" FROM ""devis""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                listeDevis.Add(new Devis(new Guid(dr[0].ToString()), Int32.Parse(dr[1].ToString()), DateTime.Parse(dr[2].ToString()), DateTime.Parse(dr[3].ToString()), DateTime.Parse(dr[4].ToString()), double.Parse(dr[5].ToString()), BDDExterne.GetClient(dr[6].ToString()),BDDExterne.GetSalarie(dr[7].ToString())));
            }
            conn.Close();
            return listeDevis;
        }

        public static Boolean SupprimerDevis(string id)
        {
            foreach (Devis item in BDDExterne.GetAllDevis())
            {
                if (item.devId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM devis CASCADE WHERE id = '" + id + "'";
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region fournisseur
        public static Boolean AjouterFounisseur(Fournisseur monFournisseur)
        {

            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                // id,fouNom fouTel, fouAdrNumero,  fouAdrRue, fouAdrCodePostal,fouVille, fouPays, fouMail
                string query = @"INSERT INTO ""Fournisseur"" VALUES ('" + monFournisseur.fouId.ToString() + "','" + monFournisseur.fouNom + "','" + monFournisseur.fouTel + "','" + monFournisseur.fouAdrRue + "','" + monFournisseur.fouAdrCodePostal + "','" + monFournisseur.fouVille + "','" + monFournisseur.fouPays + "','" + monFournisseur.fouMail + "','" + monFournisseur.fouAdrNumero + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static List<Fournisseur> GetAllFournisseur()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
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

        public static Fournisseur GetFournisseur(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT id,nom,tel,""NUMRUE"",rue,""CODEPOSTAL"",ville,pays,mail FROM ""Fournisseur where id =" + id + "";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Fournisseur OneFournisseur = new Fournisseur(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), Int32.Parse(dr[3].ToString()), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                return OneFournisseur;
            }
            conn.Close();
            return null;

        }

        public static Boolean SupprimerFournisseur(string id)
        {
            foreach (Fournisseur item in BDDExterne.GetAllFournisseur())
            {
                if (item.fouId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection(chaineConnection);
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM ""Fournisseur"" CASCADE WHERE id = '" + id + "'";
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
            #endregion

        #region Gamme
        public static Boolean AjouterGamme(Gamme maGamme)
        {
            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id , nom , prenom, nomRue,codePostal,ville,tel,email,numRue  
                string query = @"INSERT INTO ""Gamme"" VALUES ('" + maGamme.gamId.ToString() + "','" + maGamme.gamLibelle + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        public static List<Gamme> GetAllGammes()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
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

        public static Gamme GetGamme(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT id,nom FROM ""Gamme where id ="+ id + "";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Gamme OneGamme = new Gamme(new Guid(dr[0].ToString()), dr[1].ToString());
                return OneGamme;
            }
            conn.Close();
            return null;

        }

        public static Boolean SupprimerGamme(string id)
        {
            foreach (Gamme item in BDDExterne.GetAllGammes())
            {
                if (item.gamId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM ""Gamme"" CASCADE WHERE id = '" + id + "'";
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Matiere
        public static Boolean AjouterMatiere(Matiere maMatiere)
        {
            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id , nom , prenom, nomRue,codePostal,ville,tel,email,numRue  
                string query = @"INSERT INTO ""Matiere"" VALUES ('" + maMatiere.matId + "','" + maMatiere.matLibelle + "','" + maMatiere.matFournisseur.fouId +  ")";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static List<Matiere> GetAllMatiere()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            List<Matiere> ListeMatiere = new List<Matiere>();
            string query = @"SELECT id, nom, ""Fournisseur""FROM ""Matiere""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ListeMatiere.Add(new Matiere(new Guid(dr[0].ToString()), dr[1].ToString(),BDDExterne.GetFournisseur(dr[2].ToString())));
            }
            conn.Close();
            return ListeMatiere;
        }

        public static Matiere GetMatiere(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT id, nom, ""Fournisseur""FROM ""Matiere" + id + "";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Matiere OneMatiere = new Matiere(new Guid(dr[0].ToString()), dr[1].ToString(), BDDExterne.GetFournisseur(dr[2].ToString()));
                return OneMatiere;
            }
            conn.Close();
            return null;

        }


        public static Boolean SupprimerMatiere(string id)
        {
            foreach (Matiere item in BDDExterne.GetAllMatiere())
            {
                if (item.matId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM ""Matiere"" CASCADE WHERE id = '" + id + "'";
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Module
        public static Boolean AjouterModule(Module monModule)
        {
            return true;
        }

        public static List<Module> GetAllModules()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            List<Module> ListeModules = new List<Module>();
            string query = @"SELECT id, ""nom "", prix_base, ""uniteUsage"",""matiere"",""gamme"",""uniteUsage"" FROM ""Module """;
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Debug.WriteLine("id : " + dr[0].ToString());
                Debug.WriteLine("nom : " + dr[1].ToString());
                Debug.WriteLine("prix_base : " + dr[2].ToString());
                Debug.WriteLine("unite usage : " + dr[3].ToString());
                Debug.WriteLine("matiere : " + dr[4].ToString());

                ListeModules.Add(new Module(Guid.Parse(dr[0].ToString()), dr[1].ToString(),BDDExterne.GetGamme(dr[5].ToString()),BDDExterne.GetMatiere(dr[4].ToString()),double.Parse(dr[2].ToString()),BDDExterne.GetAllParametreByModule(dr[0].ToString()),dr[6].ToString()));
            }
            conn.Close();
            return ListeModules;
        }

        public static Module GetModule(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT id, ""nom "", prix_base, ""uniteUsage"",""matiere"",""gamme"",""uniteUsage"" FROM ""Module where id= =" + id + "";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Module OneModule = new Module(Guid.Parse(dr[0].ToString()), dr[1].ToString(), BDDExterne.GetGamme(dr[5].ToString()), BDDExterne.GetMatiere(dr[4].ToString()), double.Parse(dr[2].ToString()), BDDExterne.GetAllParametreByModule(dr[0].ToString()), dr[6].ToString());
                return OneModule;
            }
            conn.Close();
            return null;

        }
        
        public static Boolean SupprimerModule(string id)
        {
            foreach (Module item in BDDExterne.GetAllModules())
            {
                if (item.modId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection("Host=hosting-1001.netsteel.space;Username=madera;Password=me2d97m29;Database=madera;Port=51001");
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM module CASCADE WHERE id == '" + id;
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Parametre
        public static Boolean AjouterParametre(Parametre monParametre)
        {
            return true;
        }

        public static List<Parametre> GetAllParametreByModule(string moduleID)
        {
            List<Parametre> ListeParametre = new List<Parametre>();
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            string query = @"SELECT par_id, par_nom, mod_id FROM parametre where mod_id ='" + moduleID + "'";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ListeParametre.Add(new Parametre(new Guid(dr[0].ToString()), dr[1].ToString(), 0 ));
            }
            conn.Close();

            return ListeParametre;
        }

        public static Parametre GetParametre(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT par_id, par_nom, mod_id FROM parametre where mod_id ='" + id + "'";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Parametre OneParametre = new Parametre(new Guid(dr[0].ToString()), dr[1].ToString(), 0);
                return OneParametre;
            }
            conn.Close();
            return null;

        }

        public static Boolean SupprimerParametre(string id)
        {
            return true;
        }
        #endregion

        #region Salarie
        public static Boolean AjouterSalerie(Salarie monSalerie)
        {
            try
            {
                NpgsqlConnection conn;
                conn = new NpgsqlConnection(chaineConnection);
                conn.Open();
                NpgsqlCommand MyCmd = null;
                // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                string query = @"INSERT INTO ""Salarie"" VALUES ('" + monSalerie.salId.ToString() + "','" + monSalerie.salNom + "','" + monSalerie.salPrenom + "','" + monSalerie.salMail + "','" + monSalerie.salTel + "','" + monSalerie.salCommercial.ToString() + "')";
                Debug.WriteLine(query);
                MyCmd = new NpgsqlCommand(query, conn);
                MyCmd.ExecuteNonQuery(); //Exécution
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public static List<Salarie> GetAllSalarie()
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();
            List<Salarie> ListeSalarie = new List<Salarie>();
            string query = @"SELECT id,nom,prenom,mail,tel,fonction FROM ""Salarie""";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                ListeSalarie.Add(new Salarie(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),  dr[3].ToString(), Int32.Parse(dr[4].ToString())));
            }
            conn.Close();
            return ListeSalarie;
            
        }

        public static Salarie GetSalarie(string id)
        {
            NpgsqlConnection conn;
            conn = new NpgsqlConnection(chaineConnection);
            conn.Open();

            string query = @"SELECT id,nom,prenom,mail,tel,fonction FROM ""Salarie"" where id ="+id+"";
            Debug.WriteLine(query);

            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            
            while (dr.Read())
            {
                Salarie OneSalarie = new Salarie(new Guid(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[3].ToString(), Int32.Parse(dr[4].ToString()));
                return OneSalarie;
            }
            conn.Close();
            return null;
            
        }
        

        public static Boolean SupprimerSalarie(string id)
        {
            foreach (Salarie item in BDDExterne.GetAllSalarie())
            {
                if (item.salId.ToString() == id)
                {
                    NpgsqlConnection conn;
                    conn = new NpgsqlConnection(chaineConnection);
                    conn.Open();
                    NpgsqlCommand MyCmd = null;
                    // id, nom ,tel,numrue,codepostal,ville,pays,mail,nom rue
                    string query = @"DELETE FROM ""Salarie"" WHERE id == '" + id;
                    Debug.WriteLine(query);
                    MyCmd = new NpgsqlCommand(query, conn);
                    MyCmd.ExecuteNonQuery(); //Exécution
                    conn.Close();
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
    
}
