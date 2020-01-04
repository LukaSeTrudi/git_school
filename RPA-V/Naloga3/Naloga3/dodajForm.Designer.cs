namespace Naloga3
{
    partial class dodajForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.serialText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cenaText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_izbrisi = new System.Windows.Forms.Button();
            this.button_spremeni = new System.Windows.Forms.Button();
            this.softwareItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ser. št";
            // 
            // serialText
            // 
            this.serialText.Location = new System.Drawing.Point(96, 34);
            this.serialText.Name = "serialText";
            this.serialText.Size = new System.Drawing.Size(100, 22);
            this.serialText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(275, 37);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(100, 22);
            this.imeText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena";
            // 
            // cenaText
            // 
            this.cenaText.Location = new System.Drawing.Point(484, 34);
            this.cenaText.Name = "cenaText";
            this.cenaText.Size = new System.Drawing.Size(100, 22);
            this.cenaText.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Software",
            "Computer",
            "Monitor"});
            this.comboBox1.Location = new System.Drawing.Point(44, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(577, 118);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(132, 51);
            this.dodaj_btn.TabIndex = 8;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 77);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_izbrisi
            // 
            this.button_izbrisi.Location = new System.Drawing.Point(440, 118);
            this.button_izbrisi.Name = "button_izbrisi";
            this.button_izbrisi.Size = new System.Drawing.Size(132, 51);
            this.button_izbrisi.TabIndex = 10;
            this.button_izbrisi.Text = "Izbrisi";
            this.button_izbrisi.UseVisualStyleBackColor = true;
            this.button_izbrisi.Visible = false;
            this.button_izbrisi.Click += new System.EventHandler(this.button_izbrisi_Click);
            // 
            // button_spremeni
            // 
            this.button_spremeni.Location = new System.Drawing.Point(302, 118);
            this.button_spremeni.Name = "button_spremeni";
            this.button_spremeni.Size = new System.Drawing.Size(132, 51);
            this.button_spremeni.TabIndex = 11;
            this.button_spremeni.Text = "Spremeni";
            this.button_spremeni.UseVisualStyleBackColor = true;
            this.button_spremeni.Visible = false;
            this.button_spremeni.Click += new System.EventHandler(this.button_spremeni_Click);
            // 
            // softwareItemBindingSource
            // 
            this.softwareItemBindingSource.DataSource = typeof(Naloga2_Items.SoftwareItem);
            // 
            // monitorBindingSource
            // 
            this.monitorBindingSource.DataSource = typeof(Naloga2_Items.Monitor);
            // 
            // softwareItemBindingSource1
            // 
            this.softwareItemBindingSource1.DataSource = typeof(Naloga2_Items.SoftwareItem);
            // 
            // dodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 317);
            this.Controls.Add(this.button_spremeni);
            this.Controls.Add(this.button_izbrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cenaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialText);
            this.Controls.Add(this.label1);
            this.Name = "dodajForm";
            this.Text = "dodajForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cenaText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource monitorBindingSource;
        private System.Windows.Forms.BindingSource softwareItemBindingSource;
        private System.Windows.Forms.BindingSource softwareItemBindingSource1;
        private System.Windows.Forms.Button button_izbrisi;
        private System.Windows.Forms.Button button_spremeni;
    }
}