namespace Naloga2
{
    partial class EditItem
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_price = new System.Windows.Forms.TextBox();
            this.input_desc = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Uredi izdelek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime izdelka";
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(100, 242);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(185, 22);
            this.input_price.TabIndex = 10;
            // 
            // input_desc
            // 
            this.input_desc.Location = new System.Drawing.Point(100, 108);
            this.input_desc.Multiline = true;
            this.input_desc.Name = "input_desc";
            this.input_desc.Size = new System.Drawing.Size(207, 120);
            this.input_desc.TabIndex = 9;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(100, 65);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(207, 22);
            this.input_name.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Shrani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "Izbrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.input_desc);
            this.Controls.Add(this.input_name);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_price;
        private System.Windows.Forms.TextBox input_desc;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}