namespace Mission_3
{
    partial class Page_Modification
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
            this.NomModif = new System.Windows.Forms.TextBox();
            this.PrénomModif = new System.Windows.Forms.TextBox();
            this.conclure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewNumClub = new System.Windows.Forms.DataGridView();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumClub)).BeginInit();
            this.SuspendLayout();
            // 
            // NomModif
            // 
            this.NomModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomModif.Location = new System.Drawing.Point(42, 245);
            this.NomModif.Name = "NomModif";
            this.NomModif.Size = new System.Drawing.Size(126, 29);
            this.NomModif.TabIndex = 1;
            // 
            // PrénomModif
            // 
            this.PrénomModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrénomModif.Location = new System.Drawing.Point(42, 308);
            this.PrénomModif.Name = "PrénomModif";
            this.PrénomModif.Size = new System.Drawing.Size(126, 29);
            this.PrénomModif.TabIndex = 2;
            this.PrénomModif.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // conclure
            // 
            this.conclure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.conclure.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclure.Location = new System.Drawing.Point(0, 377);
            this.conclure.Name = "conclure";
            this.conclure.Size = new System.Drawing.Size(800, 73);
            this.conclure.TabIndex = 3;
            this.conclure.Text = "Conclure";
            this.conclure.UseVisualStyleBackColor = true;
            this.conclure.Click += new System.EventHandler(this.conclure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = ": Nom du club";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = ": Prénom de l\'entraineur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = ": Nom de l\'entraineur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewNumClub
            // 
            this.dataGridViewNumClub.AllowUserToAddRows = false;
            this.dataGridViewNumClub.AllowUserToDeleteRows = false;
            this.dataGridViewNumClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_CLUB,
            this.NOM_CLUB,
            this.ADR_RUE_CLUB,
            this.CODE_POST_CLUB,
            this.ADR_VILLE_CLUB});
            this.dataGridViewNumClub.Location = new System.Drawing.Point(42, 46);
            this.dataGridViewNumClub.Name = "dataGridViewNumClub";
            this.dataGridViewNumClub.ReadOnly = true;
            this.dataGridViewNumClub.Size = new System.Drawing.Size(406, 157);
            this.dataGridViewNumClub.TabIndex = 7;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.ReadOnly = true;
            // 
            // NOM_CLUB
            // 
            this.NOM_CLUB.HeaderText = "NOM_CLUB";
            this.NOM_CLUB.Name = "NOM_CLUB";
            this.NOM_CLUB.ReadOnly = true;
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
            // Page_Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewNumClub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conclure);
            this.Controls.Add(this.PrénomModif);
            this.Controls.Add(this.NomModif);
            this.Name = "Page_Modification";
            this.Text = "Page_Modification";
            this.Load += new System.EventHandler(this.Page_Modification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NomModif;
        private System.Windows.Forms.TextBox PrénomModif;
        private System.Windows.Forms.Button conclure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewNumClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_CLUB;
    }
}