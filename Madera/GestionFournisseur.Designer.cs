namespace Madera
{
    partial class GestionFournisseur
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
            this.BtnDeconnection = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxRue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCodePostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxModifierFournisseur = new System.Windows.Forms.ComboBox();
            this.BtnAjoutFournisseur = new System.Windows.Forms.Button();
            this.BtnModificationFournisseur = new System.Windows.Forms.Button();
            this.BtnSupprimerFournisseur = new System.Windows.Forms.Button();
            this.ComboBoxSupprimerFournisseur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxPays = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRetour
            // 
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Location = new System.Drawing.Point(895, 631);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(164, 77);
            this.BtnRetour.TabIndex = 21;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnModificationFournisseur);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ComboBoxModifierFournisseur);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 487);
            this.panel1.TabIndex = 18;
            // 
            // BtnDeconnection
            // 
            this.BtnDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeconnection.Location = new System.Drawing.Point(21, 631);
            this.BtnDeconnection.Name = "BtnDeconnection";
            this.BtnDeconnection.Size = new System.Drawing.Size(164, 77);
            this.BtnDeconnection.TabIndex = 20;
            this.BtnDeconnection.Text = "déconnection";
            this.BtnDeconnection.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(191, 631);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 77);
            this.panel4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date de création :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom du client :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ComboBoxPays);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.BtnAjoutFournisseur);
            this.panel2.Controls.Add(this.TextBoxCodePostal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TextBoxRue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxTelephone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBoxNom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 166);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BtnSupprimerFournisseur);
            this.panel3.Controls.Add(this.ComboBoxSupprimerFournisseur);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(-1, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 166);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un fournisseur :";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Location = new System.Drawing.Point(169, 20);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(158, 22);
            this.TextBoxNom.TabIndex = 1;
            // 
            // TextBoxTelephone
            // 
            this.TextBoxTelephone.Location = new System.Drawing.Point(93, 65);
            this.TextBoxTelephone.Name = "TextBoxTelephone";
            this.TextBoxTelephone.Size = new System.Drawing.Size(158, 22);
            this.TextBoxTelephone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "téléphone :";
            // 
            // TextBoxRue
            // 
            this.TextBoxRue.Location = new System.Drawing.Point(305, 65);
            this.TextBoxRue.Name = "TextBoxRue";
            this.TextBoxRue.Size = new System.Drawing.Size(158, 22);
            this.TextBoxRue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rue :";
            // 
            // TextBoxCodePostal
            // 
            this.TextBoxCodePostal.Location = new System.Drawing.Point(566, 66);
            this.TextBoxCodePostal.Name = "TextBoxCodePostal";
            this.TextBoxCodePostal.Size = new System.Drawing.Size(56, 22);
            this.TextBoxCodePostal.TabIndex = 7;
            this.TextBoxCodePostal.Text = "53960";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Code postal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Modifier un fournisseur :";
            // 
            // ComboBoxModifierFournisseur
            // 
            this.ComboBoxModifierFournisseur.FormattingEnabled = true;
            this.ComboBoxModifierFournisseur.Location = new System.Drawing.Point(179, 188);
            this.ComboBoxModifierFournisseur.Name = "ComboBoxModifierFournisseur";
            this.ComboBoxModifierFournisseur.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxModifierFournisseur.TabIndex = 9;
            // 
            // BtnAjoutFournisseur
            // 
            this.BtnAjoutFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnAjoutFournisseur.FlatAppearance.BorderSize = 0;
            this.BtnAjoutFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjoutFournisseur.ForeColor = System.Drawing.Color.White;
            this.BtnAjoutFournisseur.Location = new System.Drawing.Point(823, 60);
            this.BtnAjoutFournisseur.Name = "BtnAjoutFournisseur";
            this.BtnAjoutFournisseur.Size = new System.Drawing.Size(87, 29);
            this.BtnAjoutFournisseur.TabIndex = 10;
            this.BtnAjoutFournisseur.Text = "Valider";
            this.BtnAjoutFournisseur.UseVisualStyleBackColor = false;
            // 
            // BtnModificationFournisseur
            // 
            this.BtnModificationFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnModificationFournisseur.FlatAppearance.BorderSize = 0;
            this.BtnModificationFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificationFournisseur.ForeColor = System.Drawing.Color.White;
            this.BtnModificationFournisseur.Location = new System.Drawing.Point(318, 188);
            this.BtnModificationFournisseur.Name = "BtnModificationFournisseur";
            this.BtnModificationFournisseur.Size = new System.Drawing.Size(87, 29);
            this.BtnModificationFournisseur.TabIndex = 11;
            this.BtnModificationFournisseur.Text = "Valider";
            this.BtnModificationFournisseur.UseVisualStyleBackColor = false;
            // 
            // BtnSupprimerFournisseur
            // 
            this.BtnSupprimerFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnSupprimerFournisseur.FlatAppearance.BorderSize = 0;
            this.BtnSupprimerFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimerFournisseur.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimerFournisseur.Location = new System.Drawing.Point(318, 26);
            this.BtnSupprimerFournisseur.Name = "BtnSupprimerFournisseur";
            this.BtnSupprimerFournisseur.Size = new System.Drawing.Size(87, 29);
            this.BtnSupprimerFournisseur.TabIndex = 14;
            this.BtnSupprimerFournisseur.Text = "Valider";
            this.BtnSupprimerFournisseur.UseVisualStyleBackColor = false;
            // 
            // ComboBoxSupprimerFournisseur
            // 
            this.ComboBoxSupprimerFournisseur.FormattingEnabled = true;
            this.ComboBoxSupprimerFournisseur.Location = new System.Drawing.Point(179, 26);
            this.ComboBoxSupprimerFournisseur.Name = "ComboBoxSupprimerFournisseur";
            this.ComboBoxSupprimerFournisseur.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxSupprimerFournisseur.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Supprimer un fournisseur  :";
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
            this.ComboBoxPays.Location = new System.Drawing.Point(685, 63);
            this.ComboBoxPays.Name = "ComboBoxPays";
            this.ComboBoxPays.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxPays.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pays  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 120);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // GestionFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDeconnection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionFournisseur";
            this.Text = "GestionFournisseur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboBoxModifierFournisseur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxCodePostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxRue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificationFournisseur;
        private System.Windows.Forms.Button BtnSupprimerFournisseur;
        private System.Windows.Forms.ComboBox ComboBoxSupprimerFournisseur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxPays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAjoutFournisseur;
    }
}