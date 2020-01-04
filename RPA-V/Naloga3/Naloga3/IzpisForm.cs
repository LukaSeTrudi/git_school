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

namespace Naloga3
{
    public partial class IzpisForm : Form
    {
        public IzpisForm()
        {
            InitializeComponent();
            loadListView();
        }
        public void loadListView()
        {
            ItemsDatabase db = new ItemsDatabase();
            List<Item> items = db.ReadItems();
            listView1.Items.Clear();
            foreach(Item i in items)
            {
                string[] rowList = { i.ItemID, i.ItemName, i.Price.ToString(), i.type };
                listView1.Items.Add(new ListViewItem(rowList));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
