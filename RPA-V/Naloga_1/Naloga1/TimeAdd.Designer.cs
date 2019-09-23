namespace Naloga1
{
    partial class TimeAdd
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
            this.history_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zacni_delovnik = new System.Windows.Forms.Button();
            this.koncaj_delovnik = new System.Windows.Forms.Button();
            this.koncaj_malico = new System.Windows.Forms.Button();
            this.zacni_malico = new System.Windows.Forms.Button();
            this.delovnik_timer = new System.Windows.Forms.Label();
            this.malica_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // history_listbox
            // 
            this.history_listbox.FormattingEnabled = true;
            this.history_listbox.ItemHeight = 16;
            this.history_listbox.Location = new System.Drawing.Point(12, 29);
            this.history_listbox.Name = "history_listbox";
            this.history_listbox.Size = new System.Drawing.Size(242, 404);
            this.history_listbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zgodovina";
            // 
            // zacni_delovnik
            // 
            this.zacni_delovnik.Location = new System.Drawing.Point(260, 52);
            this.zacni_delovnik.Name = "zacni_delovnik";
            this.zacni_delovnik.Size = new System.Drawing.Size(137, 29);
            this.zacni_delovnik.TabIndex = 9;
            this.zacni_delovnik.Text = "Začni Delovnik";
            this.zacni_delovnik.UseVisualStyleBackColor = true;
            this.zacni_delovnik.Click += new System.EventHandler(this.Zacni_delovnik_Click);
            // 
            // koncaj_delovnik
            // 
            this.koncaj_delovnik.Location = new System.Drawing.Point(260, 189);
            this.koncaj_delovnik.Name = "koncaj_delovnik";
            this.koncaj_delovnik.Size = new System.Drawing.Size(247, 29);
            this.koncaj_delovnik.TabIndex = 10;
            this.koncaj_delovnik.Text = "Končaj Delovnik";
            this.koncaj_delovnik.UseVisualStyleBackColor = true;
            this.koncaj_delovnik.Click += new System.EventHandler(this.Koncaj_delovnik_Click);
            // 
            // koncaj_malico
            // 
            this.koncaj_malico.Location = new System.Drawing.Point(260, 154);
            this.koncaj_malico.Name = "koncaj_malico";
            this.koncaj_malico.Size = new System.Drawing.Size(247, 29);
            this.koncaj_malico.TabIndex = 11;
            this.koncaj_malico.Text = "Končaj Malico";
            this.koncaj_malico.UseVisualStyleBackColor = true;
            this.koncaj_malico.Click += new System.EventHandler(this.Koncaj_malico_Click);
            // 
            // zacni_malico
            // 
            this.zacni_malico.Location = new System.Drawing.Point(260, 87);
            this.zacni_malico.Name = "zacni_malico";
            this.zacni_malico.Size = new System.Drawing.Size(137, 29);
            this.zacni_malico.TabIndex = 12;
            this.zacni_malico.Text = "Začni Malico";
            this.zacni_malico.UseVisualStyleBackColor = true;
            this.zacni_malico.Click += new System.EventHandler(this.Zacni_malico_Click);
            // 
            // delovnik_timer
            // 
            this.delovnik_timer.AutoSize = true;
            this.delovnik_timer.Location = new System.Drawing.Point(403, 58);
            this.delovnik_timer.Name = "delovnik_timer";
            this.delovnik_timer.Size = new System.Drawing.Size(64, 17);
            this.delovnik_timer.TabIndex = 13;
            this.delovnik_timer.Text = "00:00:00";
            // 
            // malica_timer
            // 
            this.malica_timer.AutoSize = true;
            this.malica_timer.Location = new System.Drawing.Point(403, 93);
            this.malica_timer.Name = "malica_timer";
            this.malica_timer.Size = new System.Drawing.Size(64, 17);
            this.malica_timer.TabIndex = 14;
            this.malica_timer.Text = "00:00:00";
            // 
            // TimeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.malica_timer);
            this.Controls.Add(this.delovnik_timer);
            this.Controls.Add(this.zacni_malico);
            this.Controls.Add(this.koncaj_malico);
            this.Controls.Add(this.koncaj_delovnik);
            this.Controls.Add(this.zacni_delovnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history_listbox);
            this.Name = "TimeAdd";
            this.Text = "Casovnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox history_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zacni_delovnik;
        private System.Windows.Forms.Button koncaj_delovnik;
        private System.Windows.Forms.Button koncaj_malico;
        private System.Windows.Forms.Button zacni_malico;
        private System.Windows.Forms.Label delovnik_timer;
        private System.Windows.Forms.Label malica_timer;
    }
}