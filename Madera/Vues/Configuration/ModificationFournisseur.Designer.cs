namespace Madera
{
    partial class ModificationFournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.TextBoxEmail = new System.Windows.Forms.TextBox();
        	this.label10 = new System.Windows.Forms.Label();
        	this.TextBoxNumRue = new System.Windows.Forms.TextBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.BtnReset = new System.Windows.Forms.Button();
        	this.BtnModifier = new System.Windows.Forms.Button();
        	this.ComboBoxPays = new System.Windows.Forms.ComboBox();
        	this.label9 = new System.Windows.Forms.Label();
        	this.TextBoxVille = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.TextBoxCodePostal = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.TextBoxRue = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.TextBoxTelephone = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.TextBoxFournisseur = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel5 = new System.Windows.Forms.Panel();
        	this.ImgLogo = new System.Windows.Forms.PictureBox();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.panel5.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
        	this.panel4.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// TextBoxEmail
        	// 
        	this.TextBoxEmail.Location = new System.Drawing.Point(151, 52);
        	this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxEmail.Name = "TextBoxEmail";
        	this.TextBoxEmail.Size = new System.Drawing.Size(120, 20);
        	this.TextBoxEmail.TabIndex = 20;
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Location = new System.Drawing.Point(111, 55);
        	this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(38, 13);
        	this.label10.TabIndex = 19;
        	this.label10.Text = "Mail  : ";
        	// 
        	// TextBoxNumRue
        	// 
        	this.TextBoxNumRue.Location = new System.Drawing.Point(151, 90);
        	this.TextBoxNumRue.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxNumRue.Name = "TextBoxNumRue";
        	this.TextBoxNumRue.Size = new System.Drawing.Size(63, 20);
        	this.TextBoxNumRue.TabIndex = 18;
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(60, 93);
        	this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(89, 13);
        	this.label8.TabIndex = 17;
        	this.label8.Text = "Numéro de rue  : ";
        	// 
        	// BtnReset
        	// 
        	this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
        	this.BtnReset.FlatAppearance.BorderSize = 0;
        	this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnReset.ForeColor = System.Drawing.Color.White;
        	this.BtnReset.Location = new System.Drawing.Point(614, 355);
        	this.BtnReset.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnReset.Name = "BtnReset";
        	this.BtnReset.Size = new System.Drawing.Size(79, 24);
        	this.BtnReset.TabIndex = 16;
        	this.BtnReset.Text = " Réinitialiser";
        	this.BtnReset.UseVisualStyleBackColor = false;
        	this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
        	// 
        	// BtnModifier
        	// 
        	this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
        	this.BtnModifier.FlatAppearance.BorderSize = 0;
        	this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnModifier.ForeColor = System.Drawing.Color.White;
        	this.BtnModifier.Location = new System.Drawing.Point(697, 355);
        	this.BtnModifier.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnModifier.Name = "BtnModifier";
        	this.BtnModifier.Size = new System.Drawing.Size(65, 24);
        	this.BtnModifier.TabIndex = 15;
        	this.BtnModifier.Text = "Valider";
        	this.BtnModifier.UseVisualStyleBackColor = false;
        	this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
        	// 
        	// ComboBoxPays
        	// 
        	this.ComboBoxPays.FormattingEnabled = true;
        	this.ComboBoxPays.Items.AddRange(new object[] {
			"France",
			"Allemagne",
			"Autriche",
			"Belgique",
			"Bulgarie",
			"Chypre",
			"Croatie",
			"Danemark",
			"Espagne",
			"Estonie",
			"Finlande",
			"France",
			"Grèce",
			"Hongrie",
			"Irlande",
			"Italie",
			"Lettonie",
			"Lituanie",
			"Luxembourg",
			"Malte",
			"Pays-Bas",
			"Pologne",
			"Portugal",
			"Roumanie",
			"Royaume-Uni ",
			"Slovaquie",
			"Slovénie",
			"Suède",
			"Tchéquie"});
        	this.ComboBoxPays.Location = new System.Drawing.Point(151, 162);
        	this.ComboBoxPays.Margin = new System.Windows.Forms.Padding(2);
        	this.ComboBoxPays.Name = "ComboBoxPays";
        	this.ComboBoxPays.Size = new System.Drawing.Size(92, 21);
        	this.ComboBoxPays.TabIndex = 14;
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(108, 165);
        	this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(39, 13);
        	this.label9.TabIndex = 13;
        	this.label9.Text = "Pays  :";
        	// 
        	// TextBoxVille
        	// 
        	this.TextBoxVille.Location = new System.Drawing.Point(393, 126);
        	this.TextBoxVille.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxVille.Name = "TextBoxVille";
        	this.TextBoxVille.Size = new System.Drawing.Size(199, 20);
        	this.TextBoxVille.TabIndex = 9;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(353, 129);
        	this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(35, 13);
        	this.label7.TabIndex = 8;
        	this.label7.Text = "Ville : ";
        	// 
        	// TextBoxCodePostal
        	// 
        	this.TextBoxCodePostal.Location = new System.Drawing.Point(151, 126);
        	this.TextBoxCodePostal.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxCodePostal.Name = "TextBoxCodePostal";
        	this.TextBoxCodePostal.Size = new System.Drawing.Size(62, 20);
        	this.TextBoxCodePostal.TabIndex = 7;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(76, 129);
        	this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(73, 13);
        	this.label6.TabIndex = 6;
        	this.label6.Text = "Code Postal : ";
        	// 
        	// TextBoxRue
        	// 
        	this.TextBoxRue.Location = new System.Drawing.Point(393, 90);
        	this.TextBoxRue.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxRue.Name = "TextBoxRue";
        	this.TextBoxRue.Size = new System.Drawing.Size(174, 20);
        	this.TextBoxRue.TabIndex = 5;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(353, 93);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(36, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Rue : ";
        	// 
        	// TextBoxTelephone
        	// 
        	this.TextBoxTelephone.Location = new System.Drawing.Point(393, 52);
        	this.TextBoxTelephone.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxTelephone.Name = "TextBoxTelephone";
        	this.TextBoxTelephone.Size = new System.Drawing.Size(120, 20);
        	this.TextBoxTelephone.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(319, 55);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(70, 13);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Téléphone  : ";
        	// 
        	// TextBoxFournisseur
        	// 
        	this.TextBoxFournisseur.Location = new System.Drawing.Point(151, 13);
        	this.TextBoxFournisseur.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxFournisseur.Name = "TextBoxFournisseur";
        	this.TextBoxFournisseur.Size = new System.Drawing.Size(120, 20);
        	this.TextBoxFournisseur.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(42, 16);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(107, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Nom du fournisseur : ";
        	// 
        	// panel5
        	// 
        	this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
        	this.panel5.Controls.Add(this.ImgLogo);
        	this.panel5.Location = new System.Drawing.Point(9, 9);
        	this.panel5.Margin = new System.Windows.Forms.Padding(0);
        	this.panel5.Name = "panel5";
        	this.panel5.Size = new System.Drawing.Size(766, 100);
        	this.panel5.TabIndex = 24;
        	// 
        	// ImgLogo
        	// 
        	this.ImgLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
        	this.ImgLogo.BackgroundImage = global::Madera.Resources.logo;
        	this.ImgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.ImgLogo.Location = new System.Drawing.Point(246, 0);
        	this.ImgLogo.Margin = new System.Windows.Forms.Padding(0);
        	this.ImgLogo.Name = "ImgLogo";
        	this.ImgLogo.Size = new System.Drawing.Size(300, 100);
        	this.ImgLogo.TabIndex = 0;
        	this.ImgLogo.TabStop = false;
        	// 
        	// panel4
        	// 
        	this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel4.Controls.Add(this.BtnRetour);
        	this.panel4.Location = new System.Drawing.Point(9, 499);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(766, 50);
        	this.panel4.TabIndex = 25;
        	// 
        	// BtnRetour
        	// 
        	this.BtnRetour.Anchor = System.Windows.Forms.AnchorStyles.Right;
        	this.BtnRetour.Location = new System.Drawing.Point(646, 0);
        	this.BtnRetour.Margin = new System.Windows.Forms.Padding(0);
        	this.BtnRetour.Name = "BtnRetour";
        	this.BtnRetour.Size = new System.Drawing.Size(120, 50);
        	this.BtnRetour.TabIndex = 13;
        	this.BtnRetour.Text = "Retour";
        	this.BtnRetour.UseVisualStyleBackColor = true;
        	this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
        	// 
        	// panel2
        	// 
        	this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel2.Controls.Add(this.BtnModifier);
        	this.panel2.Controls.Add(this.BtnReset);
        	this.panel2.Controls.Add(this.label8);
        	this.panel2.Controls.Add(this.TextBoxNumRue);
        	this.panel2.Controls.Add(this.ComboBoxPays);
        	this.panel2.Controls.Add(this.TextBoxEmail);
        	this.panel2.Controls.Add(this.label9);
        	this.panel2.Controls.Add(this.label7);
        	this.panel2.Controls.Add(this.TextBoxVille);
        	this.panel2.Controls.Add(this.label1);
        	this.panel2.Controls.Add(this.label10);
        	this.panel2.Controls.Add(this.label6);
        	this.panel2.Controls.Add(this.TextBoxCodePostal);
        	this.panel2.Controls.Add(this.TextBoxFournisseur);
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Controls.Add(this.TextBoxTelephone);
        	this.panel2.Controls.Add(this.label3);
        	this.panel2.Controls.Add(this.TextBoxRue);
        	this.panel2.Location = new System.Drawing.Point(9, 114);
        	this.panel2.Margin = new System.Windows.Forms.Padding(2);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(766, 383);
        	this.panel2.TabIndex = 26;
        	// 
        	// ModificationFournisseur
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(784, 561);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.panel4);
        	this.Controls.Add(this.panel5);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "ModificationFournisseur";
        	this.Text = "ModificationFournisseur";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deconnexion);
        	this.panel5.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
        	this.panel4.ResumeLayout(false);
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxVille;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxCodePostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxRue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxPays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxNumRue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panel2;
    }
}