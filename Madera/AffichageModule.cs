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
    public partial class AffichageModule : Form
    {
        public AffichageModule()
        {
            InitializeComponent();
        }

        //Ajouter un module dans le flow layout panel
        public void AjoutModule()
        {
            Button button1 = new Button();
            flowLayoutPanelListModule.Controls.Add(button1);
        }
    }
}
