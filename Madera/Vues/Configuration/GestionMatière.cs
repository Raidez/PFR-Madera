/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 14:48
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Madera.Classes;

namespace Madera.Vues.Configuration
{
	/// <summary>
	/// Description of GestionMatière.
	/// </summary>
	public partial class GestionMatière : Form
	{
		public GestionMatière()
		{
			InitializeComponent();
			Reload();
		}
		
		void Deconnexion(object sender, FormClosedEventArgs e)
		{
    		ActionButtonGeneric.Deconnexion();
		}
    	
    	void BtnRetour_Click(object sender, EventArgs e)
    	{
    		ActionButtonGeneric.GoBack(this);
		}
		
		void Reload()
		{
			// ajout des fournisseurs dans les combobox
			ComboxItem item;
			foreach (Fournisseur f in BDDExterne.GetAllFournisseur())
			{
				item = new ComboxItem(f.fouNom, f.fouId);
				CbxFournisseurModifier.Items.Add(item);
			}

            List<ComboxItem> data = new List<ComboxItem>();
            foreach (Fournisseur itemf in BDDExterne.GetAllFournisseur())
            {
                data.Add(new ComboxItem() { Value = itemf.fouId, Text = itemf.fouNom });
            }

            CbxFournisseurAjouter.DisplayMember = "Text";
            CbxFournisseurAjouter.ValueMember = "Value";
            CbxFournisseurAjouter.DataSource = data;

            // ajout des matières pour suppression
            foreach (Matiere m in BDDExterne.GetAllMatiere())
			{
				item = new ComboxItem(m.matLibelle, m.matId);
				CbxMatièreSupprimer.Items.Add(item);
			}
            List<ComboxItem> data2 = new List<ComboxItem>();
            foreach (Matiere itemm in BDDExterne.GetAllMatiere())
            {
                data2.Add(new ComboxItem() { Value = itemm.matId, Text = itemm.matLibelle });
            }

            CbxMatièreSupprimer.DisplayMember = "Text";
            CbxMatièreSupprimer.ValueMember = "Value";
            CbxMatièreSupprimer.DataSource = data2;
        }
		
		void BtnAjouterClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TbxMatièreAjouter.Text) || CbxFournisseurAjouter.SelectedIndex == -1)
			{
			    MessageBox.Show("Vous devez écrire le nom de la matière et choisir un fournisseur !");
			}
			else
			{

                Fournisseur f = BDDExterne.GetFournisseur(CbxFournisseurAjouter.SelectedValue.ToString());
				Matiere m = new Matiere(Guid.NewGuid(), TbxMatièreAjouter.Text, f);
				if (BDDExterne.AjouterMatiere(m))
				{
					MessageBox.Show("La matière a bien été ajoutée !");
                    
				}
				else
				{
					MessageBox.Show("La matière n'a pas été ajoutée correctement !");
				}
			}
		}
		
		void BtnSupprimerClick(object sender, EventArgs e)
		{
			if (CbxMatièreSupprimer.SelectedIndex == -1)
			{
				MessageBox.Show("Vous devez choisir une matière à supprimer !");
			}
			else
			{
				if (BDDExterne.SupprimerMatiere(CbxMatièreSupprimer.SelectedValue.ToString()))
				{
					MessageBox.Show("Matière supprimée !");
                    
				}
				else
				{
					MessageBox.Show("La matière n'a pas été supprimée correctement");
				}
			}
		}
		
		void BtnModifierClick(object sender, EventArgs e)
		{
			if (CbxMatièreModifier.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TbxMatièreModifier.Text) || CbxFournisseurModifier.SelectedIndex == -1)
			{
				MessageBox.Show("Vous devez choisir la matière et le fournisseur associé !");
			}
			else
			{
				throw new NotImplementedException("Modification matière");
			}
		}
		
		
	}
}
