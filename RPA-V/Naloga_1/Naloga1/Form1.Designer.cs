namespace Naloga1
{
    partial class Form1
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
            this.dodaj_zaposlene = new System.Windows.Forms.Button();
            this.zaposleni_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj_zaposlene
            // 
            this.dodaj_zaposlene.Location = new System.Drawing.Point(169, 384);
            this.dodaj_zaposlene.Name = "dodaj_zaposlene";
            this.dodaj_zaposlene.Size = new System.Drawing.Size(434, 54);
            this.dodaj_zaposlene.TabIndex = 1;
            this.dodaj_zaposlene.Text = "Dodaj";
            this.dodaj_zaposlene.UseVisualStyleBackColor = true;
            this.dodaj_zaposlene.Click += new System.EventHandler(this.Dodaj_zaposlene_Click);
            // 
            // zaposleni_panel
            // 
            this.zaposleni_panel.Location = new System.Drawing.Point(12, 40);
            this.zaposleni_panel.Name = "zaposleni_panel";
            this.zaposleni_panel.Size = new System.Drawing.Size(776, 338);
            this.zaposleni_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izberi se";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaposleni_panel);
            this.Controls.Add(this.dodaj_zaposlene);
            this.Name = "Form1";
            this.Text = "Zaposleni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodaj_zaposlene;
        private System.Windows.Forms.FlowLayoutPanel zaposleni_panel;
        private System.Windows.Forms.Label label1;
    }
}

