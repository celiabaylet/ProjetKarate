namespace Mission_3
{
    partial class Mission3
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
            this.Acceuil = new System.Windows.Forms.Label();
            this.AffichageBilan = new System.Windows.Forms.Button();
            this.AffectationEntraîneurs = new System.Windows.Forms.Button();
            this.GestionEntraineur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Acceuil
            // 
            this.Acceuil.AutoSize = true;
            this.Acceuil.BackColor = System.Drawing.Color.Transparent;
            this.Acceuil.Font = new System.Drawing.Font("Viner Hand ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceuil.Location = new System.Drawing.Point(191, 30);
            this.Acceuil.Name = "Acceuil";
            this.Acceuil.Size = new System.Drawing.Size(412, 155);
            this.Acceuil.TabIndex = 0;
            this.Acceuil.Text = "Accueil";
            this.Acceuil.Click += new System.EventHandler(this.label1_Click);
            // 
            // AffichageBilan
            // 
            this.AffichageBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffichageBilan.Location = new System.Drawing.Point(246, 350);
            this.AffichageBilan.Name = "AffichageBilan";
            this.AffichageBilan.Size = new System.Drawing.Size(306, 55);
            this.AffichageBilan.TabIndex = 1;
            this.AffichageBilan.Text = "Affichage Bilan Global";
            this.AffichageBilan.UseVisualStyleBackColor = true;
            this.AffichageBilan.Click += new System.EventHandler(this.AffichageBilan_Click);
            // 
            // AffectationEntraîneurs
            // 
            this.AffectationEntraîneurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffectationEntraîneurs.Location = new System.Drawing.Point(246, 273);
            this.AffectationEntraîneurs.Name = "AffectationEntraîneurs";
            this.AffectationEntraîneurs.Size = new System.Drawing.Size(306, 55);
            this.AffectationEntraîneurs.TabIndex = 2;
            this.AffectationEntraîneurs.Text = "Affectation des entraîneurs";
            this.AffectationEntraîneurs.UseVisualStyleBackColor = true;
            this.AffectationEntraîneurs.Click += new System.EventHandler(this.AffectationEntraîneurs_Click);
            // 
            // GestionEntraineur
            // 
            this.GestionEntraineur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionEntraineur.Location = new System.Drawing.Point(246, 201);
            this.GestionEntraineur.Name = "GestionEntraineur";
            this.GestionEntraineur.Size = new System.Drawing.Size(306, 55);
            this.GestionEntraineur.TabIndex = 3;
            this.GestionEntraineur.Text = "Gestion des entraîneurs";
            this.GestionEntraineur.UseVisualStyleBackColor = true;
            this.GestionEntraineur.Click += new System.EventHandler(this.GestionEntraineur_Click);
            // 
            // Mission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mission_3.Properties.Resources.Page_acceuille;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.GestionEntraineur);
            this.Controls.Add(this.AffectationEntraîneurs);
            this.Controls.Add(this.AffichageBilan);
            this.Controls.Add(this.Acceuil);
            this.Name = "Mission3";
            this.Text = "Mission3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Acceuil;
        private System.Windows.Forms.Button AffichageBilan;
        private System.Windows.Forms.Button AffectationEntraîneurs;
        private System.Windows.Forms.Button GestionEntraineur;
    }
}