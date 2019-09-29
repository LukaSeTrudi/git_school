using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Naloga2_Items;

namespace Naloga2
{
    public partial class Izdelki : Form
    {
        public void showIzdelki()
        {
            ItemsDatabase db = new ItemsDatabase();
            List<Item> items = db.ReadItems();
            izdelki_panel.Controls.Clear();
            int i = 0;
            foreach (Item izdelek in items)
            {
                SplitContainer splt = new SplitContainer();
                splt.Size = new Size(772, 30);
                Label lb = new Label();
                lb.Text = izdelek.ItemName;
                splt.Panel1.Controls.Add(lb);
                splt.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
                splt.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
                Button btn = new Button();
                btn.Text = "Uredi";
                btn.Name = izdelek.ItemID;
                btn.Click += editWindowOpen;
                splt.Panel2.Controls.Add(btn);
                splt.IsSplitterFixed = true;
                splt.BackColor = i % 2 == 0 ? Color.White : Color.LightGray;
                izdelki_panel.Controls.Add(splt);
                i++;
            }
        }

        private void editWindowOpen(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.Name;
            EditItem ei = new EditItem(id, this);
            ei.Show();
        }

        public Izdelki()
        {
            InitializeComponent();
            showIzdelki();
        }
    }
}
