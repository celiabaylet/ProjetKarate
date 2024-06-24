namespace Mission_3
{
    partial class Modifier
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
            this.dataGridViewEntraineur = new System.Windows.Forms.DataGridView();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suppr = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEntraineur
            // 
            this.dataGridViewEntraineur.AllowUserToAddRows = false;
            this.dataGridViewEntraineur.AllowUserToDeleteRows = false;
            this.dataGridViewEntraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntraineur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_ENTRAINEUR,
            this.NUM_CLUB,
            this.NOM_ENTRAINEUR,
            this.PRENOM_ENTRAINEUR});
            this.dataGridViewEntraineur.Location = new System.Drawing.Point(43, 26);
            this.dataGridViewEntraineur.Name = "dataGridViewEntraineur";
            this.dataGridViewEntraineur.ReadOnly = true;
            this.dataGridViewEntraineur.Size = new System.Drawing.Size(369, 141);
            this.dataGridViewEntraineur.TabIndex = 0;
            this.dataGridViewEntraineur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntraineur_CellContentClick);
            // 
            // NUM_ENTRAINEUR
            // 
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.ReadOnly = true;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.ReadOnly = true;
            // 
            // NOM_ENTRAINEUR
            // 
            this.NOM_ENTRAINEUR.HeaderText = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.Name = "NOM_ENTRAINEUR";
            this.NOM_ENTRAINEUR.ReadOnly = true;
            // 
            // PRENOM_ENTRAINEUR
            // 
            this.PRENOM_ENTRAINEUR.HeaderText = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.Name = "PRENOM_ENTRAINEUR";
            this.PRENOM_ENTRAINEUR.ReadOnly = true;
            // 
            // Suppr
            // 
            this.Suppr.Location = new System.Drawing.Point(191, 223);
            this.Suppr.Name = "Suppr";
            this.Suppr.Size = new System.Drawing.Size(96, 49);
            this.Suppr.TabIndex = 1;
            this.Suppr.Text = "Supprimer";
            this.Suppr.UseVisualStyleBackColor = true;
            this.Suppr.Click += new System.EventHandler(this.Suppr_Click);
            // 
            // Modif
            // 
            this.Modif.Location = new System.Drawing.Point(43, 223);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(103, 49);
            this.Modif.TabIndex = 2;
            this.Modif.Text = "Modifier";
            this.Modif.UseVisualStyleBackColor = true;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.Suppr);
            this.Controls.Add(this.dataGridViewEntraineur);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEntraineur;
        private System.Windows.Forms.Button Suppr;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_ENTRAINEUR;
    }
}