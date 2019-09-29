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
    public partial class EditItem : Form
    {
        int id_item;
        Izdelki prev_form;
        public EditItem(string id, Izdelki iz)
        {
            InitializeComponent();
            id_item = Convert.ToInt32(id);
            prev_form = iz;
            loadData();
        }

        private void loadData()
        {
            ItemsDatabase db = new ItemsDatabase();
            Item itm = db.ReadItem(id_item);
            input_name.Text = itm.ItemName;
            input_desc.Text = itm.ItemDesc;
            input_price.Text = itm.Price.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //shrani
            try
            {
                Item newItm = new Item(input_name.Text, input_desc.Text, Convert.ToDouble(input_price.Text));
                ItemsDatabase db = new ItemsDatabase();
                db.UpdateItem(id_item, newItm);
                prev_form.showIzdelki();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //izbris
            ItemsDatabase db = new ItemsDatabase();
            db.DeleteItem(id_item);
            prev_form.showIzdelki();
            this.Dispose();
            
        }
    }
}
