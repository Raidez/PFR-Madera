using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Madera.Vues.Configuration;

namespace Madera
{
    public partial class GestionConfiguration : Form
    {
        public GestionConfiguration()
        {
            InitializeComponent();
        }
    	
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
    		ActionButtonGeneric.Deconnexion();
		}
    	
    	void BtnRetour_Click(object sender, EventArgs e)
    	{
    		ActionButtonGeneric.GoBack(this);
		}
    	
		void BtnGamme_Click(object sender, EventArgs e)
		{
    		ActionButtonGeneric.GoNextForm(this, new GestionGamme());
		}
    	
    	void BtnFourn_Click(object sender, EventArgs e)
    	{
    		ActionButtonGeneric.GoNextForm(this, new GestionFournisseur());
		}
    	
		void BtnModuleClick(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoNextForm(this, new GestionModule());
		}
		
		void BtnGoMatièreClick(object sender, EventArgs e)
		{
			ActionButtonGeneric.GoNextForm(this, new GestionMatière());
		}
    }
}
