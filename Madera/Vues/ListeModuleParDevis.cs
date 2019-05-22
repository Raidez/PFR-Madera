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
        List<Module> dataModuleDevis = new List<Module>();
        public ListeModuleParDevis(string idDevis)
        {
            

            InitializeComponent();
            

            foreach (Module item in BDDExterne.GetAllModules())
            {
                data.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele});
            }

            listBoxModuleDisponible.DisplayMember = "Text";
            listBoxModuleDisponible.ValueMember = "Value";
            listBoxModuleDisponible.DataSource = data;
            listBoxModuleDevis.DisplayMember = "Text";
            listBoxModuleDevis.ValueMember = "Value";
            listBoxModuleDevis.DataSource = dataModuleDevis;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxModuleDisponible_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Module monModule = BDDExterne.GetModule(listBoxModuleDisponible.SelectedValue.ToString());
            dataModuleDevis.Add(monModule);

            try
            {

                List<ComboxItem> data = new List<ComboxItem>();

                foreach (Module item in dataModuleDevis)
                {

                        data.Add(new ComboxItem() { Value = item.modId, Text = item.modLibele });
                    
                }

                listBoxModuleDevis.DisplayMember = "Text";
                listBoxModuleDevis.DataSource = data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
        }

        private void listBoxModuleDevis_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxParam.Items.Clear();
            foreach (Module item in dataModuleDevis)
            {
                if (item.modId == Guid.Parse(listBoxModuleDevis.SelectedValue.ToString()))
                {
                    foreach (Parametre monParam in item.modParametres)
                    {
                        listBoxParam.Items.Add(monParam.parNom + " " +  monParam.parValeur + " " + item.uniteUsage );
                    }
                }
            }
        }

        private void listBoxParam_DoubleClick(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.InputBox("entrer la nouvelle valeur", "Title", "");
        }

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
