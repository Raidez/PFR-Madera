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
            this.BtnDeconnexion = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRetour = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnGestionGammes = new System.Windows.Forms.Button();
            this.BtnGestionFournisseurs = new System.Windows.Forms.Button();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.BtnReduce = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.BtnDeconnexion.SuspendLayout();
            this.BtnRetour.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnGestionFournisseurs);
            this.panel1.Controls.Add(this.BtnGestionGammes);
            this.panel1.Location = new System.Drawing.Point(12, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 366);
            this.panel1.TabIndex = 2;
            // 
            // BtnDeconnexion
            // 
            this.BtnDeconnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnDeconnexion.Controls.Add(this.label3);
            this.BtnDeconnexion.Location = new System.Drawing.Point(12, 545);
            this.BtnDeconnexion.Name = "BtnDeconnexion";
            this.BtnDeconnexion.Size = new System.Drawing.Size(172, 77);
            this.BtnDeconnexion.TabIndex = 3;
            this.BtnDeconnexion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnDeconnexion_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Déconnexion";
            // 
            // BtnRetour
            // 
            this.BtnRetour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtnRetour.Controls.Add(this.label4);
            this.BtnRetour.Location = new System.Drawing.Point(878, 545);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(172, 77);
            this.BtnRetour.TabIndex = 4;
            this.BtnRetour.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRetour_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Retour";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(216, 545);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(656, 77);
            this.panel4.TabIndex = 5;
            // 
            // BtnGestionGammes
            // 
            this.BtnGestionGammes.BackColor = System.Drawing.Color.White;
            this.BtnGestionGammes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionGammes.Location = new System.Drawing.Point(11, 24);
            this.BtnGestionGammes.Name = "BtnGestionGammes";
            this.BtnGestionGammes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnGestionGammes.Size = new System.Drawing.Size(406, 78);
            this.BtnGestionGammes.TabIndex = 10;
            this.BtnGestionGammes.Text = "Gestion des gammes";
            this.BtnGestionGammes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionGammes.UseVisualStyleBackColor = false;
            // 
            // BtnGestionFournisseurs
            // 
            this.BtnGestionFournisseurs.BackColor = System.Drawing.Color.White;
            this.BtnGestionFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionFournisseurs.Location = new System.Drawing.Point(11, 106);
            this.BtnGestionFournisseurs.Name = "BtnGestionFournisseurs";
            this.BtnGestionFournisseurs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.BtnGestionFournisseurs.Size = new System.Drawing.Size(406, 78);
            this.BtnGestionFournisseurs.TabIndex = 11;
            this.BtnGestionFournisseurs.Text = "Gestion des fournisseurs";
            this.BtnGestionFournisseurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestionFournisseurs.UseVisualStyleBackColor = false;
            // 
            // panelNavBar
            // 
            this.panelNavBar.Location = new System.Drawing.Point(12, 1);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(978, 51);
            this.panelNavBar.TabIndex = 11;
            // 
            // BtnReduce
            // 
            this.BtnReduce.FlatAppearance.BorderSize = 0;
            this.BtnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReduce.Location = new System.Drawing.Point(996, 1);
            this.BtnReduce.Name = "BtnReduce";
            this.BtnReduce.Size = new System.Drawing.Size(35, 34);
            this.BtnReduce.TabIndex = 10;
            this.BtnReduce.Text = "_";
            this.BtnReduce.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(1037, 7);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(23, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // GestionConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.BtnReduce);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.BtnDeconnexion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionConfiguration";
            this.Text = "Gestion Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.BtnDeconnexion.ResumeLayout(false);
            this.BtnDeconnexion.PerformLayout();
            this.BtnRetour.ResumeLayout(false);
            this.BtnRetour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BtnDeconnexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BtnRetour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnGestionFournisseurs;
        private System.Windows.Forms.Button BtnGestionGammes;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button BtnReduce;
        private System.Windows.Forms.Button BtnExit;
    }
}