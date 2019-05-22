using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using IronPdf;

namespace Madera
{
	class Devis
	{
		public Guid devId;
		public int devStatut;
		public DateTime devDateCreation;
		public DateTime devDateSignature;
		public DateTime devDateFacture;
		public double devMontantFacture;
		public Client devClient;
		public Salarie devSalarie;
		public List<Module> modules = new List<Module>();

        public Devis(Guid id, int statut, DateTime dateCreation, DateTime dateSignature, DateTime dateFacture, double montantFacture, Client client, Salarie salarie)
        {
            devId = id;
            devStatut = statut;
            devDateCreation = dateCreation;
            devDateSignature = dateSignature;
            devDateFacture = dateFacture;
            devMontantFacture = montantFacture;
            devClient = client;
            devSalarie = salarie;
        }
        public Devis(Guid id, int statut, DateTime dateCreation, DateTime dateSignature, DateTime dateFacture, double montantFacture, Client client, Salarie salarie, List<Module> LesModules)
        {
            devId = id;
            devStatut = statut;
            devDateCreation = dateCreation;
            devDateSignature = dateSignature;
            devDateFacture = dateFacture;
            devMontantFacture = montantFacture;
            devClient = client;
            devSalarie = salarie;
            modules = LesModules;
        }
        public Devis(Guid id, int statut, DateTime dateCreation, Client client, Salarie salarie)
        {
            devId = id;
            devStatut = statut;
            devDateCreation = dateCreation;
            devClient = client;
            devSalarie = salarie;
        }

		public bool CreerDevis()
		{
			try
			{
				this.devDateCreation = DateTime.Now;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}

			return true;
		}

		public bool signerDevis()
		{
			try
			{
				this.devDateSignature = DateTime.Now;
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}

			return true;
		}

		public bool ajouterModule(Module module)
		{
			try
			{
				modules.Add(module);
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Ajouter module erreur : " + ex.Message);
				return false;
			}
		}

		public bool retirerModule(Module module)
		{
			try
			{
				modules.Remove(module);
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
				return false;
			}
			return true;
		}

		public void associerClient(Client client)
		{
			this.devClient = client;
		}

		public void associerSalarie(Salarie salarie)
		{
			this.devSalarie = salarie;
		}

