namespace Mission_3
{
    partial class ListeDesParticipants
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
            this.dataGridViewListeParticipant = new System.Windows.Forms.DataGridView();
            this.Suite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_NAISSANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeParticipant
            // 
            this.dataGridViewListeParticipant.AllowUserToAddRows = false;
            this.dataGridViewListeParticipant.AllowUserToDeleteRows = false;
            this.dataGridViewListeParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LICENCE,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE,
            this.DATE_NAISSANCE,
            this.ADR_RUE_MEMBRE,
            this.CODE_POST_MEMBRE,
            this.ADR_VILLE_MEMBRE});
            this.dataGridViewListeParticipant.Location = new System.Drawing.Point(48, 127);
            this.dataGridViewListeParticipant.Name = "dataGridViewListeParticipant";
            this.dataGridViewListeParticipant.ReadOnly = true;
            this.dataGridViewListeParticipant.Size = new System.Drawing.Size(692, 179);
            this.dataGridViewListeParticipant.TabIndex = 0;
            // 
            // Suite
            // 
            this.Suite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Suite.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suite.Location = new System.Drawing.Point(0, 385);
            this.Suite.Name = "Suite";
            this.Suite.Size = new System.Drawing.Size(800, 65);
            this.Suite.TabIndex = 1;
            this.Suite.Text = "SUITE";
            this.Suite.UseVisualStyleBackColor = true;
            this.Suite.Click += new System.EventHandler(this.Suite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez choisir votre prénom :";
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.ReadOnly = true;
            // 
            // NOM_MEMBRE
            // 
            this.NOM_MEMBRE.HeaderText = "NOM_MEMBRE";
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.ReadOnly = true;
            // 
            // PRENOM_MEMBRE
            // 
            this.PRENOM_MEMBRE.HeaderText = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.ReadOnly = true;
            // 
            // DATE_NAISSANCE
            // 
            this.DATE_NAISSANCE.HeaderText = "DATE_NAISSANCE";
            this.DATE_NAISSANCE.Name = "DATE_NAISSANCE";
            this.DATE_NAISSANCE.ReadOnly = true;
            // 
            // ADR_RUE_MEMBRE
            // 
            this.ADR_RUE_MEMBRE.HeaderText = "ADR_RUE_MEMBRE";
            this.ADR_RUE_MEMBRE.Name = "ADR_RUE_MEMBRE";
            this.ADR_RUE_MEMBRE.ReadOnly = true;
            // 
            // CODE_POST_MEMBRE
            // 
            this.CODE_POST_MEMBRE.HeaderText = "CODE_POST_MEMBRE";
            this.CODE_POST_MEMBRE.Name = "CODE_POST_MEMBRE";
            this.CODE_POST_MEMBRE.ReadOnly = true;
            // 
            // ADR_VILLE_MEMBRE
            // 
            this.ADR_VILLE_MEMBRE.HeaderText = "ADR_VILLE_MEMBRE";
            this.ADR_VILLE_MEMBRE.Name = "ADR_VILLE_MEMBRE";
            this.ADR_VILLE_MEMBRE.ReadOnly = true;
            // 
            // ListeDesParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suite);
            this.Controls.Add(this.dataGridViewListeParticipant);
            this.Name = "ListeDesParticipants";
            this.Text = "ListeDesParticipants";
            this.Load += new System.EventHandler(this.ListeDesParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeParticipant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeParticipant;
        private System.Windows.Forms.Button Suite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_NAISSANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_MEMBRE;
    }
}