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
            this.TextBoxNumRue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRetour
            // 
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Location = new System.Drawing.Point(895, 631);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(164, 77);
            this.BtnRetour.TabIndex = 26;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TextBoxEmail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TextBoxNumRue);
            this.panel1.Controls.Add(this.label8);
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
            this.panel1.Location = new System.Drawing.Point(21, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 487);
            this.panel1.TabIndex = 23;
            // 
            // BtnModificationFournisseur
            // 
            this.BtnModificationFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnModificationFournisseur.FlatAppearance.BorderSize = 0;
            this.BtnModificationFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificationFournisseur.ForeColor = System.Drawing.Color.White;
            this.BtnModificationFournisseur.Location = new System.Drawing.Point(911, 428);
            this.BtnModificationFournisseur.Name = "BtnModificationFournisseur";
            this.BtnModificationFournisseur.Size = new System.Drawing.Size(87, 29);
            this.BtnModificationFournisseur.TabIndex = 15;
            this.BtnModificationFournisseur.Text = "Valider";
            this.BtnModificationFournisseur.UseVisualStyleBackColor = false;
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
            this.ComboBoxPays.Location = new System.Drawing.Point(67, 270);
            this.ComboBoxPays.Name = "ComboBoxPays";
            this.ComboBoxPays.Size = new System.Drawing.Size(235, 24);
            this.ComboBoxPays.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Pays  :";
            // 
            // TextBoxVille
            // 
            this.TextBoxVille.Location = new System.Drawing.Point(62, 232);
            this.TextBoxVille.Name = "TextBoxVille";
            this.TextBoxVille.Size = new System.Drawing.Size(240, 22);
            this.TextBoxVille.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ville : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TextBoxCodePostal
            // 
            this.TextBoxCodePostal.Location = new System.Drawing.Point(109, 198);
            this.TextBoxCodePostal.Name = "TextBoxCodePostal";
            this.TextBoxCodePostal.Size = new System.Drawing.Size(193, 22);
            this.TextBoxCodePostal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Code Postal : ";
            // 
            // TextBoxRue
            // 
            this.TextBoxRue.Location = new System.Drawing.Point(71, 144);
            this.TextBoxRue.Name = "TextBoxRue";
            this.TextBoxRue.Size = new System.Drawing.Size(240, 22);
            this.TextBoxRue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rue : ";
            // 
            // TextBoxTelephone
            // 
            this.TextBoxTelephone.Location = new System.Drawing.Point(112, 112);
            this.TextBoxTelephone.Name = "TextBoxTelephone";
            this.TextBoxTelephone.Size = new System.Drawing.Size(199, 22);
            this.TextBoxTelephone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "téléphone  : ";
            // 
            // TextBoxFournisseur
            // 
            this.TextBoxFournisseur.Location = new System.Drawing.Point(169, 50);
            this.TextBoxFournisseur.Name = "TextBoxFournisseur";
            this.TextBoxFournisseur.Size = new System.Drawing.Size(142, 22);
            this.TextBoxFournisseur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du fournisseur : ";
            // 
            // BtnDeconnection
            // 
            this.BtnDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeconnection.Location = new System.Drawing.Point(21, 631);
            this.BtnDeconnection.Name = "BtnDeconnection";
            this.BtnDeconnection.Size = new System.Drawing.Size(164, 77);
            this.BtnDeconnection.TabIndex = 25;
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
            this.panel4.TabIndex = 24;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 120);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(778, 428);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(105, 29);
            this.BtnReset.TabIndex = 16;
            this.BtnReset.Text = " réinitialiser";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // TextBoxNumRue
            // 
            this.TextBoxNumRue.Location = new System.Drawing.Point(140, 172);
            this.TextBoxNumRue.Name = "TextBoxNumRue";
            this.TextBoxNumRue.Size = new System.Drawing.Size(167, 22);
            this.TextBoxNumRue.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numéro de rue  : ";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(71, 87);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(240, 22);
            this.TextBoxEmail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email  : ";
            // 
            // ModificationFournisseur
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
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxNumRue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnReset;
    }
}