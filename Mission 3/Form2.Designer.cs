namespace Mission_3
{
    partial class Form2
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
            this.Suppression = new System.Windows.Forms.Button();
            this.Creation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Suppression
            // 
            this.Suppression.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppression.Location = new System.Drawing.Point(578, 199);
            this.Suppression.Name = "Suppression";
            this.Suppression.Size = new System.Drawing.Size(186, 60);
            this.Suppression.TabIndex = 6;
            this.Suppression.Text = "Suppression";
            this.Suppression.UseVisualStyleBackColor = true;
            this.Suppression.Click += new System.EventHandler(this.Suppression_Click);
            // 
            // Creation
            // 
            this.Creation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Creation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creation.Location = new System.Drawing.Point(0, 391);
            this.Creation.Name = "Creation";
            this.Creation.Size = new System.Drawing.Size(800, 59);
            this.Creation.TabIndex = 5;
            this.Creation.Text = "Creation";
            this.Creation.UseVisualStyleBackColor = true;
            this.Creation.Click += new System.EventHandler(this.Creation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 144);
            this.label1.TabIndex = 4;
            this.label1.Text = "Affectation \r\ndes entraîneurs\r\ncomme membre du jury";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Suppression);
            this.Controls.Add(this.Creation);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Suppression;
        private System.Windows.Forms.Button Creation;
        private System.Windows.Forms.Label label1;
    }
}