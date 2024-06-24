namespace Mission_3
{
    partial class Bilan_saison
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DATE_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATE_COMPETITION,
            this.ADR_RUE_CLUB,
            this.CODE_POST_CLUB,
            this.ADR_VILLE_CLUB,
            this.NOTE_GLOBALE});
            this.dataGridView1.Location = new System.Drawing.Point(119, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // DATE_COMPETITION
            // 
            this.DATE_COMPETITION.HeaderText = "DATE_COMPETITION";
            this.DATE_COMPETITION.Name = "DATE_COMPETITION";
            this.DATE_COMPETITION.ReadOnly = true;
            // 
            // ADR_RUE_CLUB
            // 
            this.ADR_RUE_CLUB.HeaderText = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.Name = "ADR_RUE_CLUB";
            this.ADR_RUE_CLUB.ReadOnly = true;
            // 
            // CODE_POST_CLUB
            // 
            this.CODE_POST_CLUB.HeaderText = "CODE_POST_CLUB";
            this.CODE_POST_CLUB.Name = "CODE_POST_CLUB";
            this.CODE_POST_CLUB.ReadOnly = true;
            // 
            // ADR_VILLE_CLUB
            // 
            this.ADR_VILLE_CLUB.HeaderText = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.Name = "ADR_VILLE_CLUB";
            this.ADR_VILLE_CLUB.ReadOnly = true;
            // 
            // NOTE_GLOBALE
            // 
            this.NOTE_GLOBALE.HeaderText = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.Name = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 146);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voici votre bilan \r\nde saison : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bilan_saison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bilan_saison";
            this.Text = "Bilan_saison";
            this.Load += new System.EventHandler(this.Bilan_saison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        private System.Windows.Forms.Label label1;
    }
}