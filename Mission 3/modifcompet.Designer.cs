namespace Mission_3
{
    partial class modifcompet
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCompetition2 = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEntraineur2 = new System.Windows.Forms.DataGridView();
            this.NOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_ENTRAINEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Afficher compétition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(674, 279);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(101, 64);
            this.buttonSupprimer.TabIndex = 9;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veuillez choisir votre numero d\'entraineur\r\n et votre competition";
            // 
            // dataGridViewCompetition2
            // 
            this.dataGridViewCompetition2.AllowUserToAddRows = false;
            this.dataGridViewCompetition2.AllowUserToDeleteRows = false;
            this.dataGridViewCompetition2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetition2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.DATE_COMPETITION});
            this.dataGridViewCompetition2.Location = new System.Drawing.Point(246, 236);
            this.dataGridViewCompetition2.Name = "dataGridViewCompetition2";
            this.dataGridViewCompetition2.ReadOnly = true;
            this.dataGridViewCompetition2.Size = new System.Drawing.Size(297, 150);
            this.dataGridViewCompetition2.TabIndex = 7;
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
            // dataGridViewEntraineur2
            // 
            this.dataGridViewEntraineur2.AllowUserToAddRows = false;
            this.dataGridViewEntraineur2.AllowUserToDeleteRows = false;
            this.dataGridViewEntraineur2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntraineur2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOM_ENTRAINEUR,
            this.PRENOM_ENTRAINEUR,
            this.NUM_ENTRAINEUR});
            this.dataGridViewEntraineur2.Location = new System.Drawing.Point(231, 65);
            this.dataGridViewEntraineur2.Name = "dataGridViewEntraineur2";
            this.dataGridViewEntraineur2.ReadOnly = true;
            this.dataGridViewEntraineur2.Size = new System.Drawing.Size(383, 150);
            this.dataGridViewEntraineur2.TabIndex = 6;
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
            // modifcompet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCompetition2);
            this.Controls.Add(this.dataGridViewEntraineur2);
            this.Name = "modifcompet";
            this.Text = "modifcompet";
            this.Load += new System.EventHandler(this.modifcompet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntraineur2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCompetition2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.DataGridView dataGridViewEntraineur2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_ENTRAINEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_ENTRAINEUR;
    }
}