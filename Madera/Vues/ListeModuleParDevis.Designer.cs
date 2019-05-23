namespace Madera
{
    partial class ListeModuleParDevis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxParam = new System.Windows.Forms.ListBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxModuleDevis = new System.Windows.Forms.ListBox();
            this.listBoxModuleDisponible = new System.Windows.Forms.ListBox();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnAjouterModule = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnDeconnection = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelDevisDateCreation = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxParam);
            this.panel1.Controls.Add(this.BtnSupprimer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxModuleDevis);
            this.panel1.Controls.Add(this.listBoxModuleDisponible);
            this.panel1.Controls.Add(this.BtnModifier);
            this.panel1.Controls.Add(this.BtnAjouterModule);
            this.panel1.Controls.Add(this.BtnValider);
            this.panel1.Location = new System.Drawing.Point(9, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 350);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(636, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parametre du module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(406, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Module compris dans le devis";
            // 
            // listBoxParam
            // 
            this.listBoxParam.FormattingEnabled = true;
            this.listBoxParam.Location = new System.Drawing.Point(626, 29);
            this.listBoxParam.Name = "listBoxParam";
            this.listBoxParam.Size = new System.Drawing.Size(131, 238);
            this.listBoxParam.TabIndex = 20;
            this.listBoxParam.SelectedIndexChanged += new System.EventHandler(this.listBoxParam_SelectedIndexChanged);
            this.listBoxParam.DoubleClick += new System.EventHandler(this.listBoxParam_DoubleClick);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.Red;
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.Location = new System.Drawing.Point(441, 310);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(113, 24);
            this.BtnSupprimer.TabIndex = 19;
            this.BtnSupprimer.Text = "Retirer le module";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ajouter le module";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Module disponible";
            // 
            // listBoxModuleDevis
            // 
            this.listBoxModuleDevis.FormattingEnabled = true;
            this.listBoxModuleDevis.Location = new System.Drawing.Point(390, 29);
            this.listBoxModuleDevis.Name = "listBoxModuleDevis";
            this.listBoxModuleDevis.Size = new System.Drawing.Size(212, 277);
            this.listBoxModuleDevis.TabIndex = 16;
            this.listBoxModuleDevis.SelectedIndexChanged += new System.EventHandler(this.listBoxModuleDevis_SelectedIndexChanged);
            // 
            // listBoxModuleDisponible
            // 
            this.listBoxModuleDisponible.FormattingEnabled = true;
            this.listBoxModuleDisponible.Location = new System.Drawing.Point(6, 29);
            this.listBoxModuleDisponible.Name = "listBoxModuleDisponible";
            this.listBoxModuleDisponible.Size = new System.Drawing.Size(251, 277);
            this.listBoxModuleDisponible.TabIndex = 15;
            this.listBoxModuleDisponible.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxModuleDisponible_MouseDoubleClick);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnModifier.FlatAppearance.BorderSize = 0;
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.Location = new System.Drawing.Point(654, 310);
            this.BtnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(113, 24);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Valider Le projet";
            this.BtnModifier.UseVisualStyleBackColor = false;
            // 
            // BtnAjouterModule
            // 
            this.BtnAjouterModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnAjouterModule.FlatAppearance.BorderSize = 0;
            this.BtnAjouterModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouterModule.ForeColor = System.Drawing.Color.White;
            this.BtnAjouterModule.Location = new System.Drawing.Point(614, 368);
            this.BtnAjouterModule.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAjouterModule.Name = "BtnAjouterModule";
            this.BtnAjouterModule.Size = new System.Drawing.Size(91, 24);
            this.BtnAjouterModule.TabIndex = 5;
            this.BtnAjouterModule.Text = "Ajouter module";
            this.BtnAjouterModule.UseVisualStyleBackColor = false;
            // 
            // BtnValider
            // 
            this.BtnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnValider.FlatAppearance.BorderSize = 0;
            this.BtnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValider.ForeColor = System.Drawing.Color.White;
            this.BtnValider.Location = new System.Drawing.Point(710, 368);
            this.BtnValider.Margin = new System.Windows.Forms.Padding(2);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(65, 24);
            this.BtnValider.TabIndex = 4;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = false;
            // 
            // BtnRetour
            // 
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Location = new System.Drawing.Point(664, 513);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(123, 63);
            this.BtnRetour.TabIndex = 16;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click_1);
            // 
            // BtnDeconnection
            // 
            this.BtnDeconnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeconnection.Location = new System.Drawing.Point(9, 513);
            this.BtnDeconnection.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeconnection.Name = "BtnDeconnection";
            this.BtnDeconnection.Size = new System.Drawing.Size(123, 63);
            this.BtnDeconnection.TabIndex = 15;
            this.BtnDeconnection.Text = "déconnection";
            this.BtnDeconnection.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelDevisDateCreation);
            this.panel4.Controls.Add(this.labelNomClient);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(136, 513);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 63);
            this.panel4.TabIndex = 14;
            // 
            // labelDevisDateCreation
            // 
            this.labelDevisDateCreation.AutoSize = true;
            this.labelDevisDateCreation.Location = new System.Drawing.Point(108, 37);
            this.labelDevisDateCreation.Name = "labelDevisDateCreation";
            this.labelDevisDateCreation.Size = new System.Drawing.Size(118, 13);
            this.labelDevisDateCreation.TabIndex = 3;
            this.labelDevisDateCreation.Text = "labelDevisDateCreation";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(94, 13);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(77, 13);
            this.labelNomClient.TabIndex = 2;
            this.labelNomClient.Text = "labelNomClient";
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
            this.pictureBox1.BackgroundImage = global::Madera.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(537, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 63);
            this.button2.TabIndex = 31;
            this.button2.Text = "Imprimer en PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ListeModuleParDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDeconnection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListeModuleParDevis";
            this.Text = "CreerProjet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAjouterModule;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnDeconnection;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxModuleDevis;
        private System.Windows.Forms.ListBox listBoxModuleDisponible;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxParam;
        private System.Windows.Forms.Label labelDevisDateCreation;
        private System.Windows.Forms.Label labelNomClient;
		private System.Windows.Forms.Button button2;
	}
}
