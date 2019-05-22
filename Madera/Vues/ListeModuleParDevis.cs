using Madera.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera
{
    public partial class ListeModuleParDevis : Form
    {
        List<ComboxItem> data = new List<ComboxItem>();
        List<ComboxItem> dataModuleDevis = new List<ComboxItem>();
        Devis monDevis;
        public ListeModuleParDevis(string idDevis)
        {
            

            InitializeComponent();
            monDevis = BDDExterne.GetDevis(idDevis);
            labelNomClient.Text = monDevis.devClient.cliNom + " " + monDevis.devClient.cliPrenom;
            labelDevisDateCreation.Text = monDevis.devDateCreation.ToShortDateString();


            foreach (Module item in BDDExterne.GetAllModules())
            {
                data.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele});
            }
            listBoxModuleDisponible.DisplayMember = "Text";
            listBoxModuleDisponible.ValueMember = "Value";
            listBoxModuleDisponible.DataSource = data;

            foreach  (Module item in BDDExterne.GetModulesByDevis(idDevis))
            {
                dataModuleDevis.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }


            listBoxModuleDevis.DisplayMember = "Text";
            listBoxModuleDevis.ValueMember = "Value";
            listBoxModuleDevis.DataSource = dataModuleDevis;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Module monMod = BDDExterne.GetModule(listBoxModuleDisponible.SelectedValue.ToString());
            int newNumMod = BDDExterne.getMaxNumModuleByDevis(monDevis.devId.ToString());
            newNumMod++;
            foreach (Parametre item in monMod.modParametres)
            {

                string query = @"INSERT INTO public.precise(id, id_parametre, id_devis, valeur, num_module) VALUES ('" + Guid.NewGuid().ToString() + "' , '" + item.parId.ToString() + "', '" + monDevis.devId.ToString() + "',0, " + newNumMod +")";
                
                if (BDDExterne.Insert(query) == false)
                {
                    MessageBox.Show("echec insert");
                }
            }
            dataModuleDevis.Clear();
            foreach (Module item in BDDExterne.GetModulesByDevis(monDevis.devId.ToString()))
            {
                dataModuleDevis.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }

            listBoxModuleDevis.DataSource = null;
            listBoxModuleDevis.Items.Clear();
            listBoxModuleDevis.DisplayMember = "Text";
            listBoxModuleDevis.ValueMember = "Value";
            listBoxModuleDevis.DataSource = dataModuleDevis;

            // ----
            monDevis = BDDExterne.GetDevis(monDevis.devId.ToString());
            labelNomClient.Text = monDevis.devClient.cliNom + " " + monDevis.devClient.cliPrenom;
            labelDevisDateCreation.Text = monDevis.devDateCreation.ToShortDateString();


            foreach (Module item in BDDExterne.GetAllModules())
            {
                data.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }
            listBoxModuleDisponible.DisplayMember = "Text";
            listBoxModuleDisponible.ValueMember = "Value";
            listBoxModuleDisponible.DataSource = data;

            foreach (Module item in BDDExterne.GetModulesByDevis(monDevis.devId.ToString()))
            {
                dataModuleDevis.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }


            listBoxModuleDevis.DisplayMember = "Text";
            listBoxModuleDevis.ValueMember = "Value";
            listBoxModuleDevis.DataSource = dataModuleDevis;




        }

        private void listBoxModuleDisponible_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listBoxModuleDevis_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxParam.DataSource = null;
            listBoxParam.Items.Clear();
            List<ComboxItem> listComboxItemParam = new List<ComboxItem>();
            if (listBoxModuleDevis.SelectedIndex != -1)
            {
                foreach (Parametre monParam in monDevis.modules[listBoxModuleDevis.SelectedIndex].modParametres)
                {
                    listComboxItemParam.Add(new ComboxItem() { Value = monParam.parIdValeur, Text = monParam.parNom + " " + monParam.parValeur + " " + monDevis.modules[listBoxModuleDevis.SelectedIndex].uniteUsage });
                }
                listBoxParam.DisplayMember = "Text";
                listBoxParam.ValueMember = "Value";
                listBoxParam.DataSource = listComboxItemParam;
            }


        }

        private void listBoxParam_DoubleClick(object sender, EventArgs e)
        {
            if (BDDExterne.ModifierValeurParam(listBoxParam.SelectedValue.ToString(), Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("entrer la nouvelle valeur", "Title", "").ToString()))== false) 
            {
                MessageBox.Show("Erreur modification de la valeur");
            }
            listBoxParam.DataSource = null;
            listBoxParam.Items.Clear();
            List<ComboxItem> listComboxItemParam = new List<ComboxItem>();
            
            monDevis = BDDExterne.GetDevis(monDevis.devId.ToString());
            foreach (Parametre monParam in monDevis.modules[listBoxModuleDevis.SelectedIndex].modParametres)
            {
                listComboxItemParam.Add(new ComboxItem() { Value = monParam.parIdValeur, Text = monParam.parNom + " " + monParam.parValeur + " " + monDevis.modules[listBoxModuleDevis.SelectedIndex].uniteUsage });
            }
            listBoxParam.DisplayMember = "Text";
            listBoxParam.ValueMember = "Value";
            listBoxParam.DataSource = listComboxItemParam;


        }

        private void listBoxParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(listBoxParam.SelectedValue);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            listBoxModuleDevis.Enabled = false;
            // listBoxParam.Items
            string numBox = listBoxParam.SelectedValue.ToString();
            if (BDDExterne.DeletePreciseByDevisAndNumModule(monDevis.devId.ToString(), BDDExterne.getNumModuleFromIDPrecise(numBox).ToString()) == false)
            {
                MessageBox.Show("echec supression ");
            }
            refresh();
            listBoxModuleDevis.Enabled = true;
        }
        public void refresh()
        {
            monDevis = BDDExterne.GetDevis(monDevis.devId.ToString());
            labelNomClient.Text = monDevis.devClient.cliNom + " " + monDevis.devClient.cliPrenom;
            labelDevisDateCreation.Text = monDevis.devDateCreation.ToShortDateString();


            foreach (Module item in BDDExterne.GetAllModules())
            {
                data.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }
            listBoxModuleDisponible.DisplayMember = "Text";
            listBoxModuleDisponible.ValueMember = "Value";
            listBoxModuleDisponible.DataSource = data;

            foreach (Module item in BDDExterne.GetModulesByDevis(monDevis.devId.ToString()))
            {
                dataModuleDevis.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
            }


            listBoxModuleDevis.DisplayMember = "Text";
            listBoxModuleDevis.ValueMember = "Value";
            listBoxModuleDevis.DataSource = dataModuleDevis;
        }
    }
}
