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
    public partial class GestionGamme : Form
    {
        public GestionGamme()
        {
            InitializeComponent();
        }

        private void BtnSupprimerGamme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gamme supprimé !");
        }

        private void BtnAjoutGamme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gamme ajouté !");
        }

        private void BtnModificationGamme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gamme modifié !");
        }
    }
}
