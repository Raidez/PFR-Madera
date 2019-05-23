namespace Madera
{
    partial class FormProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjet));
            this.BtnNouveauProjet = new System.Windows.Forms.Button();
            this.BtnOuvrirProjet = new System.Windows.Forms.Button();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNouveauProjet
            // 
            this.BtnNouveauProjet.BackColor = System.Drawing.Color.White;
            this.BtnNouveauProjet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnNouveauProjet.Location = new System.Drawing.Point(2, 2);
            this.BtnNouveauProjet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNouveauProjet.Name = "BtnNouveauProjet";
            this.BtnNouveauProjet.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.BtnNouveauProjet.Size = new System.Drawing.Size(296, 63);
            this.BtnNouveauProjet.TabIndex = 9;
            this.BtnNouveauProjet.Text = "Créer un nouveau projet";
            this.BtnNouveauProjet.UseVisualStyleBackColor = false;
            this.BtnNouveauProjet.Click += new System.EventHandler(this.BtnNouveauProjetClick);
            // 
            // BtnOuvrirProjet
            // 
            this.BtnOuvrirProjet.BackColor = System.Drawing.Color.White;
            this.BtnOuvrirProjet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnOuvrirProjet.Location = new System.Drawing.Point(2, 68);
            this.BtnOuvrirProjet.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOuvrirProjet.Name = "BtnOuvrirProjet";
            this.BtnOuvrirProjet.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.BtnOuvrirProjet.Size = new System.Drawing.Size(296, 63);
            this.BtnOuvrirProjet.TabIndex = 10;
            this.BtnOuvrirProjet.Text = "Ouvrir un projet existant";
            this.BtnOuvrirProjet.UseVisualStyleBackColor = false;
            this.BtnOuvrirProjet.Click += new System.EventHandler(this.BtnOuvrirProjetClick);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.White;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConfig.Location = new System.Drawing.Point(2, 135);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.BtnConfig.Size = new System.Drawing.Size(296, 63);
            this.BtnConfig.TabIndex = 11;
            this.BtnConfig.Text = "Accéder à la configuration";
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.BtnNouveauProjet);
            this.panel1.Controls.Add(this.BtnOuvrirProjet);
            this.panel1.Controls.Add(this.BtnConfig);
            this.panel1.Location = new System.Drawing.Point(255, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(253, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Madera.Resources.icône;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProjet";
            this.Text = "Projet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deconnexion);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNouveauProjet;
        private System.Windows.Forms.Button BtnOuvrirProjet;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}