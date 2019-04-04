/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 14:48
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Madera.Vues.Configuration
{
	partial class GestionMatière
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
        	this.BtnModifier = new System.Windows.Forms.Button();
        	this.BtnSupprimer = new System.Windows.Forms.Button();
        	this.CbxMatièreSupprimer = new System.Windows.Forms.ComboBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.CbxMatièreModifier = new System.Windows.Forms.ComboBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.CbxFournisseurAjouter = new System.Windows.Forms.ComboBox();
        	this.BtnAjouter = new System.Windows.Forms.Button();
        	this.TbxMatièreAjouter = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel5 = new System.Windows.Forms.Panel();
        	this.ImgLogo = new System.Windows.Forms.PictureBox();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.panel7 = new System.Windows.Forms.Panel();
        	this.panel8 = new System.Windows.Forms.Panel();
        	this.panel6 = new System.Windows.Forms.Panel();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.CbxFournisseurModifier = new System.Windows.Forms.ComboBox();
        	this.TbxMatièreModifier = new System.Windows.Forms.TextBox();
        	this.panel2.SuspendLayout();
        	this.panel5.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
        	this.panel4.SuspendLayout();
        	this.panel7.SuspendLayout();
        	this.panel3.SuspendLayout();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// BtnModifier
        	// 
        	this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        	this.BtnModifier.FlatAppearance.BorderSize = 0;
        	this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnModifier.ForeColor = System.Drawing.Color.White;
        	this.BtnModifier.Location = new System.Drawing.Point(692, 7);
        	this.BtnModifier.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnModifier.Name = "BtnModifier";
        	this.BtnModifier.Size = new System.Drawing.Size(65, 24);
        	this.BtnModifier.TabIndex = 11;
        	this.BtnModifier.Text = "Modifier";
        	this.BtnModifier.UseVisualStyleBackColor = false;
        	this.BtnModifier.Click += new System.EventHandler(this.BtnModifierClick);
        	// 
        	// BtnSupprimer
        	// 
        	this.BtnSupprimer.BackColor = System.Drawing.Color.Red;
        	this.BtnSupprimer.FlatAppearance.BorderSize = 0;
        	this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
        	this.BtnSupprimer.Location = new System.Drawing.Point(691, 9);
        	this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnSupprimer.Name = "BtnSupprimer";
        	this.BtnSupprimer.Size = new System.Drawing.Size(65, 24);
        	this.BtnSupprimer.TabIndex = 14;
        	this.BtnSupprimer.Text = "Supprimer";
        	this.BtnSupprimer.UseVisualStyleBackColor = false;
        	this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimerClick);
        	// 
        	// CbxMatièreSupprimer
        	// 
        	this.CbxMatièreSupprimer.FormattingEnabled = true;
        	this.CbxMatièreSupprimer.Location = new System.Drawing.Point(139, 12);
        	this.CbxMatièreSupprimer.Margin = new System.Windows.Forms.Padding(2);
        	this.CbxMatièreSupprimer.Name = "CbxMatièreSupprimer";
        	this.CbxMatièreSupprimer.Size = new System.Drawing.Size(120, 21);
        	this.CbxMatièreSupprimer.TabIndex = 13;
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(16, 15);
        	this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(121, 13);
        	this.label8.TabIndex = 12;
        	this.label8.Text = "Supprimer une matière  :";
        	// 
        	// CbxMatièreModifier
        	// 
        	this.CbxMatièreModifier.FormattingEnabled = true;
        	this.CbxMatièreModifier.Location = new System.Drawing.Point(140, 10);
        	this.CbxMatièreModifier.Margin = new System.Windows.Forms.Padding(2);
        	this.CbxMatièreModifier.Name = "CbxMatièreModifier";
        	this.CbxMatièreModifier.Size = new System.Drawing.Size(120, 21);
        	this.CbxMatièreModifier.TabIndex = 9;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(17, 13);
        	this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(108, 13);
        	this.label7.TabIndex = 8;
        	this.label7.Text = "Modifier une matière :";
        	// 
        	// panel2
        	// 
        	this.panel2.Controls.Add(this.CbxFournisseurAjouter);
        	this.panel2.Controls.Add(this.BtnAjouter);
        	this.panel2.Controls.Add(this.TbxMatièreAjouter);
        	this.panel2.Controls.Add(this.label1);
        	this.panel2.Location = new System.Drawing.Point(2, 2);
        	this.panel2.Margin = new System.Windows.Forms.Padding(2);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(760, 39);
        	this.panel2.TabIndex = 0;
        	// 
        	// CbxFournisseurAjouter
        	// 
        	this.CbxFournisseurAjouter.FormattingEnabled = true;
        	this.CbxFournisseurAjouter.Location = new System.Drawing.Point(265, 8);
        	this.CbxFournisseurAjouter.Name = "CbxFournisseurAjouter";
        	this.CbxFournisseurAjouter.Size = new System.Drawing.Size(120, 21);
        	this.CbxFournisseurAjouter.TabIndex = 11;
        	// 
        	// BtnAjouter
        	// 
        	this.BtnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
        	this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnAjouter.ForeColor = System.Drawing.Color.White;
        	this.BtnAjouter.Location = new System.Drawing.Point(692, 9);
        	this.BtnAjouter.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnAjouter.Name = "BtnAjouter";
        	this.BtnAjouter.Size = new System.Drawing.Size(65, 24);
        	this.BtnAjouter.TabIndex = 10;
        	this.BtnAjouter.Text = "Ajouter";
        	this.BtnAjouter.UseVisualStyleBackColor = false;
        	this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouterClick);
        	// 
        	// TbxMatièreAjouter
        	// 
        	this.TbxMatièreAjouter.Location = new System.Drawing.Point(140, 9);
        	this.TbxMatièreAjouter.Margin = new System.Windows.Forms.Padding(2);
        	this.TbxMatièreAjouter.Name = "TbxMatièreAjouter";
        	this.TbxMatièreAjouter.Size = new System.Drawing.Size(120, 20);
        	this.TbxMatièreAjouter.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(17, 12);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(104, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Ajouter une matière :";
        	// 
        	// panel5
        	// 
        	this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
        	this.panel5.Controls.Add(this.ImgLogo);
        	this.panel5.Location = new System.Drawing.Point(9, 9);
        	this.panel5.Margin = new System.Windows.Forms.Padding(0);
        	this.panel5.Name = "panel5";
        	this.panel5.Size = new System.Drawing.Size(766, 100);
        	this.panel5.TabIndex = 22;
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
        	this.panel4.TabIndex = 23;
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
        	// 
        	// panel7
        	// 
        	this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel7.Controls.Add(this.panel8);
        	this.panel7.Controls.Add(this.panel6);
        	this.panel7.Controls.Add(this.panel3);
        	this.panel7.Controls.Add(this.panel1);
        	this.panel7.Controls.Add(this.panel2);
        	this.panel7.Location = new System.Drawing.Point(9, 114);
        	this.panel7.Margin = new System.Windows.Forms.Padding(2);
        	this.panel7.Name = "panel7";
        	this.panel7.Size = new System.Drawing.Size(766, 383);
        	this.panel7.TabIndex = 24;
        	// 
        	// panel8
        	// 
        	this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel8.Location = new System.Drawing.Point(0, 93);
        	this.panel8.Margin = new System.Windows.Forms.Padding(0);
        	this.panel8.Name = "panel8";
        	this.panel8.Size = new System.Drawing.Size(765, 1);
        	this.panel8.TabIndex = 18;
        	// 
        	// panel6
        	// 
        	this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel6.Location = new System.Drawing.Point(0, 43);
        	this.panel6.Margin = new System.Windows.Forms.Padding(0);
        	this.panel6.Name = "panel6";
        	this.panel6.Size = new System.Drawing.Size(765, 1);
        	this.panel6.TabIndex = 17;
        	// 
        	// panel3
        	// 
        	this.panel3.Controls.Add(this.CbxMatièreSupprimer);
        	this.panel3.Controls.Add(this.label8);
        	this.panel3.Controls.Add(this.BtnSupprimer);
        	this.panel3.Location = new System.Drawing.Point(3, 96);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(758, 45);
        	this.panel3.TabIndex = 16;
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.CbxFournisseurModifier);
        	this.panel1.Controls.Add(this.TbxMatièreModifier);
        	this.panel1.Controls.Add(this.BtnModifier);
        	this.panel1.Controls.Add(this.CbxMatièreModifier);
        	this.panel1.Controls.Add(this.label7);
        	this.panel1.Location = new System.Drawing.Point(2, 47);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(759, 43);
        	this.panel1.TabIndex = 15;
        	// 
        	// CbxFournisseurModifier
        	// 
        	this.CbxFournisseurModifier.FormattingEnabled = true;
        	this.CbxFournisseurModifier.Location = new System.Drawing.Point(391, 10);
        	this.CbxFournisseurModifier.Name = "CbxFournisseurModifier";
        	this.CbxFournisseurModifier.Size = new System.Drawing.Size(120, 21);
        	this.CbxFournisseurModifier.TabIndex = 12;
        	// 
        	// TbxMatièreModifier
        	// 
        	this.TbxMatièreModifier.Location = new System.Drawing.Point(265, 11);
        	this.TbxMatièreModifier.Name = "TbxMatièreModifier";
        	this.TbxMatièreModifier.Size = new System.Drawing.Size(120, 20);
        	this.TbxMatièreModifier.TabIndex = 12;
        	// 
        	// GestionMatière
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(784, 561);
        	this.Controls.Add(this.panel7);
        	this.Controls.Add(this.panel4);
        	this.Controls.Add(this.panel5);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "GestionMatière";
        	this.Text = "GestionFournisseur";
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	this.panel5.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
        	this.panel4.ResumeLayout(false);
        	this.panel7.ResumeLayout(false);
        	this.panel3.ResumeLayout(false);
        	this.panel3.PerformLayout();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CbxMatièreModifier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxMatièreAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.ComboBox CbxMatièreSupprimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TbxMatièreModifier;
        private System.Windows.Forms.ComboBox CbxFournisseurAjouter;
        private System.Windows.Forms.ComboBox CbxFournisseurModifier;
	}
}
