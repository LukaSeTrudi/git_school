namespace Naloga3
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
            this.izpis_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.spremeni_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izpis_btn
            // 
            this.izpis_btn.Location = new System.Drawing.Point(121, 100);
            this.izpis_btn.Name = "izpis_btn";
            this.izpis_btn.Size = new System.Drawing.Size(168, 62);
            this.izpis_btn.TabIndex = 0;
            this.izpis_btn.Text = "Izpis";
            this.izpis_btn.UseVisualStyleBackColor = true;
            this.izpis_btn.Click += new System.EventHandler(this.Izpis_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(121, 186);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(168, 62);
            this.dodaj_btn.TabIndex = 1;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.Dodaj_btn_Click);
            // 
            // spremeni_btn
            // 
            this.spremeni_btn.Location = new System.Drawing.Point(121, 270);
            this.spremeni_btn.Name = "spremeni_btn";
            this.spremeni_btn.Size = new System.Drawing.Size(168, 62);
            this.spremeni_btn.TabIndex = 2;
            this.spremeni_btn.Text = "Spremeni";
            this.spremeni_btn.UseVisualStyleBackColor = true;
            this.spremeni_btn.Click += new System.EventHandler(this.spremeni_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.spremeni_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.izpis_btn);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izpis_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button spremeni_btn;
    }
}

