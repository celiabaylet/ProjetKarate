namespace Mission_3
{
    partial class Bilan
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
            this.textBoxDateSaison = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuiteVersParticipants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 194);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilan par saison \r\nd\'un candidat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDateSaison
            // 
            this.textBoxDateSaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateSaison.Location = new System.Drawing.Point(597, 279);
            this.textBoxDateSaison.Name = "textBoxDateSaison";
            this.textBoxDateSaison.Size = new System.Drawing.Size(110, 47);
            this.textBoxDateSaison.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saisir la saison voulue :";
            // 
            // SuiteVersParticipants
            // 
            this.SuiteVersParticipants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SuiteVersParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuiteVersParticipants.Location = new System.Drawing.Point(0, 386);
            this.SuiteVersParticipants.Name = "SuiteVersParticipants";
            this.SuiteVersParticipants.Size = new System.Drawing.Size(800, 64);
            this.SuiteVersParticipants.TabIndex = 8;
            this.SuiteVersParticipants.Text = "Suite";
            this.SuiteVersParticipants.UseVisualStyleBackColor = true;
            this.SuiteVersParticipants.Click += new System.EventHandler(this.SuiteVersParticipants_Click);
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuiteVersParticipants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDateSaison);
            this.Controls.Add(this.label1);
            this.Name = "Bilan";
            this.Text = "Bilan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDateSaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SuiteVersParticipants;
    }
}