﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Classes
{
	class Matiere
	{
		public Guid matId { get; set; }
		public string matLibelle { get; set; }
		public Fournisseur matFournisseur { get; set; }
		public static List<Matiere> listMatiere = new List<Matiere>();

		public Matiere(string matLibelle, Fournisseur matFournisseur)
		{
			this.matLibelle = matLibelle;
			this.matFournisseur = matFournisseur;
			this.matId = Guid.NewGuid();
		}

		public static void _init() {
			Fournisseur fou = new Fournisseur("YoloLand1", "0123456789", 5, "Rue de Miquaël Jacques Son", "72000", "Wonderland", "Pays de la Morphine", "wallah@salam.us");
			listMatiere.Add(new Matiere("Bois", fou));
			listMatiere.Add(new Matiere("Acier", fou));
			listMatiere.Add(new Matiere("Papier", fou));
		}

		public void ajouterMatiere()
		{
			try
			{
				listMatiere.FindIndex(x => x.matId == this.matId);
			}
			catch (Exception e)
			{
				throw new Exception("Matière déjà existante");
			}

			listMatiere.Add(this);
		}

		public static void modifierMatiere(Matiere m)
		{
			int i = listMatiere.FindIndex(x => x.matId == m.matId);
			listMatiere.RemoveAt(i);
			listMatiere.Insert(i, m);
		}

		public static bool supprimerMatiere(Guid matId)
		{
			try
			{
				listMatiere.RemoveAt(listMatiere.FindIndex(x => x.matId == matId));
			}
			catch (Exception e)
			{
				return false;
			}

			return true;
		}

	}
}
