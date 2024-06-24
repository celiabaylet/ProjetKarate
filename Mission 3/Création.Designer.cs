namespace Mission_3
{
    partial class Création
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
            this.dataGridViewClub = new System.Windows.Forms.DataGridView();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClub
            // 
            this.dataGridViewClub.AllowUserToDeleteRows = false;
            this.dataGridViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_CLUB,
            this.NOM_CLUB});
            this.dataGridViewClub.Location = new System.Drawing.Point(78, 155);
            this.dataGridViewClub.Name = "dataGridViewClub";
            this.dataGridViewClub.ReadOnly = true;
            this.dataGridViewClub.Size = new System.Drawing.Size(269, 115);
            this.dataGridViewClub.TabIndex = 1;
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
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(78, 54);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 2;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(78, 108);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = ": Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = ": Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ": Veuillez sélectionner le numéro du club voulu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Création
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.dataGridViewClub);
            this.Controls.Add(this.button1);
            this.Name = "Création";
            this.Text = "Création";
            this.Load += new System.EventHandler(this.Création_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClub;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        private System.Windows.Forms.Label label3;
    }
}