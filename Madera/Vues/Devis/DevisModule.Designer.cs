/*
 * Crée par SharpDevelop.
 * Utilisateur: alexis
 * Date: 04/04/2019
 * Heure: 15:20
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Madera.Vues.Devis
{
	partial class DevisModule
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
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.ImgLogo = new System.Windows.Forms.PictureBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.panel5 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.BtnClear = new System.Windows.Forms.Button();
        	this.BtnAjouter = new System.Windows.Forms.Button();
        	this.pictureBox3 = new System.Windows.Forms.PictureBox();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.panel4.SuspendLayout();
        	this.panel3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.panel5.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel4
        	// 
        	this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel4.Controls.Add(this.BtnRetour);
        	this.panel4.Location = new System.Drawing.Point(9, 500);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(766, 50);
        	this.panel4.TabIndex = 21;
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
        	// panel3
        	// 
        	this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
        	this.panel3.Controls.Add(this.ImgLogo);
        	this.panel3.Location = new System.Drawing.Point(9, 11);
        	this.panel3.Margin = new System.Windows.Forms.Padding(0);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(766, 100);
        	this.panel3.TabIndex = 20;
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
        	// panel1
        	// 
        	this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.panel5);
        	this.panel1.Controls.Add(this.pictureBox3);
        	this.panel1.Controls.Add(this.pictureBox2);
        	this.panel1.Controls.Add(this.pictureBox1);
        	this.panel1.Controls.Add(this.button1);
        	this.panel1.Location = new System.Drawing.Point(9, 113);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(766, 383);
        	this.panel1.TabIndex = 19;
        	// 
        	// panel5
        	// 
        	this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel5.Controls.Add(this.label1);
        	this.panel5.Controls.Add(this.BtnClear);
        	this.panel5.Controls.Add(this.BtnAjouter);
        	this.panel5.Location = new System.Drawing.Point(0, 0);
        	this.panel5.Margin = new System.Windows.Forms.Padding(2);
        	this.panel5.Name = "panel5";
        	this.panel5.Size = new System.Drawing.Size(766, 383);
        	this.panel5.TabIndex = 20;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(140, 12);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(98, 13);
        	this.label1.TabIndex = 16;
        	this.label1.Text = "Ajouter les modules";
        	// 
        	// BtnClear
        	// 
        	this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
        	this.BtnClear.FlatAppearance.BorderSize = 0;
        	this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnClear.ForeColor = System.Drawing.Color.White;
        	this.BtnClear.Location = new System.Drawing.Point(125, 298);
        	this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnClear.Name = "BtnClear";
        	this.BtnClear.Size = new System.Drawing.Size(113, 24);
        	this.BtnClear.TabIndex = 6;
        	this.BtnClear.Text = "Annuler";
        	this.BtnClear.UseVisualStyleBackColor = false;
        	// 
        	// BtnAjouter
        	// 
        	this.BtnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
        	this.BtnAjouter.FlatAppearance.BorderSize = 0;
        	this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnAjouter.ForeColor = System.Drawing.Color.White;
        	this.BtnAjouter.Location = new System.Drawing.Point(242, 298);
        	this.BtnAjouter.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnAjouter.Name = "BtnAjouter";
        	this.BtnAjouter.Size = new System.Drawing.Size(113, 24);
        	this.BtnAjouter.TabIndex = 5;
        	this.BtnAjouter.Text = "Ajouter";
        	this.BtnAjouter.UseVisualStyleBackColor = false;
        	// 
        	// pictureBox3
        	// 
        	this.pictureBox3.BackgroundImage = global::Madera.Resources.baseline_contact_phone_black_18dp;
        	this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox3.Location = new System.Drawing.Point(101, 164);
        	this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox3.Name = "pictureBox3";
        	this.pictureBox3.Size = new System.Drawing.Size(36, 34);
        	this.pictureBox3.TabIndex = 4;
        	this.pictureBox3.TabStop = false;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackgroundImage = global::Madera.Resources.baseline_home_black_18dp;
        	this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox2.Location = new System.Drawing.Point(101, 114);
        	this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(36, 34);
        	this.pictureBox2.TabIndex = 3;
        	this.pictureBox2.TabStop = false;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = global::Madera.Resources.baseline_insert_emoticon_black_18dp;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(101, 62);
        	this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(36, 34);
        	this.pictureBox1.TabIndex = 2;
        	this.pictureBox1.TabStop = false;
        	// 
        	// button1
        	// 
        	this.button1.FlatAppearance.BorderSize = 0;
        	this.button1.Location = new System.Drawing.Point(180, 288);
        	this.button1.Margin = new System.Windows.Forms.Padding(2);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(66, 24);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Annuller";
        	this.button1.UseVisualStyleBackColor = true;
        	// 
        	// DevisModule
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(784, 561);
        	this.Controls.Add(this.panel4);
        	this.Controls.Add(this.panel3);
        	this.Controls.Add(this.panel1);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "DevisModule";
        	this.Text = "CreerClient";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deconnexion);
        	this.panel4.ResumeLayout(false);
        	this.panel3.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel5.ResumeLayout(false);
        	this.panel5.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label label1;
	}
}
