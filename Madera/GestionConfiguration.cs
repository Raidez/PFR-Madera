﻿using System;
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
    public partial class GestionConfiguration : Form
    {
        public GestionConfiguration() {
            InitializeComponent();
        }
    	
		void BtnGestionGammesClick(object sender, EventArgs e) {
    		ActionBoutonGeneric.GoNextForm(this, new GestionGamme());
		}
    	
    	void BtnRetourClick(object sender, EventArgs e) {
    		ActionBoutonGeneric.GoBack(this);
		}
    }
}
