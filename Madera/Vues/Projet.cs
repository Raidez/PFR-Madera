using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madera.Vues;

namespace Madera
{
    public partial class FormProjet : Form
    {
        public FormProjet()
        {
            InitializeComponent();
            BDDExterne.Open();
        }
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
    		ActionButtonGeneric.Deconnexion();
		}
    	
		void BtnConfig_Click(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoNextForm(this, new GestionConfiguration());
		}
		
		void BtnOuvrirProjetClick(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoNextForm(this, new OuvrirProjet());
		}
		
		void BtnNouveauProjetClick(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoNextForm(this, new Vues.CreerClient());
		}

    }
}
