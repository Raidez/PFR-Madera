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
        	this.BtnFourn = new System.Windows.Forms.Button();
        	this.BtnGamme = new System.Windows.Forms.Button();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.ImgLogo = new System.Windows.Forms.PictureBox();
        	this.BtnRetour = new System.Windows.Forms.Button();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.panel1.SuspendLayout();
        	this.panel3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
        	this.panel4.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Controls.Add(this.BtnFourn);
        	this.panel1.Controls.Add(this.BtnGamme);
        	this.panel1.Location = new System.Drawing.Point(9, 111);
        	this.panel1.Margin = new System.Windows.Forms.Padding(2);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(766, 383);
        	this.panel1.TabIndex = 2;
        	// 
        	// BtnFourn
        	// 
        	this.BtnFourn.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.BtnFourn.Location = new System.Drawing.Point(271, 174);
        	this.BtnFourn.Name = "BtnFourn";
        	this.BtnFourn.Size = new System.Drawing.Size(233, 62);
        	this.BtnFourn.TabIndex = 14;
        	this.BtnFourn.Text = "Gestion des fournisseurs";
        	this.BtnFourn.UseVisualStyleBackColor = true;
        	this.BtnFourn.Click += new System.EventHandler(this.BtnFourn_Click);
        	// 
        	// BtnGamme
        	// 
        	this.BtnGamme.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.BtnGamme.Location = new System.Drawing.Point(271, 106);
        	this.BtnGamme.Name = "BtnGamme";
        	this.BtnGamme.Size = new System.Drawing.Size(233, 62);
        	this.BtnGamme.TabIndex = 13;
        	this.BtnGamme.Text = "Gestion des gammes";
        	this.BtnGamme.UseVisualStyleBackColor = true;
        	this.BtnGamme.Click += new System.EventHandler(this.BtnGamme_Click);
        	// 
        	// panel3
        	// 
        	this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
        	this.panel3.Controls.Add(this.ImgLogo);
        	this.panel3.Location = new System.Drawing.Point(9, 9);
        	this.panel3.Margin = new System.Windows.Forms.Padding(0);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(766, 100);
        	this.panel3.TabIndex = 17;
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
        	// panel4
        	// 
        	this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel4.Controls.Add(this.BtnRetour);
        	this.panel4.Location = new System.Drawing.Point(9, 499);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(766, 50);
        	this.panel4.TabIndex = 18;
        	// 
        	// GestionConfiguration
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(784, 561);
        	this.Controls.Add(this.panel4);
        	this.Controls.Add(this.panel3);
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = global::Madera.Resources.icône;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "GestionConfiguration";
        	this.Text = "Gestion Configuration";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Deconnexion);
        	this.panel1.ResumeLayout(false);
        	this.panel3.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
        	this.panel4.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnGamme;
        private System.Windows.Forms.Button BtnFourn;
    }
}