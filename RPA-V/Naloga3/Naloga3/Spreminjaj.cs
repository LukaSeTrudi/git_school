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
    public partial class Spreminjaj : Form
    {
        public Spreminjaj()
        {
            InitializeComponent();
        }
        public void RefreshTable()
        {
            ItemsDatabase db = new ItemsDatabase();
            List<Item> items = db.ReadItems();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("columnid", "ItemCode");
            dataGridView1.Columns.Add("columnName", "ItemIme");
            dataGridView1.Columns.Add("columnPrice", "Price");
            dataGridView1.Columns.Add("columnType", "Tip");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "";
            btn.HeaderText = "Edit";
            btn.Text = "Uredi";
            btn.UseColumnTextForButtonValue = true;
            if (dataGridView1.Columns["edit"] == null)
            {
                dataGridView1.Columns.Add(btn);
            }
            foreach (Item i in items)
            {
                string[] row1 = { i.ItemID, i.ItemName, i.Price.ToString(), i.type, "s"};
                dataGridView1.Rows.Add(row1);
            }
        }
        private void Spreminjaj_Load(object sender, EventArgs e)
        {
            RefreshTable();
            
        }

        private void klik(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView v = (DataGridView)sender;
            if(e.ColumnIndex == 4)
            {
                string code = v[0, Convert.ToInt32(e.RowIndex.ToString())].Value.ToString();
                dodajForm frm = new dodajForm(code, this);
                frm.Show();
            }
        }
    }
}
