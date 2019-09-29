namespace Naloga2
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
            this.btn_addIzdelek = new System.Windows.Forms.Button();
            this.btn_showIzdelke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addIzdelek
            // 
            this.btn_addIzdelek.Location = new System.Drawing.Point(166, 38);
            this.btn_addIzdelek.Name = "btn_addIzdelek";
            this.btn_addIzdelek.Size = new System.Drawing.Size(180, 65);
            this.btn_addIzdelek.TabIndex = 0;
            this.btn_addIzdelek.Text = "Dodaj Izdelek";
            this.btn_addIzdelek.UseVisualStyleBackColor = true;
            this.btn_addIzdelek.Click += new System.EventHandler(this.Btn_addIzdelek_Click);
            // 
            // btn_showIzdelke
            // 
            this.btn_showIzdelke.Location = new System.Drawing.Point(166, 124);
            this.btn_showIzdelke.Name = "btn_showIzdelke";
            this.btn_showIzdelke.Size = new System.Drawing.Size(180, 65);
            this.btn_showIzdelke.TabIndex = 1;
            this.btn_showIzdelke.Text = "Pokazi Izdelke";
            this.btn_showIzdelke.UseVisualStyleBackColor = true;
            this.btn_showIzdelke.Click += new System.EventHandler(this.Btn_showIzdelke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 249);
            this.Controls.Add(this.btn_showIzdelke);
            this.Controls.Add(this.btn_addIzdelek);
            this.Name = "Form1";
            this.Text = "Naloga2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addIzdelek;
        private System.Windows.Forms.Button btn_showIzdelke;
    }
}

