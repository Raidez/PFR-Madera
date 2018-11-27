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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.label2 = new System.Windows.Forms.Label();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.label3 = new System.Windows.Forms.Label();
        	this.BtnDeconnection = new System.Windows.Forms.Panel();
        	this.label4 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.panel1.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.panel3.SuspendLayout();
        	this.BtnDeconnection.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Location = new System.Drawing.Point(9, 150);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(305, 64);
        	this.panel1.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(18, 24);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(77, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Créer un Projet";
        	// 
        	// panel2
        	// 
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Location = new System.Drawing.Point(9, 218);
        	this.panel2.Margin = new System.Windows.Forms.Padding(2);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(305, 64);
        	this.panel2.TabIndex = 2;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(18, 24);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(79, 13);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Ouvrir un projet";
        	// 
        	// panel3
        	// 
        	this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel3.Controls.Add(this.label3);
        	this.panel3.Location = new System.Drawing.Point(9, 286);
        	this.panel3.Margin = new System.Windows.Forms.Padding(2);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(305, 64);
        	this.panel3.TabIndex = 3;
        	this.panel3.Click += new System.EventHandler(this.Panel3Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(18, 24);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(133, 13);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "Gestion de la configuration";
        	// 
        	// BtnDeconnection
        	// 
        	this.BtnDeconnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.BtnDeconnection.Controls.Add(this.label4);
        	this.BtnDeconnection.Location = new System.Drawing.Point(9, 427);
        	this.BtnDeconnection.Margin = new System.Windows.Forms.Padding(2);
        	this.BtnDeconnection.Name = "BtnDeconnection";
        	this.BtnDeconnection.Size = new System.Drawing.Size(178, 64);
        	this.BtnDeconnection.TabIndex = 4;
        	this.BtnDeconnection.Click += new System.EventHandler(this.BtnDeconnectionClick);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(18, 24);
        	this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(70, 13);
        	this.label4.TabIndex = 0;
        	this.label4.Text = "Déconnexion";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImage = global::Madera.Properties.Resources.logoMadera;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox1.Location = new System.Drawing.Point(9, 22);
        	this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(304, 98);
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// Projet
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(796, 547);
        	this.ControlBox = false;
        	this.Controls.Add(this.BtnDeconnection);
        	this.Controls.Add(this.panel3);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.pictureBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "Projet";
        	this.Text = "Projet";
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	this.panel3.ResumeLayout(false);
        	this.panel3.PerformLayout();
        	this.BtnDeconnection.ResumeLayout(false);
        	this.BtnDeconnection.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BtnDeconnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}