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
    public partial class OuvrirProjet : Form
    {
        public OuvrirProjet()
        {
            InitializeComponent();
            AjoutProjetVersListe("");
        }
        public void AjoutProjetVersListe(string nomProjet)
        {
            Button monProjet = new Button();
            monProjet.BackgroundImage = Madera.Properties.Resources.dossier;
            monProjet.Text = "";
            monProjet.FlatStyle = FlatStyle.Flat;
            monProjet.FlatAppearance.BorderSize = 0;

            Panel monPanel = new Panel();
            monPanel.Height = 106;
            monPanel.Width = 125;
            
                // size 103; 82
            FlowLayoutPanelListeProjet.Controls.Add(monPanel);
        }
    }
}
