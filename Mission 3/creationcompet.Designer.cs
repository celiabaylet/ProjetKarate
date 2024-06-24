namespace Mission_3
{
    partial class creationcompet
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dataGridViewCompetition = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEntraineur = new System.Windows.Forms.DataGridView();
            this.NOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Veuillez choisir votre numéro d\'entraineur \r\net votre competition";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(607, 351);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(89, 52);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridViewCompetition
            // 
            this.dataGridViewCompetition.AllowUserToAddRows = false;
            this.dataGridViewCompetition.AllowUserToDeleteRows = false;
            this.dataGridViewCompetition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.DATE_COMPETITION});
            this.dataGridViewCompetition.Location = new System.Drawing.Point(118, 233);
            this.dataGridViewCompetition.Name = "dataGridViewCompetition";
            this.dataGridViewCompetition.ReadOnly = true;
            this.dataGridViewCompetition.Size = new System.Drawing.Size(290, 150);
            this.dataGridViewCompetition.TabIndex = 5;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.ReadOnly = true;
            // 
            // DATE_COMPETITION
            // 
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.ReadOnly = true;
            // 
            // dataGridViewEntraineur
            // 
            this.dataGridViewEntraineur.AllowUserToAddRows = false;
            this.dataGridViewEntraineur.AllowUserToDeleteRows = false;
            this.dataGridViewEntraineur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntraineur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOM_ENTRAINEUR,
            this.PRENOM_ENTRAINEUR,
            this.NUM_ENTRAINEUR});
            this.dataGridViewEntraineur.Location = new System.Drawing.Point(92, 48);
            this.dataGridViewEntraineur.Name = "dataGridViewEntraineur";
            this.dataGridViewEntraineur.ReadOnly = true;
            this.dataGridViewEntraineur.Size = new System.Drawing.Size(349, 150);
            this.dataGridViewEntraineur.TabIndex = 4;
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
            // NUM_ENTRAINEUR
            // 
            this.NUM_ENTRAINEUR.HeaderText = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.Name = "NUM_ENTRAINEUR";
            this.NUM_ENTRAINEUR.ReadOnly = true;
            // 
            // creationcompet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewCompetition);
            this.Controls.Add(this.dataGridViewEntraineur);
            this.Name = "creationcompet";
            this.Text = "creationcompet";
            this.Load += new System.EventHandler(this.creationcompet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridView dataGridViewCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.DataGridView dataGridViewEntraineur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
    }
}