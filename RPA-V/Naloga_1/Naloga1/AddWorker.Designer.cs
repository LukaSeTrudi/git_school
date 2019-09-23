namespace Naloga1
{
    partial class AddWorker
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
            this.input_firstname = new System.Windows.Forms.TextBox();
            this.input_lastname = new System.Windows.Forms.TextBox();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.date_joined = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum rojstva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum pridruzitve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geslo";
            // 
            // input_firstname
            // 
            this.input_firstname.Location = new System.Drawing.Point(200, 45);
            this.input_firstname.Name = "input_firstname";
            this.input_firstname.Size = new System.Drawing.Size(224, 22);
            this.input_firstname.TabIndex = 5;
            // 
            // input_lastname
            // 
            this.input_lastname.Location = new System.Drawing.Point(200, 83);
            this.input_lastname.Name = "input_lastname";
            this.input_lastname.Size = new System.Drawing.Size(224, 22);
            this.input_lastname.TabIndex = 6;
            // 
            // input_pass
            // 
            this.input_pass.Location = new System.Drawing.Point(200, 191);
            this.input_pass.Name = "input_pass";
            this.input_pass.Size = new System.Drawing.Size(224, 22);
            this.input_pass.TabIndex = 7;
            // 
            // date_birth
            // 
            this.date_birth.Location = new System.Drawing.Point(200, 120);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(224, 22);
            this.date_birth.TabIndex = 8;
            // 
            // date_joined
            // 
            this.date_joined.Location = new System.Drawing.Point(200, 157);
            this.date_joined.Name = "date_joined";
            this.date_joined.Size = new System.Drawing.Size(224, 22);
            this.date_joined.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_joined);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.input_pass);
            this.Controls.Add(this.input_lastname);
            this.Controls.Add(this.input_firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_firstname;
        private System.Windows.Forms.TextBox input_lastname;
        private System.Windows.Forms.TextBox input_pass;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.DateTimePicker date_joined;
        private System.Windows.Forms.Button button1;
    }
}