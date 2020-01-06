namespace Imenik
{
    partial class OsebaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_priimek = new System.Windows.Forms.TextBox();
            this.textBox_naslov = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naslov:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel. stevilka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(144, 13);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(206, 22);
            this.textBox_ime.TabIndex = 5;
            // 
            // textBox_priimek
            // 
            this.textBox_priimek.Location = new System.Drawing.Point(144, 49);
            this.textBox_priimek.Name = "textBox_priimek";
            this.textBox_priimek.Size = new System.Drawing.Size(206, 22);
            this.textBox_priimek.TabIndex = 6;
            // 
            // textBox_naslov
            // 
            this.textBox_naslov.Location = new System.Drawing.Point(144, 84);
            this.textBox_naslov.Name = "textBox_naslov";
            this.textBox_naslov.Size = new System.Drawing.Size(206, 22);
            this.textBox_naslov.TabIndex = 7;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(144, 120);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(206, 22);
            this.textBox_tel.TabIndex = 8;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(144, 153);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(206, 22);
            this.textBox_email.TabIndex = 9;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(115, 186);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(129, 44);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Dodaj Osebo";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // OsebaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 242);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_naslov);
            this.Controls.Add(this.textBox_priimek);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OsebaForm";
            this.Text = "OsebaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_priimek;
        private System.Windows.Forms.TextBox textBox_naslov;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_add;
    }
}