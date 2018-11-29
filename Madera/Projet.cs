using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madera
{
    public partial class Projet : Form
    {
        public Projet() {
            InitializeComponent();
        }
    	
		void BtnGestionConfigurationClick(object sender, EventArgs e) {
    		ActionButtonGeneric.GoNextForm(this, new GestionConfiguration());
		}
    	
    	void BtnDeconnectionClick(object sender, EventArgs e) {
    		ActionButtonGeneric.Deconnexion();
		}
    }
}
