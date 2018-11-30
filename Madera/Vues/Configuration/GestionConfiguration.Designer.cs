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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.button1 = new System.Windows.Forms.Button();
        	this.BtnGestionGammes = new System.Windows.Forms.Button();
        	this.panelNavBar = new System.Windows.Forms.Panel();
        	this.BtnReduce = new System.Windows.Forms.Button();
        	this.BtnExit = new System.Windows.Forms.Button();
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.panel1.SuspendLayout();
        	this.panel2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.button1);
        	this.panel1.Controls.Add(this.BtnGestionGammes);
        	this.panel1.Location = new System.Drawing.Point(9, 141);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(779, 329);
        	this.panel1.TabIndex = 2;
        	// 
        	// button1
        	// 
        	this.button1.BackColor = System.Drawing.Color.White;
        	this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button1.Location = new System.Drawing.Point(8, 88);
        	this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.button1.Name = "button1";
        	this.button1.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
        	this.button1.Size = new System.Drawing.Size(304, 63);
        	this.button1.TabIndex = 12;
        	this.button1.Text = "Gestion des fournisseurs";
        	this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.button1.UseVisualStyleBackColor = false;
        	this.button1.Click += new System.EventHandler(this.BtnGestionFournisseurClick);
        	// 
        	// BtnGestionGammes
        	// 
        	this.BtnGestionGammes.BackColor = System.Drawing.Color.White;
        	this.BtnGestionGammes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnGestionGammes.Location = new System.Drawing.Point(8, 20);
        	this.BtnGestionGammes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.BtnGestionGammes.Name = "BtnGestionGammes";
        	this.BtnGestionGammes.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
        	this.BtnGestionGammes.Size = new System.Drawing.Size(304, 63);
        	this.BtnGestionGammes.TabIndex = 10;
        	this.BtnGestionGammes.Text = "Gestion des gammes";
        	this.BtnGestionGammes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	this.BtnGestionGammes.UseVisualStyleBackColor = false;
        	this.BtnGestionGammes.Click += new System.EventHandler(this.BtnGestionGammesClick);
        	// 
        	// panelNavBar
        	// 
        	this.panelNavBar.Location = new System.Drawing.Point(9, 1);
        	this.panelNavBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.panelNavBar.Name = "panelNavBar";
        	this.panelNavBar.Size = new System.Drawing.Size(734, 41);
        	this.panelNavBar.TabIndex = 11;
        	// 
        	// BtnReduce
        	// 
        	this.BtnReduce.FlatAppearance.BorderSize = 0;
        	this.BtnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnReduce.Location = new System.Drawing.Point(747, 1);
        	this.BtnReduce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.BtnReduce.Name = "BtnReduce";
        	this.BtnReduce.Size = new System.Drawing.Size(26, 28);
        	this.BtnReduce.TabIndex = 10;
        	this.BtnReduce.Text = "_";
        	this.BtnReduce.UseVisualStyleBackColor = true;
        	// 
        	// BtnExit
        	// 
        	this.BtnExit.FlatAppearance.BorderSize = 0;
        	this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnExit.Location = new System.Drawing.Point(778, 6);
        	this.BtnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.BtnExit.Name = "BtnExit";
        	this.BtnExit.Size = new System.Drawing.Size(17, 19);
        	this.BtnExit.TabIndex = 9;
        	this.BtnExit.Text = "X";
        	this.BtnExit.UseVisualStyleBackColor = true;
        	this.BtnExit.Click += new System.EventHandler(this.BtnExitClick);
        	// 
        	// BtnRetour
        	// 
        	this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.BtnRetour.Location = new System.Drawing.Point(656, 474);
        	this.BtnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.BtnRetour.Name = "BtnRetour";
        	this.BtnRetour.Size = new System.Drawing.Size(132, 63);
        	this.BtnRetour.TabIndex = 16;
        	this.BtnRetour.Text = "Retour";
        	this.BtnRetour.UseVisualStyleBackColor = true;
        	this.BtnRetour.Click += new System.EventHandler(this.BtnRetourClick);
        	// 
        	// button3
        	// 
        	this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button3.Location = new System.Drawing.Point(9, 474);
        	this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(114, 63);
        	this.button3.TabIndex = 15;
        	this.button3.Text = "déconnection";
        	this.button3.UseVisualStyleBackColor = true;
        	// 
        	// panel2
        	// 
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel2.Controls.Add(this.label1);
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Location = new System.Drawing.Point(128, 474);
        	this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(524, 63);
        	this.panel2.TabIndex = 14;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(10, 37);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(92, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Date de création :";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(10, 12);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(78, 13);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Nom du client :";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = global::Madera.Resources.logoMadera;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(9, 38);
        	this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(304, 98);
        	this.pictureBox1.TabIndex = 1;
        	this.pictureBox1.TabStop = false;
        	// 
        	// GestionConfiguration
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(796, 547);
        	this.Controls.Add(this.BtnRetour);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.panelNavBar);
        	this.Controls.Add(this.BtnReduce);
        	this.Controls.Add(this.BtnExit);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.pictureBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        	this.Name = "GestionConfiguration";
        	this.Text = "Gestion Configuration";
        	this.panel1.ResumeLayout(false);
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGestionGammes;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button BtnReduce;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}