using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        }

        private void OuvrirProjet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Tag = i;
                flowLayoutPanelListeProjet.Controls.Add(button);
            }
        }
    }
}
