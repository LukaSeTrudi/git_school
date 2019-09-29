namespace Naloga2
{
    partial class Izdelki
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
            this.izdelki_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.izdelki_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // izdelki_panel
            // 
            this.izdelki_panel.Controls.Add(this.vScrollBar1);
            this.izdelki_panel.Location = new System.Drawing.Point(13, 13);
            this.izdelki_panel.Name = "izdelki_panel";
            this.izdelki_panel.Size = new System.Drawing.Size(490, 425);
            this.izdelki_panel.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 425);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Izdelki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.izdelki_panel);
            this.Name = "Izdelki";
            this.Text = "Izdelki";
            this.izdelki_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel izdelki_panel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}