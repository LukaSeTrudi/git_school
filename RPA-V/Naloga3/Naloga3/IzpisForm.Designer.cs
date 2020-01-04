namespace Naloga3
{
    partial class IzpisForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "1",
            "1",
            "3",
            "2"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIDHeader,
            this.itemNameHeader,
            this.priceHeader,
            this.itemTypeHeader});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // itemIDHeader
            // 
            this.itemIDHeader.Text = "ItemID";
            this.itemIDHeader.Width = 100;
            // 
            // itemNameHeader
            // 
            this.itemNameHeader.Text = "ItemName";
            this.itemNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemNameHeader.Width = 150;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceHeader.Width = 150;
            // 
            // itemTypeHeader
            // 
            this.itemTypeHeader.Text = "ItemType";
            this.itemTypeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemTypeHeader.Width = 150;
            // 
            // IzpisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.listView1);
            this.Name = "IzpisForm";
            this.Text = "IzpisForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemIDHeader;
        private System.Windows.Forms.ColumnHeader itemNameHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
        private System.Windows.Forms.ColumnHeader itemTypeHeader;
    }
}