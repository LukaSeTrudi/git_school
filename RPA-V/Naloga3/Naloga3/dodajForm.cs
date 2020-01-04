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
    public partial class dodajForm : Form
    {
        Spreminjaj prejsn_form;
        Item lol;
        private string _code;
        public dodajForm()
        {
            InitializeComponent();
        }
        public dodajForm(string code, Spreminjaj formck)
        {
            prejsn_form = formck;
            InitializeComponent();
            serialText.Enabled = false;
            button_izbrisi.Visible = true;
            button_spremeni.Visible = true;
            dodaj_btn.Visible = false;
            ItemsDatabase d = new ItemsDatabase();
            lol = d.ReadItem(code);
            showCells(lol.type);
            _code = code;
            comboBox1.Visible = false;
            displayCells();
        }
        public void displayCells()
        {
            serialText.Text = lol.ItemID;
            imeText.Text = lol.ItemName;
            cenaText.Text = lol.Price.ToString();
            List<string> row = new List<string>();
            ItemsDatabase db = new ItemsDatabase();
            if (lol.type == "Software")
            {
                SoftwareItem i = db.ReadSoftware(_code);
                row.Add(i.LicenseKey);
                row.Add(i.SizeInMB.ToString());
                row.Add(i.version);
            }
            else if (lol.type == "Computer")
            {
                Computer c = db.ReadComputer(_code);
                row.Add(c.NoOfCores.ToString());
                row.Add(c.AmountOfRam.ToString());
                row.Add(c.HDDSize.ToString());
                row.Add(c.weight.ToString());
            }
            else if (lol.type == "Monitor")
            {
                Monitor m = db.ReadMonitor(_code);
                row.Add(m.weight.ToString());
                row.Add(m.Resolution);
                row.Add(m.diag);
                row.Add(m.MonitorType);
            }
            dataGridView1.Rows.Add(row.ToArray());
        }
        public void clearTables()
        {
            imeText.Text = "";
            cenaText.Text = "";
            serialText.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            showCells(selected);
            dataGridView1.Rows.Add();
        }
        public void showCells(string selected)
        {
            //string selected = comboBox1.SelectedItem.ToString();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (selected == "Software")
            {
                dataGridView1.Columns.Add("columnLicense", "Licenca");
                dataGridView1.Columns.Add("columnSize", "Velikost v MB");
                dataGridView1.Columns.Add("columnVersion", "Verzija");
            }
            else if (selected == "Computer")
            {
                dataGridView1.Columns.Add("columnNoOfCores", "Stevilo Jeder");
                dataGridView1.Columns.Add("columnRam", "RAM");
                dataGridView1.Columns.Add("columnHdd", "HDD");
                dataGridView1.Columns.Add("columnTeza", "Teza");
            }
            else if (selected == "Monitor")
            {
                dataGridView1.Columns.Add("columnTeza", "Teza");
                dataGridView1.Columns.Add("columnLocljivost", "Locljivost");
                dataGridView1.Columns.Add("columnDiagonala", "Velikost diagonale");
                dataGridView1.Columns.Add("columnTipMonitorja", "Tip Monitorja");
            }
        }
        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if(selected == "Software")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                string license = dataGridView1[0, 0].Value.ToString();
                double size = Convert.ToDouble(dataGridView1[1,0].Value.ToString());
                string verzija = dataGridView1[2, 0].Value.ToString();
                SoftwareItem si = new SoftwareItem(ime, code, size, price, license, verzija);
                ItemsDatabase itd = new ItemsDatabase();
                itd.SaveItem(si);
                clearTables();
            }
            else if(selected == "Computer")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                int cores = Convert.ToInt32(dataGridView1[0, 0].Value.ToString());
                int ram = Convert.ToInt32(dataGridView1[1, 0].Value.ToString());
                int hdd = Convert.ToInt32(dataGridView1[2, 0].Value.ToString());
                double teza = Convert.ToDouble(dataGridView1[3, 0].Value.ToString());
                Computer c = new Computer(ime, code, price, teza, cores, ram, hdd);
                ItemsDatabase itd = new ItemsDatabase();
                itd.SaveItem(c);
                clearTables();
            }
            else if(selected == "Monitor")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                double teza = Convert.ToDouble(dataGridView1[0, 0].Value.ToString());
                string locljivost = dataGridView1[1, 0].Value.ToString();
                string diag = dataGridView1[2, 0].Value.ToString();
                string tip = dataGridView1[3, 0].Value.ToString();
                Monitor m = new Monitor(ime, code, price, teza, diag, locljivost, tip);
                ItemsDatabase itd = new ItemsDatabase();
                itd.SaveItem(m);
                clearTables();
            }
        }

        private void button_izbrisi_Click(object sender, EventArgs e)
        {
            ItemsDatabase db = new ItemsDatabase();
            db.RemoveItem(_code);
            prejsn_form.RefreshTable();
            this.Close();
        }

        private void button_spremeni_Click(object sender, EventArgs e)
        {
            if(lol.type == "Software")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                string license = dataGridView1[0, 0].Value.ToString();
                double size = Convert.ToDouble(dataGridView1[1, 0].Value.ToString());
                string verzija = dataGridView1[2, 0].Value.ToString();
                SoftwareItem si = new SoftwareItem(ime, code, size, price, license, verzija);
                ItemsDatabase itd = new ItemsDatabase();
                itd.UpdateItem(si, _code);
                prejsn_form.RefreshTable();
                //SoftwareItem newItem = new SoftwareItem(name, code,) 

            }
            else if(lol.type == "Computer")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                int cores = Convert.ToInt32(dataGridView1[0, 0].Value.ToString());
                int ram = Convert.ToInt32(dataGridView1[1, 0].Value.ToString());
                int hdd = Convert.ToInt32(dataGridView1[2, 0].Value.ToString());
                double teza = Convert.ToDouble(dataGridView1[3, 0].Value.ToString());
                Computer c = new Computer(ime, code, price, teza, cores, ram, hdd);
                ItemsDatabase itd = new ItemsDatabase();
                itd.UpdateItem(c, _code);
                prejsn_form.RefreshTable();
            }
            else if(lol.type == "Monitor")
            {
                string ime = imeText.Text;
                string code = serialText.Text;
                double price = Convert.ToDouble(cenaText.Text);
                double teza = Convert.ToDouble(dataGridView1[0, 0].Value.ToString());
                string locljivost = dataGridView1[1, 0].Value.ToString();
                string diag = dataGridView1[2, 0].Value.ToString();
                string tip = dataGridView1[3, 0].Value.ToString();
                Monitor m = new Monitor(ime, code, price, teza, diag, locljivost, tip);
                ItemsDatabase itd = new ItemsDatabase();
                itd.UpdateItem(m, _code);
                prejsn_form.RefreshTable();
            }
        }
    }
}
