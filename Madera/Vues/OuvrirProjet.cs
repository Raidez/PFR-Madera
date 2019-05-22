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

namespace Madera.Vues
{
    public partial class OuvrirProjet : Form
    {
        public OuvrirProjet()
        {
            InitializeComponent();

            List<ComboxItem> data = new List<ComboxItem>();
            foreach (Client item in BDDExterne.GetAllClients())
            {
                data.Add(new ComboxItem() { Value = item.cliId, Text = item.cliNom + " " + item.cliPrenom });
            }

            
            
            listBoxClient.DisplayMember = "Text";
            listBoxClient.DataSource = data;


        }

        private void listBoxClient_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

            List<ComboxItem> data = new List<ComboxItem>();
            
            foreach (Devis item in BDDExterne.GetAllDevis())
            {
                if (item.devClient.cliId == Guid.Parse(listBoxClient.SelectedValue.ToString()))
                {
                    data.Add(new ComboxItem() { Value = item.devId, Text = item.devDateCreation.ToString() });
                }                
            }

            listBoxDevis.DisplayMember = "Text";
            listBoxDevis.DataSource = data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (listBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Veuillez choisir un Client");
                return;
            }
            if (listBoxDevis.SelectedValue == null)
            {
                MessageBox.Show("Veuillez choisir un devis");
                return;
            }
            ActionButtonGeneric.GoNextForm(this, new ListeModuleParDevis(listBoxDevis.SelectedValue.ToString()));

        }

        private void listBoxDevis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(listBoxDevis.SelectedValue.ToString());
        }
    }
}
