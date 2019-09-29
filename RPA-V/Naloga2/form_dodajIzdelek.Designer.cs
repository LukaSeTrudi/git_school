namespace Naloga2
{
    partial class form_dodajIzdelek
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
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_desc = new System.Windows.Forms.TextBox();
            this.input_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addIzdelek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(111, 54);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(207, 22);
            this.input_name.TabIndex = 0;
            // 
            // input_desc
            // 
            this.input_desc.Location = new System.Drawing.Point(111, 97);
            this.input_desc.Multiline = true;
            this.input_desc.Name = "input_desc";
            this.input_desc.Size = new System.Drawing.Size(207, 120);
            this.input_desc.TabIndex = 1;
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(111, 231);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(185, 22);
            this.input_price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime izdelka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodaj nov izdelek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "$";
            // 
            // addIzdelek
            // 
            this.addIzdelek.Location = new System.Drawing.Point(103, 297);
            this.addIzdelek.Name = "addIzdelek";
            this.addIzdelek.Size = new System.Drawing.Size(137, 54);
            this.addIzdelek.TabIndex = 8;
            this.addIzdelek.Text = "Dodaj izdelek";
            this.addIzdelek.UseVisualStyleBackColor = true;
            this.addIzdelek.Click += new System.EventHandler(this.AddIzdelek_Click);
            // 
            // form_dodajIzdelek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 405);
            this.Controls.Add(this.addIzdelek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.input_desc);
            this.Controls.Add(this.input_name);
            this.Name = "form_dodajIzdelek";
            this.Text = "Nov Izdelek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_desc;
        private System.Windows.Forms.TextBox input_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addIzdelek;
    }
}