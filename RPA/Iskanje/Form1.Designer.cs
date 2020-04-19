namespace Iskanje
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_max = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_vsota = new System.Windows.Forms.Button();
            this.button_povprecje = new System.Windows.Forms.Button();
            this.button_vsebuje = new System.Windows.Forms.Button();
            this.button_vsebujebinarno = new System.Windows.Forms.Button();
            this.button_urediizbiranjem = new System.Windows.Forms.Button();
            this.button_uredimehurcki = new System.Windows.Forms.Button();
            this.button_hitrovstavi = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(140, 13);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 40);
            this.button_dodaj.TabIndex = 1;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(140, 87);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(86, 40);
            this.button_max.TabIndex = 2;
            this.button_max.Text = "Max";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(37, 87);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(75, 40);
            this.button_min.TabIndex = 3;
            this.button_min.Text = "Min";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_vsota
            // 
            this.button_vsota.Location = new System.Drawing.Point(37, 149);
            this.button_vsota.Name = "button_vsota";
            this.button_vsota.Size = new System.Drawing.Size(75, 40);
            this.button_vsota.TabIndex = 4;
            this.button_vsota.Text = "Vsota";
            this.button_vsota.UseVisualStyleBackColor = true;
            this.button_vsota.Click += new System.EventHandler(this.button_vsota_Click);
            // 
            // button_povprecje
            // 
            this.button_povprecje.Location = new System.Drawing.Point(140, 149);
            this.button_povprecje.Name = "button_povprecje";
            this.button_povprecje.Size = new System.Drawing.Size(86, 40);
            this.button_povprecje.TabIndex = 5;
            this.button_povprecje.Text = "Povprecje";
            this.button_povprecje.UseVisualStyleBackColor = true;
            this.button_povprecje.Click += new System.EventHandler(this.button_povprecje_Click);
            // 
            // button_vsebuje
            // 
            this.button_vsebuje.Location = new System.Drawing.Point(231, 13);
            this.button_vsebuje.Name = "button_vsebuje";
            this.button_vsebuje.Size = new System.Drawing.Size(75, 40);
            this.button_vsebuje.TabIndex = 6;
            this.button_vsebuje.Text = "Vsebuje";
            this.button_vsebuje.UseVisualStyleBackColor = true;
            this.button_vsebuje.Click += new System.EventHandler(this.button_vsebuje_Click);
            // 
            // button_vsebujebinarno
            // 
            this.button_vsebujebinarno.Location = new System.Drawing.Point(461, 13);
            this.button_vsebujebinarno.Name = "button_vsebujebinarno";
            this.button_vsebujebinarno.Size = new System.Drawing.Size(94, 52);
            this.button_vsebujebinarno.TabIndex = 7;
            this.button_vsebujebinarno.Text = "Vsebuje binarno";
            this.button_vsebujebinarno.UseVisualStyleBackColor = true;
            this.button_vsebujebinarno.Click += new System.EventHandler(this.button_vsebujebinarno_Click);
            // 
            // button_urediizbiranjem
            // 
            this.button_urediizbiranjem.Location = new System.Drawing.Point(461, 78);
            this.button_urediizbiranjem.Name = "button_urediizbiranjem";
            this.button_urediizbiranjem.Size = new System.Drawing.Size(94, 52);
            this.button_urediizbiranjem.TabIndex = 8;
            this.button_urediizbiranjem.Text = "Uredi z izbiranjem";
            this.button_urediizbiranjem.UseVisualStyleBackColor = true;
            this.button_urediizbiranjem.Click += new System.EventHandler(this.button_urediizbiranjem_Click);
            // 
            // button_uredimehurcki
            // 
            this.button_uredimehurcki.Location = new System.Drawing.Point(461, 208);
            this.button_uredimehurcki.Name = "button_uredimehurcki";
            this.button_uredimehurcki.Size = new System.Drawing.Size(94, 52);
            this.button_uredimehurcki.TabIndex = 10;
            this.button_uredimehurcki.Text = "Uredi z mehurcki";
            this.button_uredimehurcki.UseVisualStyleBackColor = true;
            this.button_uredimehurcki.Click += new System.EventHandler(this.button_uredimehurcki_Click);
            // 
            // button_hitrovstavi
            // 
            this.button_hitrovstavi.Location = new System.Drawing.Point(361, 143);
            this.button_hitrovstavi.Name = "button_hitrovstavi";
            this.button_hitrovstavi.Size = new System.Drawing.Size(94, 52);
            this.button_hitrovstavi.TabIndex = 11;
            this.button_hitrovstavi.Text = "Napolni nakljucno";
            this.button_hitrovstavi.UseVisualStyleBackColor = true;
            this.button_hitrovstavi.Click += new System.EventHandler(this.button_hitrouredi_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(34, 226);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(48, 17);
            this.result.TabIndex = 12;
            this.result.Text = "Result";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hitro uredi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Napolni urejeno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button_hitrovstavi);
            this.Controls.Add(this.button_uredimehurcki);
            this.Controls.Add(this.button_urediizbiranjem);
            this.Controls.Add(this.button_vsebujebinarno);
            this.Controls.Add(this.button_vsebuje);
            this.Controls.Add(this.button_povprecje);
            this.Controls.Add(this.button_vsota);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_vsota;
        private System.Windows.Forms.Button button_povprecje;
        private System.Windows.Forms.Button button_vsebuje;
        private System.Windows.Forms.Button button_vsebujebinarno;
        private System.Windows.Forms.Button button_urediizbiranjem;
        private System.Windows.Forms.Button button_uredimehurcki;
        private System.Windows.Forms.Button button_hitrovstavi;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

