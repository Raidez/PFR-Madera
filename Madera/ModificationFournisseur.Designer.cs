﻿namespace Madera
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
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.BtnModificationFournisseur = new System.Windows.Forms.Button();
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
        	this.BtnDeconnection = new System.Windows.Forms.Button();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.BtnReset = new System.Windows.Forms.Button();
        	this.panel1.SuspendLayout();
        	this.panel4.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// BtnRetour
        	// 
        	this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnRetour.Location = new System.Drawing.Point(671, 513);
        	this.BtnRetour.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnRetour.Name = "BtnRetour";
        	this.BtnRetour.Size = new System.Drawing.Size(123, 63);
        	this.BtnRetour.TabIndex = 26;
        	this.BtnRetour.Text = "Retour";
        	this.BtnRetour.UseVisualStyleBackColor = true;
        	this.BtnRetour.Click += new System.EventHandler(this.BtnRetourClick);
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.BtnReset);
        	this.panel1.Controls.Add(this.BtnModificationFournisseur);
        	this.panel1.Controls.Add(this.ComboBoxPays);
        	this.panel1.Controls.Add(this.label9);
        	this.panel1.Controls.Add(this.TextBoxVille);
        	this.panel1.Controls.Add(this.label7);
        	this.panel1.Controls.Add(this.TextBoxCodePostal);
        	this.panel1.Controls.Add(this.label6);
        	this.panel1.Controls.Add(this.TextBoxRue);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.TextBoxTelephone);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.TextBoxFournisseur);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Location = new System.Drawing.Point(16, 112);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(779, 396);
        	this.panel1.TabIndex = 23;
        	// 
        	// BtnModificationFournisseur
        	// 
        	this.BtnModificationFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
        	this.BtnModificationFournisseur.FlatAppearance.BorderSize = 0;
        	this.BtnModificationFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnModificationFournisseur.ForeColor = System.Drawing.Color.White;
        	this.BtnModificationFournisseur.Location = new System.Drawing.Point(683, 348);
        	this.BtnModificationFournisseur.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnModificationFournisseur.Name = "BtnModificationFournisseur";
        	this.BtnModificationFournisseur.Size = new System.Drawing.Size(65, 24);
        	this.BtnModificationFournisseur.TabIndex = 15;
        	this.BtnModificationFournisseur.Text = "Valider";
        	this.BtnModificationFournisseur.UseVisualStyleBackColor = false;
        	this.BtnModificationFournisseur.Click += new System.EventHandler(this.BtnModificationFournisseurClick);
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
        	this.ComboBoxPays.Location = new System.Drawing.Point(57, 181);
        	this.ComboBoxPays.Margin = new System.Windows.Forms.Padding(2);
        	this.ComboBoxPays.Name = "ComboBoxPays";
        	this.ComboBoxPays.Size = new System.Drawing.Size(177, 21);
        	this.ComboBoxPays.TabIndex = 14;
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(14, 185);
        	this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(39, 13);
        	this.label9.TabIndex = 13;
        	this.label9.Text = "Pays  :";
        	// 
        	// TextBoxVille
        	// 
        	this.TextBoxVille.Location = new System.Drawing.Point(53, 150);
        	this.TextBoxVille.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxVille.Name = "TextBoxVille";
        	this.TextBoxVille.Size = new System.Drawing.Size(181, 20);
        	this.TextBoxVille.TabIndex = 9;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(14, 150);
        	this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(35, 13);
        	this.label7.TabIndex = 8;
        	this.label7.Text = "Ville : ";
        	// 
        	// TextBoxCodePostal
        	// 
        	this.TextBoxCodePostal.Location = new System.Drawing.Point(88, 123);
        	this.TextBoxCodePostal.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxCodePostal.Name = "TextBoxCodePostal";
        	this.TextBoxCodePostal.Size = new System.Drawing.Size(146, 20);
        	this.TextBoxCodePostal.TabIndex = 7;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(14, 123);
        	this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(73, 13);
        	this.label6.TabIndex = 6;
        	this.label6.Text = "Code Postal : ";
        	// 
        	// TextBoxRue
        	// 
        	this.TextBoxRue.Location = new System.Drawing.Point(53, 97);
        	this.TextBoxRue.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxRue.Name = "TextBoxRue";
        	this.TextBoxRue.Size = new System.Drawing.Size(181, 20);
        	this.TextBoxRue.TabIndex = 5;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(14, 97);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(36, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Rue : ";
        	// 
        	// TextBoxTelephone
        	// 
        	this.TextBoxTelephone.Location = new System.Drawing.Point(84, 71);
        	this.TextBoxTelephone.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxTelephone.Name = "TextBoxTelephone";
        	this.TextBoxTelephone.Size = new System.Drawing.Size(150, 20);
        	this.TextBoxTelephone.TabIndex = 3;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(14, 71);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(66, 13);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "téléphone  : ";
        	// 
        	// TextBoxFournisseur
        	// 
        	this.TextBoxFournisseur.Location = new System.Drawing.Point(127, 41);
        	this.TextBoxFournisseur.Margin = new System.Windows.Forms.Padding(2);
        	this.TextBoxFournisseur.Name = "TextBoxFournisseur";
        	this.TextBoxFournisseur.Size = new System.Drawing.Size(108, 20);
        	this.TextBoxFournisseur.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(14, 43);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(107, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Nom du fournisseur : ";
        	// 
        	// BtnDeconnection
        	// 
        	this.BtnDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnDeconnection.Location = new System.Drawing.Point(16, 513);
        	this.BtnDeconnection.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnDeconnection.Name = "BtnDeconnection";
        	this.BtnDeconnection.Size = new System.Drawing.Size(123, 63);
        	this.BtnDeconnection.TabIndex = 25;
        	this.BtnDeconnection.Text = "déconnection";
        	this.BtnDeconnection.UseVisualStyleBackColor = true;
        	// 
        	// panel4
        	// 
        	this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel4.Controls.Add(this.label5);
        	this.panel4.Controls.Add(this.label4);
        	this.panel4.Location = new System.Drawing.Point(143, 513);
        	this.panel4.Margin = new System.Windows.Forms.Padding(2);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(524, 63);
        	this.panel4.TabIndex = 24;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(10, 37);
        	this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(92, 13);
        	this.label5.TabIndex = 1;
        	this.label5.Text = "Date de création :";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(10, 12);
        	this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(78, 13);
        	this.label4.TabIndex = 0;
        	this.label4.Text = "Nom du client :";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(16, 10);
        	this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(304, 98);
        	this.pictureBox1.TabIndex = 22;
        	this.pictureBox1.TabStop = false;
        	// 
        	// BtnReset
        	// 
        	this.BtnReset.Location = new System.Drawing.Point(594, 348);
        	this.BtnReset.Name = "BtnReset";
        	this.BtnReset.Size = new System.Drawing.Size(75, 23);
        	this.BtnReset.TabIndex = 16;
        	this.BtnReset.Text = "Reset";
        	this.BtnReset.UseVisualStyleBackColor = true;
        	this.BtnReset.Click += new System.EventHandler(this.BtnResetClick);
        	// 
        	// ModificationFournisseur
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(810, 585);
        	this.Controls.Add(this.BtnRetour);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.BtnDeconnection);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.panel4);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "ModificationFournisseur";
        	this.Text = "ModificationFournisseur";
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel4.ResumeLayout(false);
        	this.panel4.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDeconnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button BtnModificationFournisseur;
        private System.Windows.Forms.Button BtnReset;
    }
}