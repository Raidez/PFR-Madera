namespace Madera
{
    partial class GestionConfiguration
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
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.BtnGestionFournisseurs = new System.Windows.Forms.Panel();
        	this.label2 = new System.Windows.Forms.Label();
        	this.BtnGestionGammes = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.BtnDeconnexion = new System.Windows.Forms.Panel();
        	this.label3 = new System.Windows.Forms.Label();
        	this.BtnRetour = new System.Windows.Forms.Panel();
        	this.label4 = new System.Windows.Forms.Label();
        	this.panel4 = new System.Windows.Forms.Panel();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.BtnGestionFournisseurs.SuspendLayout();
        	this.BtnGestionGammes.SuspendLayout();
        	this.BtnDeconnexion.SuspendLayout();
        	this.BtnRetour.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(9, 10);
        	this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(304, 98);
        	this.pictureBox1.TabIndex = 1;
        	this.pictureBox1.TabStop = false;
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.BtnGestionFournisseurs);
        	this.panel1.Controls.Add(this.BtnGestionGammes);
        	this.panel1.Location = new System.Drawing.Point(9, 141);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(779, 298);
        	this.panel1.TabIndex = 2;
        	// 
        	// BtnGestionFournisseurs
        	// 
        	this.BtnGestionFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.BtnGestionFournisseurs.Controls.Add(this.label2);
        	this.BtnGestionFournisseurs.Location = new System.Drawing.Point(2, 90);
        	this.BtnGestionFournisseurs.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnGestionFournisseurs.Name = "BtnGestionFournisseurs";
        	this.BtnGestionFournisseurs.Size = new System.Drawing.Size(302, 63);
        	this.BtnGestionFournisseurs.TabIndex = 5;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(3, 28);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(122, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Gestion des fournisseurs";
        	// 
        	// BtnGestionGammes
        	// 
        	this.BtnGestionGammes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.BtnGestionGammes.Controls.Add(this.label1);
        	this.BtnGestionGammes.Location = new System.Drawing.Point(2, 23);
        	this.BtnGestionGammes.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnGestionGammes.Name = "BtnGestionGammes";
        	this.BtnGestionGammes.Size = new System.Drawing.Size(302, 63);
        	this.BtnGestionGammes.TabIndex = 4;
        	this.BtnGestionGammes.Click += new System.EventHandler(this.BtnGestionGammesClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(3, 22);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(105, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Gestion des gammes";
        	// 
        	// BtnDeconnexion
        	// 
        	this.BtnDeconnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.BtnDeconnexion.Controls.Add(this.label3);
        	this.BtnDeconnexion.Location = new System.Drawing.Point(9, 443);
        	this.BtnDeconnexion.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnDeconnexion.Name = "BtnDeconnexion";
        	this.BtnDeconnexion.Size = new System.Drawing.Size(130, 63);
        	this.BtnDeconnexion.TabIndex = 3;
        	this.BtnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexionClick);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(6, 24);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(70, 13);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "Déconnexion";
        	// 
        	// BtnRetour
        	// 
        	this.BtnRetour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.BtnRetour.Controls.Add(this.label4);
        	this.BtnRetour.Location = new System.Drawing.Point(658, 443);
        	this.BtnRetour.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnRetour.Name = "BtnRetour";
        	this.BtnRetour.Size = new System.Drawing.Size(130, 63);
        	this.BtnRetour.TabIndex = 4;
        	this.BtnRetour.Click += new System.EventHandler(this.BtnRetourClick);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(26, 24);
        	this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(39, 13);
        	this.label4.TabIndex = 1;
        	this.label4.Text = "Retour";
        	// 
        	// panel4
        	// 
        	this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel4.Location = new System.Drawing.Point(162, 443);
        	this.panel4.Margin = new System.Windows.Forms.Padding(2);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(492, 63);
        	this.panel4.TabIndex = 5;
        	// 
        	// GestionConfiguration
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(796, 547);
        	this.Controls.Add(this.panel4);
        	this.Controls.Add(this.BtnRetour);
        	this.Controls.Add(this.BtnDeconnexion);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.pictureBox1);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "GestionConfiguration";
        	this.Text = "Gestion Configuration";
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.BtnGestionFournisseurs.ResumeLayout(false);
        	this.BtnGestionFournisseurs.PerformLayout();
        	this.BtnGestionGammes.ResumeLayout(false);
        	this.BtnGestionGammes.PerformLayout();
        	this.BtnDeconnexion.ResumeLayout(false);
        	this.BtnDeconnexion.PerformLayout();
        	this.BtnRetour.ResumeLayout(false);
        	this.BtnRetour.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BtnGestionFournisseurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BtnGestionGammes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BtnDeconnexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BtnRetour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}