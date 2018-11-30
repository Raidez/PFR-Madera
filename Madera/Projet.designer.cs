namespace Madera
{
    partial class Projet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projet));
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnReduce = new System.Windows.Forms.Button();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.BtnCreerProjet = new System.Windows.Forms.Button();
            this.BtnOuvrirProjet = new System.Windows.Forms.Button();
            this.BtnGestionConfiguration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(1027, 7);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnReduce
            // 
            this.BtnReduce.FlatAppearance.BorderSize = 0;
            this.BtnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReduce.Location = new System.Drawing.Point(986, 1);
            this.BtnReduce.Name = "BtnReduce";
            this.BtnReduce.Size = new System.Drawing.Size(35, 34);
            this.BtnReduce.TabIndex = 6;
            this.BtnReduce.Text = "_";
            this.BtnReduce.UseVisualStyleBackColor = true;
            // 
            // panelNavBar
            // 
            this.panelNavBar.Location = new System.Drawing.Point(2, 1);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(978, 51);
            this.panelNavBar.TabIndex = 8;
            // 
            // BtnCreerProjet
            // 
            this.BtnCreerProjet.BackColor = System.Drawing.Color.White;
            this.BtnCreerProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreerProjet.Location = new System.Drawing.Point(12, 240);
            this.BtnCreerProjet.Name = "BtnCreerProjet";
            this.BtnCreerProjet.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnCreerProjet.Size = new System.Drawing.Size(406, 78);
            this.BtnCreerProjet.TabIndex = 9;
            this.BtnCreerProjet.Text = "Créer un projet";
            this.BtnCreerProjet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreerProjet.UseVisualStyleBackColor = false;
            // 
            // BtnOuvrirProjet
            // 
            this.BtnOuvrirProjet.BackColor = System.Drawing.Color.White;
            this.BtnOuvrirProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOuvrirProjet.Location = new System.Drawing.Point(12, 324);
            this.BtnOuvrirProjet.Name = "BtnOuvrirProjet";
            this.BtnOuvrirProjet.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnOuvrirProjet.Size = new System.Drawing.Size(406, 78);
            this.BtnOuvrirProjet.TabIndex = 10;
            this.BtnOuvrirProjet.Text = "Ouvrir un projet";
            this.BtnOuvrirProjet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOuvrirProjet.UseVisualStyleBackColor = false;
            // 
            // BtnGestionConfiguration
            // 
            this.BtnGestionConfiguration.BackColor = System.Drawing.Color.White;
            this.BtnGestionConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionConfiguration.Location = new System.Drawing.Point(12, 408);
            this.BtnGestionConfiguration.Name = "BtnGestionConfiguration";
            this.BtnGestionConfiguration.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnGestionConfiguration.Size = new System.Drawing.Size(406, 78);
            this.BtnGestionConfiguration.TabIndex = 11;
            this.BtnGestionConfiguration.Text = "Gestion de la configuration";
            this.BtnGestionConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionConfiguration.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Madera.Resources.logoMadera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.ControlBox = false;
            this.Controls.Add(this.BtnGestionConfiguration);
            this.Controls.Add(this.BtnOuvrirProjet);
            this.Controls.Add(this.BtnCreerProjet);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.BtnReduce);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Projet";
            this.Text = "Projet";
            this.Load += new System.EventHandler(this.Projet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReduce;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button BtnCreerProjet;
        private System.Windows.Forms.Button BtnOuvrirProjet;
        private System.Windows.Forms.Button BtnGestionConfiguration;
    }
}