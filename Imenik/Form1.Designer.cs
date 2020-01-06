namespace Imenik
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_imeniki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_novImenik = new System.Windows.Forms.TextBox();
            this.button_addImenik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_deletOseba = new System.Windows.Forms.Button();
            this.button_editOseba = new System.Windows.Forms.Button();
            this.button_addOseba = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_sortname = new System.Windows.Forms.Button();
            this.button_sortlast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izberi imenik";
            // 
            // comboBox_imeniki
            // 
            this.comboBox_imeniki.FormattingEnabled = true;
            this.comboBox_imeniki.Location = new System.Drawing.Point(106, 13);
            this.comboBox_imeniki.Name = "comboBox_imeniki";
            this.comboBox_imeniki.Size = new System.Drawing.Size(121, 24);
            this.comboBox_imeniki.TabIndex = 1;
            this.comboBox_imeniki.SelectedIndexChanged += new System.EventHandler(this.comboBox_imeniki_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nov imenik:";
            // 
            // textBox_novImenik
            // 
            this.textBox_novImenik.Location = new System.Drawing.Point(420, 14);
            this.textBox_novImenik.Name = "textBox_novImenik";
            this.textBox_novImenik.Size = new System.Drawing.Size(149, 22);
            this.textBox_novImenik.TabIndex = 3;
            // 
            // button_addImenik
            // 
            this.button_addImenik.Location = new System.Drawing.Point(595, 12);
            this.button_addImenik.Name = "button_addImenik";
            this.button_addImenik.Size = new System.Drawing.Size(106, 25);
            this.button_addImenik.TabIndex = 4;
            this.button_addImenik.Text = "Dodaj imenik";
            this.button_addImenik.UseVisualStyleBackColor = true;
            this.button_addImenik.Click += new System.EventHandler(this.button_addImenik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sortlast);
            this.groupBox1.Controls.Add(this.button_sortname);
            this.groupBox1.Controls.Add(this.button_deletOseba);
            this.groupBox1.Controls.Add(this.button_editOseba);
            this.groupBox1.Controls.Add(this.button_addOseba);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imenik";
            // 
            // button_deletOseba
            // 
            this.button_deletOseba.Enabled = false;
            this.button_deletOseba.Location = new System.Drawing.Point(237, 347);
            this.button_deletOseba.Name = "button_deletOseba";
            this.button_deletOseba.Size = new System.Drawing.Size(104, 35);
            this.button_deletOseba.TabIndex = 3;
            this.button_deletOseba.Text = "Izbrisi osebo";
            this.button_deletOseba.UseVisualStyleBackColor = true;
            this.button_deletOseba.Click += new System.EventHandler(this.button_deletOseba_Click);
            // 
            // button_editOseba
            // 
            this.button_editOseba.Enabled = false;
            this.button_editOseba.Location = new System.Drawing.Point(124, 347);
            this.button_editOseba.Name = "button_editOseba";
            this.button_editOseba.Size = new System.Drawing.Size(105, 35);
            this.button_editOseba.TabIndex = 2;
            this.button_editOseba.Text = "Uredi Osebo";
            this.button_editOseba.UseVisualStyleBackColor = true;
            this.button_editOseba.Click += new System.EventHandler(this.button_editOseba_Click);
            // 
            // button_addOseba
            // 
            this.button_addOseba.Location = new System.Drawing.Point(7, 347);
            this.button_addOseba.Name = "button_addOseba";
            this.button_addOseba.Size = new System.Drawing.Size(111, 35);
            this.button_addOseba.TabIndex = 1;
            this.button_addOseba.Text = "Dodaj Osebo";
            this.button_addOseba.UseVisualStyleBackColor = true;
            this.button_addOseba.Click += new System.EventHandler(this.button_addOseba_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(759, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_sortname
            // 
            this.button_sortname.Location = new System.Drawing.Point(598, 19);
            this.button_sortname.Name = "button_sortname";
            this.button_sortname.Size = new System.Drawing.Size(75, 45);
            this.button_sortname.TabIndex = 4;
            this.button_sortname.Text = "Sort by name";
            this.button_sortname.UseVisualStyleBackColor = true;
            this.button_sortname.Click += new System.EventHandler(this.button_sortname_Click);
            // 
            // button_sortlast
            // 
            this.button_sortlast.Location = new System.Drawing.Point(679, 19);
            this.button_sortlast.Name = "button_sortlast";
            this.button_sortlast.Size = new System.Drawing.Size(75, 45);
            this.button_sortlast.TabIndex = 5;
            this.button_sortlast.Text = "Sort by lastname";
            this.button_sortlast.UseVisualStyleBackColor = true;
            this.button_sortlast.Click += new System.EventHandler(this.button_sortlast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_addImenik);
            this.Controls.Add(this.textBox_novImenik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_imeniki);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_imeniki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_novImenik;
        private System.Windows.Forms.Button button_addImenik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_deletOseba;
        private System.Windows.Forms.Button button_editOseba;
        private System.Windows.Forms.Button button_addOseba;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_sortlast;
        private System.Windows.Forms.Button button_sortname;
    }
}