		public void generePDF()
		{
			StringWriter stringWriter = new StringWriter();

			using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
			{
				writer.Write(
				"<!DOCTYPE html><html><head>" +
					"<style>" +
						"#calc {" +
							"top: 350px;" +
							"position: relative;" +
						"}" +
						"aside {" +
							"border: 1px solid;" +
							"padding: 0 10px 10px;" +
							"position: absolute;" +
						"}" +
						"aside ul {" +
							"list-style-type: none;" +
							"margin: 0;" +
							"padding: 0;" +
						"}" +
						"table {" +
							"width: 100%;" +
						"}" +
						"table td[colspan] {" +
							"text-align: right;" +
							"padding: 0 20px;" +
						"}" +
						"table tfoot tr td:last-child {" +
							"font-weight: bold;" +
						"}" +
						"#client {" +
							"min-width: 150px;" +
							"max-width: 500px;" +
							"top: 10px;" +
							"left: 10px;" +
						"}" +
						"#devis {" +
							"min-width: 300px;" +
							"max-width: 500px;" +
							"top: 150px;" +
							"right: 10px;" +
						"}" +
						"#logo {" +
							"position: absolute;" +
							"top: 0;" +
							"right: 0;" +
						"}" +
						"#logo img { width: 250px; }" +

						".right {" +
							"display: inline-block;" +
							"position: absolute;" +
							"right: 1em;" +
						"}" +
					"</style>" +
				"</head>" +
				"<body>" +
					"<section id=\"info\">" +

						"<aside id=\"client\">" +
							"<h2> Client</h2>" +
							"<ul>"+
				"<li><b>" + this.devClient.cliNom + "</b> " + this.devClient.cliPrenom + "</li>"+
				"<li>"+this.devClient.cliNumRue +" "+this.devClient.cliRue+"</li>"+
				"<li>"+this.devClient.cliCp+" <span class=\"right\">"+this.devClient.cliVille+"</span> </li>"+
				"</ul>" +
			"</aside>" +

			"<aside id = \"devis\">" +

				"<h2> Devis </h2>" +

				"<ul>"+

							"<li>N° de devis<span class=\"right\">5</span> </li>"+
							"<li>Date de cr&eacute;ation : <span class=\"right\">"+this.devDateCreation.ToShortDateString()+"</span></li>"+
							"<li> validité<span class=\"right\">25/07/2019</span> </li>"+
							"</ul>" +
						"</aside>" +

						"<figure id=\"logo\">" +

							"<img src='http://madera-construction.fr/images/site/logo.png'/>" +
						"</figure>" +
					"</section>" +

					"<section id=\"calc\">" +

						"<table>" +

							"<thead>" +

								"<tr>" +

									"<th> N° </th>" +
									"<th> Description</th>" +
									"<th> Unité</th>" +
									"<th> Prix</th>" +
								"</tr>" +
							"</thead>" +
							"<tbody>");
				double total = 0;
				foreach (Module module in BDDExterne.GetModulesByDevis(this.devId.ToString()))
				{
					writer.Write("<tr><td>"+module.num_module + "</td>");
					writer.Write("<td>"+module.modLibele + "</td>");
					writer.Write("<td>"+module.uniteUsage+"</td>");
					writer.Write("<td>"+ module.prixBase +" €</td></tr>");
					total += module.prixBase;
				}
				writer.Write("<tr></tr></tbody>"+
							"<tfoot>"+
								"<tr>"+
									"<td colspan = \"3\" > Hors taxes</td>"+
									"<td>" + total + " €</td>"+
								"</tr>"+
								"<tr>"+
									"<td colspan = \"3\" > Taxe valeur ajoutée </td>"+
									"<td> 20% </td>"+
								"</tr>"+
								"<tr>"+
									"<td colspan=\"3\"> Toutes taxes comprises </td>"+
									"<td>" + total * 1.2 + " €</td>"+
								"</tr>"+
							"</tfoot>"+
						"</table>"+
					"</section>"+
				"</body></html>");

				//writer.AddAttribute(HtmlTextWriterAttribute.Src, @"C:\Users\maxna\source\repos\PFR-Madera\Madera\Resources\logo.png");
				//writer.AddAttribute(HtmlTextWriterAttribute.Alt, "Madera");
				//writer.RenderBeginTag(HtmlTextWriterTag.Img); // Begin #3
				//writer.RenderEndTag(); // End #3

				/*writer.Write(
					"Client : " + this.devClient.cliNom + " " + this.devClient.cliPrenom + "<br>" +
					"<br>" + this.devDateCreation.ToString() +
					"<br><br> Modules associés au projet : <br>"
				);
				foreach (Module module in BDDExterne.GetModulesByDevis(this.devId.ToString()))
				{
					writer.Write(module.modLibele + " " + module.uniteUsage + "<br>");
					foreach (Parametre param in module.modParametres)
					{
						writer.Write(param.parNom + " " + param.parValeur + "<br>");
					}
					writer.Write("<br><br>");
				}*/
			}

			System.IO.File.WriteAllText(@"C:\Users\Public\WriteText.html", stringWriter.ToString());

			var Renderer = new IronPdf.HtmlToPdf();
			var PDF = Renderer.RenderHTMLFileAsPdf(@"C:\Users\Public\WriteText.html");
			PDF.SaveAs(@"C:\Users\Public\Devis_du_"+DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day+"_"+DateTime.Now.Hour+DateTime.Now.Minute+DateTime.Now.Second+".pdf");
		}
	}
}
