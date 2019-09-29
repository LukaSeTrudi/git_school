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
    public partial class form_dodajIzdelek : Form
    {
        public form_dodajIzdelek()
        {
            InitializeComponent();
        }

        private void AddIzdelek_Click(object sender, EventArgs e)
        {
            try
            {
                string name = input_name.Text;
                string desc = input_desc.Text;
                double price = Convert.ToDouble(input_price.Text);
                Item new_item = new Item(name, desc, price);
                ItemsDatabase db = new ItemsDatabase();
                db.SaveItem(new_item);
                MessageBox.Show("Item added !");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
